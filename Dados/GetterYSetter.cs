using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    internal class GetterYSetter
    {
        int Dado1;
        int Dado2;
        int Dado3;

        public GetterYSetter() { }

        public int Dado11 { get => Dado1; set => Dado1 = value; }
        public int Dado21 { get => Dado2; set => Dado2 = value; }
        public int Dado31 { get => Dado3; set => Dado3 = value; }
    }
}
