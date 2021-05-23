using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAdaptationProblem
{
    class DusmanTank : IDusman
    {
        public void SilahKullan(string kim)
        {
            Console.WriteLine(kim + " silah kullandi.");
        }

        public void Hizlan(string kim)
        {
            Console.WriteLine(kim + " hizlandi.");
        }

        public string DusmanAdi(string kim)
        {
            return "Adı : " + kim;
        }
    }
}
