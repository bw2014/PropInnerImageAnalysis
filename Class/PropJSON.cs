using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropInnerImageAnalysis
{
    public class PropJSON
    {
        public string PropType { get; set; }
        public string Timestamp { get; set; }
        public int Opermode { get; set; }
        public float FaceUnit { get; set; }
        public float SideUnit { get; set; }
        public string defUnit { get; set; }

        public List<PImage> PImages { get; set; }
    }

    public class SimpleC
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Radius { get; set; }
    }

    public class PImage
    {
        public List<SimpleC> BigC { get; set; }
        public List<List<SimpleC>> SmallC { get; set; }
        public List<List<float>> Length { get; set; }
        public List<string> SrcImage { get; set; } 
        public List<List<string>> SideSrcImage { get; set; }
        public List<float> BigDiameter { get; set; }
        public List<float> SmallDiamterAvg { get; set; }
        public List<float> DOverd { get; set; }
        public List<float> LenOverD { get; set; }
        public List<float> WiAvg { get; set; }
        public List<float> WoAvg { get; set; }
        public List<List<float>> SmallDiamter { get; set; }
        public List<List<float>> Wi { get; set; }
        public List<List<float>> Wo { get; set; }
        public List<List<List<int>>> HLineY { get; set; }
        public List<float> LengthAvg { get; set; }
        public float FaceUnit { get; set; }
        public float SideUnit { get; set; }
        public string defUnit { get; set; }


    }

}
