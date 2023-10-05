using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NAMVUE_Interfacek_hf
{
   
    class VeletlenTippelo : GepiJatekos
	{
		
		public override int KovetkezoTipp()
        {
            RandomSzam random = new RandomSzam();
            int also = alsoHatar;
            int felso = felsoHatar;
            int szam = random.veletlenSzam(also, felso);
            Console.WriteLine("Interfesz.VeletlenTippelo tippje: " + szam);
            return szam;
        }
    }
}
