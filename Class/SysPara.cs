using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PropInnerImageAnalysis
{
    public class SysConfig
    {
        public float pixLength { get; set; }
        public int fixedThres { get; set; }
        public ROI mROI { get; set; }
        public string workiDir { get; set; }
        public string cam { get; set; }
        public string camConfig { get; set; }
        public string defUnit { get; set; }
        public string paraFile { get; set; }
    }


    public class ROI
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }
}
