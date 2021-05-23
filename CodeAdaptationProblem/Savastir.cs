using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAdaptationProblem
{
    class Savastir : IDusman
    {
        private DusmanTank dusmanTank;
        private Adaptor adaptor;
        public void SilahKullan(string kim)
        {
            if (kim.Equals("Tank"))
            {
                dusmanTank = new DusmanTank();
                dusmanTank.SilahKullan(kim);
            }
            else if (kim.Equals("DusmanRobotu"))
            {
                adaptor = new Adaptor("DusmanRobotu");
                adaptor.SilahKullan("DusmanRobotu");
            }
           
        }

        public void Hizlan(string kim)
        {
            if (kim.Equals("Tank"))
            {
                dusmanTank = new DusmanTank();
                dusmanTank.Hizlan(kim);
            }
            else if (kim.Equals("DusmanRobotu"))
            {
                adaptor = new Adaptor("DusmanRobotu");
                adaptor.Hizlan("DusmanRobotu");
            }
        }

        public string DusmanAdi(string kim)
        {
            if (kim.Equals("Tank"))
            {
                dusmanTank = new DusmanTank();
                return dusmanTank.DusmanAdi(kim); 
            }
            else if (kim.Equals("DusmanRobotu"))
            {
                adaptor = new Adaptor("DusmanRobotu");
                return adaptor.DusmanAdi("DusmanRobotu");
            }

            return "";
        }

    }
}
