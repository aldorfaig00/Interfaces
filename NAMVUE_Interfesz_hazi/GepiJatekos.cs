using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAMVUE_Interfacek_hf
{
    abstract class GepiJatekos : ITippelo, IStatisztikatSzolgaltat
    {
        protected int alsoHatar;
        protected int felsoHatar;
        int nyertDB;
        int veszitettDB;

        public virtual void JatekIndul(int alsoHatar, int felsoHatar)
        {
            this.alsoHatar = alsoHatar;
            this.felsoHatar = felsoHatar;
        }
        abstract public int KovetkezoTipp();
        public void Nyert()
        {
            nyertDB++;
        }
        public void Veszitett()
        {
            veszitettDB++;
        }
        public int HanyszorNyert
        {
            get
            {
                return nyertDB;
            }
        }
        public int HanyszorVeszitett
        {
            get
            {
                return veszitettDB;
            }
        }
    }
}
