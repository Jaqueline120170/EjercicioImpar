using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioImpar.Servicios
{
    class MenuImplementacion : MenuInterfaz
    {
        public int solicitarExpresion()
        {
            int numero;
            Console.WriteLine("Introduzca un número");
            numero = Convert.ToInt32(Console.ReadLine());
            return numero;
        }
    }
}  