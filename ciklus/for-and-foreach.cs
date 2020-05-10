using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nambers = new int[3]; //არაი 
            nambers[0] = 101;
            nambers[1] = 102;
            nambers[2] = 103;


            foreach (var item in nambers)
            {
                Console.WriteLine(item); //item იღებს ყველა იმ ნიშვნელობას რომელიც nambers არაიშია
            }

            for (int i = 0; i < nambers.Length; i++) //for ტრიალებს nambers არაის სიგრძემდე 
            {
                Console.WriteLine(nambers[i]);
            }

            for (int a = 0; a < 20; a++)
            {
                Console.Write(a + " ");
                if (a == 10)
                    break;//აჩერებს ციკლს

            }

            for (int j = 0; j < 20; j++)
            {
                Console.Write(j + " ");
                if (j == 10)
                    continue; //განაგრძობს

            }
            Console.ReadKey();
        }
    }
}
