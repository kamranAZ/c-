using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K300_12._06._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Car masin = new Car("M5","Bmw",70,14);

            string userInput;
            do
            {
                Console.WriteLine("1.Go");
                Console.WriteLine("2.Top Up");
                Console.WriteLine("3.Stop");
                Console.WriteLine("4.Exit");
                Console.Write(">>>>>");

                userInput = Console.ReadLine();
                try
                {
                    Convert.ToInt32(userInput);
                    switch (userInput)
                    {
                        case "1":
                            masin.Go();
                            break;
                        case "2":
                            masin.TopUp();
                            break;
                        case "3":
                            Console.WriteLine("Bu qeder Masinda Benzin qalib");
                            break;
                        case "4":
                            Console.WriteLine("Xidmetimizden istifade etdiyiniz ucun tsk!");
                            break;
                        default:
                            Console.WriteLine("------------------------------------------------------");

                            Console.WriteLine("Zehmet olmasa yuxaridaki reqemlerden birini daxil edin!");
                            Console.WriteLine("---------------------------------------------------------");

                            break;
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Zehmet olmasa reqem daxil edin!");
                }
               
            } while (userInput!="4");




        }
    }
}
