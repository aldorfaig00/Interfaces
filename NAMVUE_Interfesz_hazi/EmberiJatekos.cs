using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAMVUE_Interfacek_hf
{
    class EmberiJatekos : IOkosTippelo
    {
        public void JatekIndul(int alsoHatar, int felsoHatar)
        {
            Console.WriteLine("*Jatek indul az alábbi határok között: [{0},{1}]", alsoHatar, felsoHatar);
        }
        public void Kisebb()
        {
            Console.WriteLine("*Az előző tippnél kisebb a keresett szám");
        }
        public void Nagyobb()
        {
            Console.WriteLine("*Az előző tippnél nagyobb31 a keresett szám");
        }
        public int KovetkezoTipp()
        {
            Console.WriteLine("*Add meg a következő tippet");
            int szam = int.Parse(Console.ReadLine());
            Console.WriteLine("Interfesz.EmberiJatekos tippje: " + szam);
            return szam;
        }
        public void Nyert()
        {
            Console.WriteLine("*Nyertél");
        }
        public void Veszitett()
        {
            Console.WriteLine("*Vesztettél");
        }
    }
}
