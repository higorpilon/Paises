﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paises.Modelos
{
   public class Regionalbloc
    {
        
            public string Acronym { get; set; }
            public string Name { get; set; }
            public List<string> OtherAcronyms { get; set; }
            public List<string> OtherNames { get; set; }
        
    }
}
