﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAMVUE_Interfacek_hf
{
    interface ITippelo : IJatekos
    {
        void JatekIndul(int alsoHatar, int felsoHatar);
        int KovetkezoTipp();
        
    }
}