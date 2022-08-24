using Basler.Pylon;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.Windows.Forms;

namespace PropInnerImageAnalysis
{
    class BaslerCamera
    {
        public int CameraNumber = CameraFinder.Enumerate().Count;
        public delegate void CameraImage(Bitmap bmp);
        public event CameraImage CameraImageEvent;
        Camera camera;
        PixelDataConverter pxConvert = new PixelDataConverter();
        bool GrabOver = false;
        private Stopwatch stopWatch=new Stopwatch();
        public bool isOpened = false;



        private static EnumName regionSelector;
        private static BooleanName autoFunctionAOIROIUseWhiteBalance, autoFunctionAOIROIUseBrightness;
        private static IntegerName regionSelectorWidth, regionSelectorHeight, regionSelectorOffsetX, regionSelectorOffsetY;
        private static String regionSelectorValue1, regionSelectorValue2;
        private static FloatName balanceRatio, exposureTime;


        public void CameraInit(ICameraInfo cameraInfo,string configFN)
        {
            camera = new Camera(cameraInfo);

            camera.CameraOpened += Configuration.AcquireContinuous;
            camera.Open();

            camera.Parameters[PLStream.MaxNumBuffer].SetValue(15);
            camera.Parameters.Load(configFN, ParameterPath.CameraDevice);

            camera.CameraOpened += Camera_OnOpened;
            camera.CameraClosed += Camera_OnClosed;
            camera.ConnectionLost += Camera_ConnectionLost;
            camera.StreamGrabber.GrabStarted += StreamGrabber_GrabStarted;
            camera.StreamGrabber.ImageGrabbed += StreamGrabber_ImageGrabbed;
            camera.StreamGrabber.GrabStopped += StreamGrabber_GrabStopped;

            //camera.Open();
            //camera.Parameters.Load(configFN, ParameterPath.CameraDevice);



        }
        public void CamOpen()
        {
            camera.Open();
        }

        public void Configure()
        {
            regionSelector = PLCamera.AutoFunctionROISelector;
            regionSelectorOffsetX = PLCamera.AutoFunctionROIOffsetX;
            regionSelectorOffsetY = PLCamera.AutoFunctionROIOffsetY;
            regionSelectorWidth = PLCamera.AutoFunctionROIWidth;
            regionSelectorHeight = PLCamera.AutoFunctionROIHeight;
            regionSelectorValue1 = PLCamera.AutoFunctionROISelector.ROI1;
            regionSelectorValue2 = PLCamera.AutoFunctionROISelector.ROI2;
            autoFunctionAOIROIUseBrightness = PLCamera.AutoFunctionROIUseBrightness;
            autoFunctionAOIROIUseWhiteBalance = PLCamera.AutoFunctionROIUseWhiteBalance;
            balanceRatio = PLCamera.BalanceRatioAbs;
            exposureTime = PLCamera.ExposureTimeAbs;
        }
        private void Camera_ConnectionLost(Object sender, EventArgs e)
        {
            //DestroyCamera();
            // Because one device is gone, the list needs to be updated.
            // UpdateDeviceList();
        }

        private void Camera_OnOpened(Object sender, EventArgs e)
        {
            //DestroyCamera();
            // Because one device is gone, the list needs to be updated.
            // UpdateDeviceList();
        }
        private void Camera_OnClosed(Object sender, EventArgs e)
        {
            //DestroyCamera();
            // Because one device is gone, the list needs to be updated.
            // UpdateDeviceList();
        }

        // Occurs when the connection to a camera device is opened.
        private void StreamGrabber_GrabStarted(Object sender, EventArgs e)
        {
            GrabOver = true;
            stopWatch.Reset();

        }
        private void StreamGrabber_ImageGrabbed(object sender, ImageGrabbedEventArgs e)
        {
            try
            {
                IGrabResult grabResult = e.GrabResult;
                if (grabResult.IsValid)
                {
                    if (!stopWatch.IsRunning || stopWatch.ElapsedMilliseconds > 33)
                    {
                        stopWatch.Restart();
                        if ((GrabOver) && (CameraImageEvent!=null))
                            CameraImageEvent(GrabResult2Bmp(grabResult));
                        GC.Collect();
                    }
                }
            }
            catch (Exception exp)
            {
                //ShowException(exp);
            }
            finally
            {
                e.DisposeGrabResultIfClone();
            }

        }
        public void DestroyCamera()
        {
            try
            {
                if (camera != null)
                {
                    camera.Close();
                    camera.Dispose();
                    camera = null;
                }
            }
            catch (Exception exception)
            {
                ShowException(exception);
            }
        }

