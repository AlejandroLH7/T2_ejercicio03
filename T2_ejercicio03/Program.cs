using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2_ejercicio03.interfaces;

namespace T2_ejercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = InterfazConsola.menuPrincipal();
            do
            {
                switch (opcion)
                {
                    case 0:
                        opcion = InterfazConsola.menuPrincipal();
                        break;
                    case 1:
                        opcion = InterfazConsola.sumar();
                        break;
                    case 2:
                        opcion = InterfazConsola.restar();
                        break;
                    case 3:
                        opcion = InterfazConsola.multiplicar();
                        break;
                    case 4:
                        opcion = InterfazConsola.dividir();
                        break;
                }
            } while (opcion != 5);
        }
    }
}
