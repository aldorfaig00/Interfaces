using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAMVUE_Interfacek_hf
{
    class SzamKitalaloJatekKaszino : SzamKitalaloJatek, IStatisztikatSzolgaltat
    {
        int kaszinoNyert;
        int kaszinoVeszitett;
        int korokSzama;
        public SzamKitalaloJatekKaszino(int alsoHatar, int felsoHatar, int korokSzama) : base(alsoHatar, felsoHatar)
        {
            this.korokSzama = korokSzama;
        }
        public int HanyszorNyert
        {
            get
            { return kaszinoNyert; }
        }
        public int HanyszorVeszitett
        {
            get { return kaszinoVeszitett; }
        }
        public override void Jatek()
        {
            VersenyIndul();
            int talalt = 0;
            while ((korokSzama > talalt) && MindenkiTippel() != true)
            {
                talalt++;
            }
            if (korokSzama > talalt)
            {
                kaszinoVeszitett++;
            }
            else
            {
                kaszinoNyert++;
            }
        }
        public override void Statisztika(int korokszama)
        {
            base.Statisztika(korokszama);
            Console.WriteLine($"Kaszino, NY: {kaszinoNyert} V: {kaszinoVeszitett}");
        }
    }
}
