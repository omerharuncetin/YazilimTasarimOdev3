using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAdaptationProblem
{
    class Adaptor : IDusman
    {
        private IDusmanRobotu dusmanRobotuReferansı;
        public Adaptor(string hangiCihaz)
        {
            if (hangiCihaz.Equals("DusmanRobotu"))
                dusmanRobotuReferansı = new DusmanRobotu();
            
        }

        public void SilahKullan(string kim)
        {
            dusmanRobotuReferansı.YumrukAt();
        }

        public void Hizlan(string kim)
        {
            dusmanRobotuReferansı.Yuru();
        }

        public string DusmanAdi(string kim)
        {
            return dusmanRobotuReferansı.RobotIsim();
        }
    }
}
