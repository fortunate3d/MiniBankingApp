﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{
    public class OversabiStudent : IOversabiStudent
    {
        public bool SLT { get ; set ; }
        public bool BIO { get ; set ; }
        public bool ENG { get ; set ; }
        public bool MEE { get ; set ; }
        public bool Maths { get;  set ; }
        public bool Chemistry { get ; set ; }
        public bool Physics { get ; set ; }
        public bool GNS { get ; set ; }
        public bool ENS { get ; set ; }
    }
}
