﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    [Serializable]  // Atribute 
    class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
    }
}
