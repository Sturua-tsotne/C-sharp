using System;

namespace ConsoleApp2
{
    class Customer
    {
        string _FirstName;//შევქმენი ცვლადი
        string _Lastname;

        public Customer(string FirstName ,string Lastname) //კონსტრუქტორში გადაეცემა ორი მნიშვნელობა კონსტრუქტორს უნდა ქონდეს იგივე სახელი რაც კლას
        {
            //this ქივორდით ხდება მხოლოდ ამ კლასში არსებული ცვლადებთან წვდომა  შესაძლებელია დაწერო ესეც _FirstName = FirstName
            this._FirstName = FirstName;
            this._Lastname = Lastname;

        }
        
        public void PrintFullName()
        {
            Console.WriteLine("full name = {0}", this._FirstName + " " + this._Lastname);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer("tasotne","sturua");//ვქმნით ობიექტს და თან რადგან კონსტრუქტორიაქვს გადავცემთ პარამეტრე. გადაეცემა პარამეტრები
            c.PrintFullName();
        }

    }

  
}
