using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAMVUE_Interfacek_hf
{
	public class RandomSzam
	{
		private static Random rnd = new Random();
		int szam1;
		public int veletlenSzam(int alsoHatar,int felsoHatar)
		{ 
			szam1 = rnd.Next(alsoHatar,felsoHatar);
			return szam1;
		}
	}
}
