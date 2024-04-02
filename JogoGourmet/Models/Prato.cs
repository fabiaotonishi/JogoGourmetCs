using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoGourmet.Models
{
    internal class Prato
    {
        public int Ix { get; set; }
        public string Nome { get; set; }
        public bool Massa { get; set; }

        public Prato()
        {            
            Massa = false;
        }
    }
}
