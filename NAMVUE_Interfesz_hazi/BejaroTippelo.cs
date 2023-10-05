using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAMVUE_Interfacek_hf
{
    class BejaroTippelo : GepiJatekos
    {
        int aktualis = 0;
        public override void JatekIndul(int alsoHatar, int felsoHatar)
        {
            base.JatekIndul(alsoHatar, felsoHatar);
            aktualis = alsoHatar;
        }
        public override int KovetkezoTipp()
        {
            Console.WriteLine("Interfesz.BejaroTippelo tippje:" + aktualis);
            return aktualis += 1;

        }
    }
}
