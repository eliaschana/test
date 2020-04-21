using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abecedario
{
    class Program
    {

        static void LeerAbecedario(char letra, int num)
        {
            string abc = null;
            while (letra <= 'z')
            {
                if (letra % 2 != 0 && num == 1)
                {
                    abc = abc + " " + letra;
                }
                else if (letra % 2 == 0 && num == 2)
                {
                    abc = abc + " " + letra;
                }
                letra++;
            }

            Console.WriteLine(abc);
        }


        static void Main(string[] args)
        {
            char letra = 'a';
            Task t1 = Task.Factory.StartNew(() => LeerAbecedario(letra, 1));
            Task t2 = Task.Factory.StartNew(() => LeerAbecedario(letra, 2));

            Task.WaitAll(t1, t2);
            Console.WriteLine("Presione enter para finalizar");
            Console.ReadLine();

        }
    }
}
