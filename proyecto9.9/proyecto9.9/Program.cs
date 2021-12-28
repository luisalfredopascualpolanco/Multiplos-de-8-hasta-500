using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto9._9
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int numero = 8;
                while (numero<=500)
                {
                    if (numero == 496)
                    {
                        Console.Write(" "+numero);
                    }
                    else
                    {
                        Console.Write(" " + numero + " -");                       
                    }
                    numero = numero + 8;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ha introducido un dato invalido");
                throw;
            }
            Console.ReadKey();
        }
    }
}
