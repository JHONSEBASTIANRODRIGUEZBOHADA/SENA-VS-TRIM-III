using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorNumeroRomano
{
    internal class PrincipalMain : Informacion
    {
        public static void Main(string[] args)
        {
            Informacion datos = new Informacion();
            do
            {
                try
                {
                    


                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex);
                }
            } while (datos.Option == 0);
        }
    }
}

/*
UNIDADES
1 -> I
2 -> II
3 -> III
4 -> IV
5 -> V
6 -> VI
7 -> VII
8 -> VIIII
9 -> IX
10 -> X

DECENAS
10 -> X
20 -> XX
30 -> XXX
40 -> XL
50 -> L
60 -> LX
70 -> LXX
80 -> LXXX
90 -> XC

CENTENAS
 -> C
 -> CC
 -> CCC
 -> CD
 -> D
 -> DC
 -> DCC
 -> DCCC
 -> CM
*/