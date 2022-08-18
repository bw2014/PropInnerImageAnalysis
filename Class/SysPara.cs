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
        public List<feedRate> PrevFRates { get; set; }
        public List<feedRate> FactFRates { get; set; }
        public List<feedContact> FactContacts { get; set; }
    }


    public class ROI
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }
    public class feedRate
    {
        public feedRate(string tc,int fr01,int fr02,int fr03,int fc01,int fc02,int fc03)
        {
            typeCode = tc;
            feedrate01 = fr01;
            feedrate02 = fr02;
            feedrate03 = fr03;
            feedcount01 = fc01;
            feedcount02 = fc02;
            feedcount03 = fc03;
        }
        public string typeCode { get; set; }
        public int feedrate01 { get; set; }
        public int feedrate02 { get; set; }
        public int feedrate03 { get; set; }
        public int feedcount01 { get; set; }
        public int feedcount02 { get; set; }
        public int feedcount03 { get; set; }
    }
    public class feedContact
    {
        public feedContact(string tc, int frc01, int frc02, int frc03,int fcc01,int fcc02,int fcc03)
        {
            typeCode = tc;
            feedrcontact01 = frc01;
            feedrcontact02 = frc02;
            feedrcontact03 = frc03;
            feedccontact01 = fcc01;
            feedccontact02 = fcc02;
            feedccontact03 = fcc03;

        }
        public string typeCode { get; set; }
        public int feedrcontact01 { get; set; }
        public int feedrcontact02 { get; set; }
        public int feedrcontact03 { get; set; }
        public int feedccontact01 { get; set; }
        public int feedccontact02 { get; set; }
        public int feedccontact03 { get; set; }
    }
}
