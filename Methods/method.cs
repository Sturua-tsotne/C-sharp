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
            Program p = new Program(); //ვქმნით Program კლასის ობიექტს p
            p.EvenNamber(); //ვიძახებთ მეთოდს 

            //მაგალითი 2
            Program.EvenNamber2();//როცა მეთოდი static არ არის საჭირო ონიექტის შექმნა

            //მაგალითი 3
            Program.EvenNamber(30); //მეთოდს ვაწვდი პარამეტრს

            //მაგალითი 4
            int sum = p.Add(20, 30); //მეტოდს გადაეცემა ორი მნიშვნელობა
            Console.WriteLine("sum ={0}",sum);// ვბეჭდავთ დაბრუნებულ მნიშვნელობას
        }
        public void EvenNamber() //ფუნქცია რომელიც არაფერს აბრუნებს void დაბრუნების ტიპი არა აბრუნებს 
        {
            int i = 0;
            while (i <= 20)
            {
                Console.WriteLine(i);
                i += 2;
            }

        }
        //მაგალითი 2
        public static void EvenNamber2()
        {
            int i = 0;
            while (i <= 20)
            {
                Console.WriteLine(i);
                i += 2;
            }

        }
        //მაგალითი 3
        public static void EvenNamber(int namber) // მეთოდმა შეიძლება მიიღოს  პარამეტრი
        {
            int i = 0;
            while (i <= namber)
            {
                Console.WriteLine(i);
                i += 2;
            }

        }
        //მაგალითი 4
        public int Add(int a, int b)// მეთოდი აბრუნებს int -ს და იღებს პარამეტრად 2 მნიშვნე;ობას
        {
            return a + b;
        }

    }
}
