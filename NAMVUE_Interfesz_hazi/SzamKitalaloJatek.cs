using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NAMVUE_Interfacek_hf
{
    class SzamKitalaloJatek
    {
        const int MAX_VERSENYZO = 5;
        ITippelo[] versenyzok = new ITippelo[MAX_VERSENYZO];
        int versenyzoN;
        int alsoHatar;
        int felsoHatar;
        protected int cel;
        public void AktualisVersenyzo()
        {
            for (int i = 0; i < versenyzok.Length; i++)
            {
               versenyzoN++;
            }
        }
        public void VersenyzoFelvetele(ITippelo versenyzo)
        {
            int szabadVersenyzoHely = SzabadVersenyzoHely();
            if (szabadVersenyzoHely != -1)
            {
                this.versenyzok[szabadVersenyzoHely] = versenyzo;
                versenyzoN++;
            }        
            //versenyzok[versenyzoN] = versenyzo;
            //versenyzoN++;
        }
        private int SzabadVersenyzoHely()
        {
            for (int i = 0; i < versenyzok.Length; i++)
            {
                if (versenyzok[i] == null)
                {
                    return i;
                }
            }
            return -1;
        }

            public SzamKitalaloJatek(int alsoHatar, int felsoHatar)
        {
            this.alsoHatar = alsoHatar;
            this.felsoHatar = felsoHatar;
        }
        protected void VersenyIndul()
        {
			
			RandomSzam random = new RandomSzam();
            Console.WriteLine("\n\rVersenyIndul");
            for (int i = 0; i < 1; i++)
            {
				cel = random.veletlenSzam(alsoHatar, felsoHatar);
			}
            Console.WriteLine("Cel: " + cel);
            for (int i = 0; i < versenyzoN; i++)
            {
                versenyzok[i].JatekIndul(alsoHatar, felsoHatar);
            }
        }
        protected bool MindenkiTippel()
        {
            bool nyert = false;
            int[] seged = new int[versenyzoN];
			
			Console.WriteLine("\n\rMindenkiTippel");
            for (int i = 0; i < versenyzoN; i++)
            {
                int tippek = versenyzok[i].KovetkezoTipp();
                if (cel == tippek)
                {
                    versenyzok[i].Nyert();
                    nyert = true;
                    seged[i] = -1;
                }
                else
                {
                    seged[i] = tippek;
                    if (versenyzok[i] is IOkosTippelo)
                    {
                        if (seged[i] < cel)
                        {
                            (versenyzok[i] as IOkosTippelo).Nagyobb();
                        }
                        else
                        {
                            (versenyzok[i] as IOkosTippelo).Kisebb();
                        }
                    }
                }
            }
            if (nyert == true)
            {
                for (int i = 0; i < versenyzoN; i++)
                {
                    if (seged[i] != -1)
                    {
                        versenyzok[i].Veszitett();
                    }
                }
            }
            return nyert;
        }
        public virtual void Jatek()
        {
            VersenyIndul();
            while (MindenkiTippel() != true) { }
        }
        public virtual void Statisztika(int korokszama)
        {

            for (int i = 0; i < korokszama; i++)
            {
                Jatek();
            }
            for (int i = 0; i < versenyzoN; i++)
            {
                if (versenyzok[i] is IStatisztikatSzolgaltat)
                {
                    Console.WriteLine($"{i}. jatekos ({versenyzok[i]}), NY: {(versenyzok[i] as IStatisztikatSzolgaltat).HanyszorNyert} V: {(versenyzok[i] as IStatisztikatSzolgaltat).HanyszorVeszitett}");
                }
            }
        }
    }
}
