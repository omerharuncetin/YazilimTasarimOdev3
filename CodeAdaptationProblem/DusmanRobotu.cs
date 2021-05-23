using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAdaptationProblem
{
    class DusmanRobotu : IDusmanRobotu
    {
        public void YumrukAt()
        {
            Console.WriteLine("Dusman robotu yumruk attı.");
        }

        public void Yuru()
        {
            Console.WriteLine("Dusman robotu yurudu.");
        }

        public string RobotIsim()
        {
            return "Robotun adı.";
        }
    }
}
