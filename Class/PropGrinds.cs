using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropImages;

namespace PropInnerImageAnalysis
{
    class PropGrinds
    {
        private List<SingleHoleGrain> _OHGC = new List<SingleHoleGrain>();
        private List<SingleHoleGrain> _OHGN = new List<SingleHoleGrain>();
        private List<Powder> _PWDC = new List<Powder>();
        private List<Powder> _PWDN = new List<Powder>();
        public PropGrinds(SingleHoleGrain shg, bool isCoated)
        {
            if(isCoated)
                _OHGC.Add(shg);
            else
                _OHGN.Add(shg);
        }
        public PropGrinds(Powder powder)
        {
            _PWDC.Add(powder);
        }
        public void AddSample(Powder powder)
        {
            _PWDC.Add(powder);
        }
        public void AddSample(SingleHoleGrain shg, bool isCoated)
        {
            if (isCoated)
                _OHGC.Add(shg);
            else
                _OHGN.Add(shg);
        }
        public void ClearList(string type)
        {
            if (type == "OHGC") _OHGC.Clear();
            if (type == "OHGN") _OHGC.Clear();
            if (type == "PWDC") _PWDC.Clear();
            if (type == "PWDN") _PWDN.Clear();
        }
        public List<SingleHoleGrain> getOHGCList()
        {
            return _OHGC;
        }
        public List<SingleHoleGrain> getOHGNList()
        {
            return _OHGN;
        }
        public List<Powder> getPWDCList()
        {
            return _PWDC;
        }
        public List<Powder> getPWDNList()
        {
            return _PWDN;
        }


    }
}
