using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAMVUE_Interfacek_hf
{
    class LogaritmikusKereso : GepiJatekos, IOkosTippelo
    {
        public override int KovetkezoTipp()
        {
            int szam = (alsoHatar + felsoHatar) / 2;
            Console.WriteLine("Interfesz.LogaritmikusKereso tippje: {0}",szam);
            return szam;
        }
        public void Kisebb()
        {
            felsoHatar = ((felsoHatar + alsoHatar) / 2) - 1;
        }
        public void Nagyobb()
        {
            alsoHatar = ((felsoHatar + alsoHatar) / 2) + 1;
        }
    }
}
