 using System;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Especificando DataSouce

            int[] numbers = new int[] { 2, 3, 4, 5 };

            //Definir a consulta

            var result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            //Executar a consulta

            foreach (int x in result)
            {
                Console.WriteLine(x);
            }

        }
    }
}
