using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAMVUE_Interfacek_hf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SzamKitalaloJatekKaszino kaszino = new SzamKitalaloJatekKaszino(1, 100, 6);
            
            ITippelo veletlenSzam = new VeletlenTippelo();
            ITippelo bejaro = new BejaroTippelo();
            ITippelo logaritmikus = new LogaritmikusKereso();
            ITippelo jatekos = new EmberiJatekos();

			//kaszino.VersenyzoFelvetele(jatekos);  //Komment kivételével tesztelhető az EmberiJátékos is
			kaszino.VersenyzoFelvetele(veletlenSzam);
            kaszino.VersenyzoFelvetele(bejaro);
            kaszino.VersenyzoFelvetele(logaritmikus);
			
			kaszino.Statisztika(1000);

            Console.ReadKey();
        }
    }
}
