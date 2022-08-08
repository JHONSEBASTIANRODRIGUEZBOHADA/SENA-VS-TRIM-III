using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorNumeroRomano
{
    internal class Informacion
    {
        int option;
        int n;
        int u;
        int d;
        int c;

        public Informacion() { }

        public int Option { get => option; set => option = value; }
        public int N { get => n; set => n = value; }
        public int U { get => u; set => u = value; }
        public int D { get => d; set => d = value; }
        public int C { get => c; set => c = value; }
    }
}
