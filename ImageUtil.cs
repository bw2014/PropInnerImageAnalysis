using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;

namespace PropInnerImageAnalysis
{
    class ImageUtil
    {
        public static Bitmap ResizeBitmap(Bitmap bmp, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(bmp, 0, 0, width, height);
            }
            return result;
        }
        public static Bitmap ResizeBitmap(Image<Bgr,byte>img, int width, int height)
        {
            Bitmap bmp = img.ToBitmap();
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(bmp, 0, 0, width, height);
            }
            return result;
        }
        public static Bitmap ResizeBitmap(Image<Gray, byte> img, int width, int height)
        {
            Bitmap bmp = img.ToBitmap();
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(bmp, 0, 0, width, height);
            }
            return result;
        }


        public static Rectangle FindROI(Image<Bgr, byte> src, int width, int height)
        {
            VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
            Dictionary<int, double> contourArea = new Dictionary<int, double>();
            Image<Gray, byte> gray = src.Convert<Gray, byte>();
            CvInvoke.GaussianBlur(gray, gray, new Size(5, 5), 1, 0);
            CvInvoke.Threshold(gray, gray, 180, 255, ThresholdType.Otsu);

            Mat structElement = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Cross, new Size(5, 5), new Point(-1, -1));
            //CvInvoke.MorphologyEx(gray, gray, Emgu.CV.CvEnum.MorphOp.Open, structElement, new Point(-1, -1), 3, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar(0, 0, 0));
            CvInvoke.BitwiseNot(gray, gray);


            CvInvoke.FindContours(gray, contours, null, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxNone);
            int ksize = contours.Size;
            for (int i = 0; i < ksize; i++)
            {
                VectorOfPoint contour = contours[i];
                contourArea.Add(i, CvInvoke.ContourArea(contour));
            }
            var sortedArea = (from item in contourArea
                              orderby item.Value descending
                              select item).ToList();

            if (ksize > 0)
            {
                CircleF circle = CvInvoke.MinEnclosingCircle(contours[sortedArea[0].Key]);
                int centX = (int)circle.Center.X;
                int centY = (int)circle.Center.Y;
                if ((centX + width / 2) > src.Width)
                    centX = src.Width - width - 20;
                else
                {
                    if ((centX - (width / 2)) < 0)
                        centX = 200;
                    else
                        centX = centX - (width / 2);
                }

                if ((centY + height / 2) > src.Height)
                    centY = src.Height - height - 20;
                else
                {
                    if ((centY - (height / 2)) < 0)
                        centY = 200;
                    else
                        centY = centY - (height / 2);
                }
                return new Rectangle(centX, centY, width, height);
            }
            else
            {
                return new Rectangle(0, 0, src.Width, src.Height);
            }
        }

        public static Rectangle FindROI(Bitmap bmp, int width, int height)
        {
            
            Image<Bgr, byte> src = bmp.ToImage<Bgr, byte>();
            return FindROI(src, width, height);
        }
        public static List<CircleF> MaxCircles(Image<Gray, byte> src)
        {
            List<CircleF> smallCircles = new List<CircleF>();

            using (VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint())
            {
                CvInvoke.FindContours(src, contours, null, RetrType.External, ChainApproxMethod.ChainApproxNone);

                int count = contours.Size;

                for (int i = 0; i < count; i++)
                {
                    using (VectorOfPoint contour = contours[i])
                    {
                        CircleF circle = CvInvoke.MinEnclosingCircle(contour);
                        smallCircles.Add(circle);
                    }
                }
            }
            return smallCircles;
        }
        public static Image<Gray, byte> ConvexHull(Image<Gray, byte> src)
        {
            Image<Gray, byte> draw = src.CopyBlank();
            using (VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint())
            {
                CvInvoke.FindContours(src, contours, null, RetrType.External, ChainApproxMethod.ChainApproxNone);

                int count = contours.Size;
                for (int i = 0; i < count; i++)
                {
                    using (VectorOfPoint contour = contours[i])
                    {
                        PointF[] temp = Array.ConvertAll(contour.ToArray(), new Converter<Point, PointF>(Point2PointF));
                        PointF[] pts = CvInvoke.ConvexHull(temp, true);

                        for (int j = 0; j < pts.Length; j++)
                        {
                            Point p1 = new Point((int)pts[j].X, (int)pts[j].Y);
                            Point p2;

                            if (j == pts.Length - 1)
                                p2 = new Point((int)pts[0].X, (int)pts[0].Y);
                            else
                                p2 = new Point((int)pts[j + 1].X, (int)pts[j + 1].Y);

                            CvInvoke.Line(draw, p1, p2, new MCvScalar(255, 0, 255, 255), 3);
                        }
                    }
                }
            }
            return draw;
        }
        private static PointF Point2PointF(Point P)
        {
            PointF PF = new PointF
            {
                X = P.X,
                Y = P.Y
            };
            return PF;
        }
        public static List<Rectangle> BoundingBox(Image<Gray, byte> src, Image<Gray, byte> draw)
        {
            // 使用 VectorOfVectorOfPoint 類別一次取得多個輪廓。
            List<Rectangle> result = new List<Rectangle>();
            using (VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint())
            {
                CvInvoke.FindContours(src, contours, null, RetrType.External, ChainApproxMethod.ChainApproxSimple);

                int count = contours.Size;
                for (int i = 0; i < count; i++)
                {
                    using (VectorOfPoint contour = contours[i])
                    {
                        // 使用 BoundingRectangle 取得框選矩形
                        result.Add(CvInvoke.BoundingRectangle(contour));
                    }
                }
            }
            return result;
        }
        public static CircleF MaxCircle(Image<Gray, byte> src)
        {
            CircleF tempCircle = new CircleF();
            using (VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint())
            {
                CvInvoke.FindContours(src, contours, null, RetrType.External, ChainApproxMethod.ChainApproxNone);

                int count = contours.Size;
                int tempRadius = 0;
                Point tempPtr = new Point();
                for (int i = 0; i < count; i++)
                {
                    using (VectorOfPoint contour = contours[i])
                    {
                        CircleF circle = CvInvoke.MinEnclosingCircle(contour);
                        if (tempRadius < circle.Radius)
                        {
                            tempRadius = (int)circle.Radius;
                            tempPtr = new Point((int)circle.Center.X, (int)circle.Center.Y);
                            tempCircle = circle;
                        }
                    }
                }
            }
            return tempCircle;
        }

        public static void FindCenters(Image<Gray, byte> src, Image<Bgr, byte> dest)
        {
            VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
            CvInvoke.FindContours(src, contours, null, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxNone);
            int ksize = contours.Size;
            double[] m00 = new double[ksize];
            double[] m10 = new double[ksize];
            double[] m01 = new double[ksize];

            Point[] Gravity = new Point[ksize];
            Moments [] hu = new Moments[ksize];
            for (int i = 0; i < ksize; i++)
            {
                VectorOfPoint contour = contours[i];
                hu[i] = CvInvoke.Moments(contour, false);
                m00[i] = hu[i].M00;
                m10[i] = hu[i].M10;
                m01[i] = hu[i].M01;
                double X = m10[i] / m00[i]; //get center X
                double Y = m01[i] / m00[i]; //get center y
                Gravity[i] = new Point((int)X, (int)Y);
            }
            foreach (Point cent in Gravity)
            {
                CvInvoke.Circle(dest, cent, 2, new MCvScalar(255, 0, 0), 2);
            }
        }
        public static Image<Gray,byte>  DrawContour(Image<Gray, byte> src)
        {
            Image<Gray, byte> draw=src.Copy();
            using (VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint())
            {
                CvInvoke.FindContours(src, contours, null, RetrType.External, ChainApproxMethod.ChainApproxSimple);

                int count = contours.Size;
                for (int i = 0; i < count; i++)
                {
                    using (VectorOfPoint contour = contours[i])
                    using (VectorOfPoint approxContour = new VectorOfPoint())
                    {
                        // 原始輪廓線
                        //CvInvoke.DrawContours(draw, contours, i, new MCvScalar(255, 0, 255, 255), 1);

                        //近似後輪廓線
                        CvInvoke.ApproxPolyDP(contour, approxContour, CvInvoke.ArcLength(contour, true) * 0.01, true);
                        Point[] pts = approxContour.ToArray();
                        for (int j = 0; j < pts.Length; j++)
                        {
                            Point p1 = new Point(pts[j].X, pts[j].Y);
                            Point p2;
                            if (j == pts.Length - 1)
                                p2 = new Point(pts[0].X, pts[0].Y);
                            else
                                p2 = new Point(pts[j + 1].X, pts[j + 1].Y);

                            CvInvoke.Line(draw, p1, p2, new MCvScalar(255, 0, 0, 0), 1);
                        }
                    }
                }
            }
            return draw;
        }
        public static Image<Gray, byte> MinAreaCircle(Image<Gray, byte> src)
        {
            Image<Gray, byte> draw = src.Copy();
            using (VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint())
            {
                CvInvoke.FindContours(src, contours, null, RetrType.External, ChainApproxMethod.ChainApproxNone);

                int count = contours.Size;
                string tmp;

                for (int i = 0; i < count; i++)
                {
                    using (VectorOfPoint contour = contours[i])
                    {
                        CircleF circle = CvInvoke.MinEnclosingCircle(contour);
                        CvInvoke.Circle(draw, new Point((int)circle.Center.X, (int)circle.Center.Y), (int)circle.Radius, new MCvScalar(255, 0, 255, 255), 3);
                        tmp = Convert.ToString(i);
                        CvInvoke.PutText(draw, tmp, new Point((int)circle.Center.X, (int)circle.Center.Y), FontFace.HersheyDuplex, 2, new MCvScalar(0, 0, 0));
                    }
                }
            }
            return draw;
        }

    }
}
