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

            Console.WriteLine("Please enter  your target?");
            int UserTarget = int.Parse(Console.ReadLine()); // მომხმარებელს შემოაქვს რიცხვი
            int start = 0;
            while (start <= UserTarget)// ვაილში შევა მანამ სანამ starti არ გახდება შემოტანილი რიცხვის ტოლი
            {
                Console.WriteLine(start); // ბეჭდავს საწყის რიცხვს 
                start = start + 2; //ზრდის საწყის რიცხვს ორით თუ საწყის რიცხვს არ გავზრდით ჩაიციკლება პროგრამა რადგან თუ მომხმარებელი არ შემოიტანს ნულს ვაილი გაგრძელებს მუშაობას მანამ სანამ არ გაუტოლდება რიცხვები ერთმანეთს ეს კი არ მოხდება
                

            }

//მაგალითი 2
          string UserChoise = string.Empty; 
            do //N1
            {
                Console.WriteLine("Please enter  your target?");
            int UserTarget = int.Parse(Console.ReadLine());
            int start = 0;
           
                while (start <= UserTarget)
                {
                    Console.WriteLine(start);
                    start = start + 2;
                }
                do //N2  
                {
                    Console.WriteLine("Do you went to continue-yes on no?");
                    UserChoise = Console.ReadLine().ToUpper();
                    if (UserChoise != "YES" && UserChoise != "NO") //ამოწმებს სწორად შემოიტანა თუ არა
                    {
                        Console.WriteLine("Invalid choice , please say yes or No");
                    }
                } while (UserChoise != "YES" && UserChoise != "NO"); // თუ ეს შედარება ჭეშმარიტია მაშინ მუშაობას დაიწყებს do N2

            } while (UserChoise == "YES"); // თუ ეს შედარება ჭეშმარიტია მუშაობას დაიწყებს do N1





            Console.ReadKey();
        }
    }
}