        private void ShowException(Exception exception)
        {
            MessageBox.Show("Exception caught:\n" + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void StreamGrabber_GrabStopped(object sender, GrabStopEventArgs e)
        {
            GrabOver = false;
            stopWatch.Reset();
        }

        public void OneShot()
        {
            if (camera != null)
            {
                camera.Parameters[PLCamera.AcquisitionMode].SetValue(PLCamera.AcquisitionMode.SingleFrame);
                camera.StreamGrabber.Start(1, GrabStrategy.OneByOne, GrabLoop.ProvidedByStreamGrabber);
            }
        }

        public void KeepShot()
        {
            if (camera != null)
            {
                camera.Parameters[PLCamera.AcquisitionMode].SetValue(PLCamera.AcquisitionMode.Continuous);

                camera.StreamGrabber.Start(GrabStrategy.OneByOne, GrabLoop.ProvidedByStreamGrabber);
                //camera.StreamGrabber.Start();
            }
        }

        public void Stop()
        {
            if (camera != null)
            {
                camera.StreamGrabber.Stop();
            }
        }

        Bitmap GrabResult2Bmp(IGrabResult grabResult)
        {
            Bitmap b = new Bitmap(grabResult.Width, grabResult.Height, PixelFormat.Format32bppRgb);
            BitmapData bmpData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height), ImageLockMode.ReadWrite, b.PixelFormat);
            //BitmapData bmpData = b.LockBits(new Rectangle(240, 100, 800, 800), ImageLockMode.ReadWrite, b.PixelFormat);
            pxConvert.OutputPixelFormat = PixelType.BGRA8packed;
            IntPtr bmpIntpr = bmpData.Scan0;
            pxConvert.Convert(bmpIntpr, bmpData.Stride * b.Height, grabResult);
            //pxConvert.Convert(bmpIntpr, bmpData.Stride * 800, grabResult);
            b.UnlockBits(bmpData);
            return b;
        }
        public void setGain(int percent)
        {
            camera.Parameters[PLUsbCamera.Gain].SetValuePercentOfRange(percent);
        }

        public void setExpo(int percent)
        {
            camera.Parameters[PLUsbCamera.ExposureTime].SetValuePercentOfRange(percent);
        }
        private void AutoAdjustment()
        {
            //camera.Open();
            Configure();

            // Set the pixel format to one from a list of ones compatible with this example
            string[] pixelFormats = new string[]
            {
                        PLCamera.PixelFormat.YUV422_YUYV_Packed,
                        PLCamera.PixelFormat.YCbCr422_8,
                        PLCamera.PixelFormat.BayerBG8,
                        PLCamera.PixelFormat.BayerRG8,
                        PLCamera.PixelFormat.BayerGR8,
                        PLCamera.PixelFormat.BayerGB8,
                        PLCamera.PixelFormat.Mono8
            };

            camera.Parameters[PLCamera.PixelFormat].SetValue(pixelFormats);

            // Disable test image generator if available
            camera.Parameters[PLCamera.TestImageSelector].TrySetValue(PLCamera.TestImageSelector.Off);
            camera.Parameters[PLCamera.TestPattern].TrySetValue(PLCamera.TestPattern.Off);

            if (camera.Parameters[regionSelector].IsWritable)
            {
                camera.Parameters[regionSelector].SetValue(regionSelectorValue1);
                camera.Parameters[autoFunctionAOIROIUseBrightness].SetValue(true);// ROI 1 is used for brightness control
                camera.Parameters[autoFunctionAOIROIUseWhiteBalance].SetValue(true);// ROI 1 is used for white balance control
            }
            camera.Parameters[regionSelector].SetValue(regionSelectorValue1);
            camera.Parameters[regionSelectorOffsetX].SetValue(camera.Parameters[PLCamera.OffsetX].GetMinimum());
            camera.Parameters[regionSelectorOffsetY].SetValue(camera.Parameters[PLCamera.OffsetY].GetMinimum());
            camera.Parameters[regionSelectorWidth].SetValue(camera.Parameters[PLCamera.Width].GetMaximum());
            camera.Parameters[regionSelectorHeight].SetValue(camera.Parameters[PLCamera.Height].GetMaximum());

            camera.Parameters[PLCamera.ProcessedRawEnable].TrySetValue(true);
            camera.Parameters[PLCamera.GammaEnable].TrySetValue(true);
            camera.Parameters[PLCamera.GammaSelector].TrySetValue(PLCamera.GammaSelector.sRGB);
            camera.Parameters[PLCamera.AutoTargetValue].TrySetValue(80);
            camera.Parameters[PLCamera.AutoFunctionProfile].TrySetValue(PLCamera.AutoFunctionProfile.GainMinimum);
            camera.Parameters[PLCamera.AutoGainRawLowerLimit].TrySetToMinimum();
            camera.Parameters[PLCamera.AutoGainRawUpperLimit].TrySetToMaximum();
            camera.Parameters[PLCamera.AutoExposureTimeAbsLowerLimit].TrySetToMinimum();
            camera.Parameters[PLCamera.AutoExposureTimeAbsUpperLimit].TrySetToMaximum();

            // Set all auto functions to once in this example
            camera.Parameters[PLCamera.GainSelector].TrySetValue(PLCamera.GainSelector.All);

            camera.Parameters[PLCamera.GainAuto].TrySetValue(PLCamera.GainAuto.Off);
            camera.Parameters[PLUsbCamera.Gain].SetValuePercentOfRange(50);

            camera.Parameters[PLCamera.ExposureAuto].TrySetValue(PLCamera.ExposureAuto.Off);
            camera.Parameters[PLUsbCamera.ExposureTime].SetValuePercentOfRange(50);

            camera.Parameters[PLCamera.BalanceWhiteAuto].TrySetValue(PLCamera.BalanceWhiteAuto.Once);

            camera.Parameters[PLCamera.LightSourcePreset].TrySetValue(PLCamera.LightSourcePreset.Daylight5000K);
        }
    }
}
