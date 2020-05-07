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
            int TotalCoffeeCost = 0;
        start:
            Console.WriteLine("Please Select your coffee size: 1-small, 2-medium, 3-large");
            int Userchoice = int.Parse(Console.ReadLine());

            switch (Userchoice)
            {
                case 1:
                    TotalCoffeeCost = +1;
                    break;
                case 2:
                    TotalCoffeeCost = +2;
                  goto case 1;// დაბრუნდება პირველ ქეისზე
                case 3:
                    TotalCoffeeCost = +3;
                    break;
                default:
                    Console.WriteLine(" Your choice {0} is invalid ", Userchoice);
                    goto start; 
            }

          Decide: 
            Console.WriteLine("Do you went to buy another coffe -Yes or No");
            string UserDecision = Console.ReadLine();

            switch (UserDecision.ToUpper())
            {
                case "YES"://თუ მომხმარებლის შემოტანილი სიტყვა უდრის YES მაშინ შემოვა და შეასრულებს ბრძანებას რაც მოცემული იქნება case-ში
                    goto start; //ეს ბრძანება პროგრამას ეუბნება რომ დაიწყოს მუშაობა start - დან სადაც აცხადებ start -ს
                case "NO":
                    break; //შეწყვეტს მუშაობას  
                default:
                    Console.WriteLine("Your choice {0} is invalid. Pliase try again...", UserDecision);
                    goto Decide;// მუშაობას დაიწყებს Decide-დან
            }




            Console.WriteLine("thank you for shopping with us");
            Console.WriteLine("Bill Amonut ={0}", TotalCoffeeCost);



            Console.ReadKey(); //კონსოლი ელოდება კლავიატურაზე დაჭერას რომ შეწყვტოს მუშაობა
        }
    }
}

//მაგალითი შეიძლება ჩანაწერი იყოს ესეთიც
//  Console.WriteLine("ShemoitaneT simbolo");
//             char simbolo = Convert.ToChar(Console.ReadLine());
//             string Text;
//             switch (simbolo)
//             {
//                 case 'A':
//                 case 'E':
//                 case 'I':
//                 case 'O':
//                 case 'U':
//                     Text = "xmovania ";
//                     break;
//                 default:
//                     Text = "Tanxmovcania";
//                     break;
//             }
//             Console.WriteLine(Text);
