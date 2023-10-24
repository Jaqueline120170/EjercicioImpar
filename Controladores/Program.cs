using EjercicioImpar.Servicios;

namespace EjercicioImpar.Controladores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            numero = mi.solicitarExpresion();
            MenuInterfaz mi = new MenuImplementacion();

            if (numero % 2 == 0)
            {
                Console.WriteLine("El número introducido es par");
            }
            else Console.WriteLine("El número introducido es impar");
                
            
        }
    }
}