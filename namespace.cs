using System;
using PATA = ConsoleApp2.ProjectA.TeamA; // ამ ხერხითაც შესაძლებელია ნეიმსპეისის შემოტანა
using PATB = ConsoleApp2.ProjectA.TeamB;
namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            // განასხვავებს მხოლოდ  ნეიმსპეისი 
            PATA.classA.Print();
            PATB.classA.Print();
        }

    }

    namespace ProjectA // შესაძლებელია ბევ ადგილას ნეიმსპეისის გამოყენება 
    {
        namespace TeamA
        {
            class classA
            {
                public static void Print()
                {
                    Console.WriteLine("Team A Print Method");
                }
            }
        }
    }
    namespace ProjectA
    {
        namespace TeamB
        {
            class classA
            {

                public static void Print()
                {
                    Console.WriteLine("team B print Method");
                }

            }
        }
    }
}
