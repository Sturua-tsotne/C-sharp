using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Program.Mrthod(ref i);//ref  გამოყენების დროს i და J ხდებიან ერთიდაიმავე და მოხდება გადაეწერა
            Console.WriteLine(i);

            Console.ReadKey();

        }
        public static void Mrthod(ref int j)//
        {

            j = 102;
        }

    }
}
// მაგალითი 2 
public class Program
{
    static void Main(string[] args)
    {
        int total = 0;
        int product = 0;
        Method(20, 30, out total, out product);
        Console.WriteLine("Sum ={0} && product={1}", total, product); //აქ ულვე მოდის გადაწერილი მნიშვნელობა
    }
    public static void Method(int a, int b, out int sum, out int product)  //გადმოეცემა პარამეტრი რომელშიც ვინახავთ პირველი ორი პარამეტრის ჯამს ....
    {
        // იგივეა რაც დაგვებრუნებინა და ფუნქცია არ ყოფილიყო ვოიდი
        sum = a + b;
        product = a * b;
    }

}
//მაგალითი 3
  static void Main(string[] args)
        {
            int[] numbers = new int[3];
            numbers[0] = 101;
            numbers[1] = 102;
            numbers[2] = 103;

//შეგვიძლია გადავცეთ არარი
            //ParamsMethod(numbers); 
            ParamsMethod(1,2,3,4); //შეგვიძლია პირდაპპირ მივაწოდოთ რიცხვითი მნიშვნელობები


        }
        public static void ParamsMethod(params int[] Numbers)//params გამოყენებით შესაძლებელია ცარიელი მნიშვნელობის გადაცემაც ასევე სხვადასხვა სახიტ მნიშვნელობები
        {
            Console.WriteLine(" There are {0} elemrnts", Numbers.Length);
            foreach (var item in Numbers)
            {
                Console.WriteLine(item);
            }

        }