using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K300_12._06._2019
{
    class Car
    {
        public string marka;
        public string model;
        public double currentFuel;
        public double MaxFuel;
        public double usefuel;

        public Car(string marka, string model, double maxfuel, double usefuel, double currentFuel=30)
        {
            this.marka = marka;
            this.model = model;
            this.MaxFuel = maxfuel;
            this.usefuel = usefuel;
            this.currentFuel = currentFuel;
        }

        public void TopUp()
        {
            Console.WriteLine("Ne qeder benzin vurum?");
            string addFuel = Console.ReadLine();
            if (addFuel=="fuel")
            {
                currentFuel += MaxFuel - currentFuel;
                Console.WriteLine("Tam yanacaq doldurdunuz.Hal-hazirda {0} litr benzin var.", currentFuel);
            }
            else
            {
                double addedFuel = Convert.ToDouble(addFuel);

                if (MaxFuel < addedFuel + currentFuel)
                {

                    Console.WriteLine("Yanacaq kifayet etmir.");
                }
                else
                {
                    currentFuel += addedFuel;
                    Console.WriteLine("Yanacaq {0} litr doldururldu.", addedFuel);
                }
            }


        }
        public void Go()
        {
           
            double neededKm =0;
            while (neededKm == 0)
            {
                Console.WriteLine("Nece km getmek isteyirsiz?");
                neededKm = Convert.ToDouble(Console.ReadLine());
                if(currentFuel >= neededKm / 100 * usefuel)
                {
                    currentFuel -= neededKm / 100 * usefuel;
                    Console.WriteLine("Siz {0} km yol qet etdiniz. Hal hazirda masinda {1} litr benzin qalib.", neededKm, currentFuel);
                }
                else
                {
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("Masinda kifayet qeder benzin yoxdur.");
                    Console.WriteLine("--------------------------------------");
                }
            }
            
        }
        public bool CheckInput(string inp)
        {
            try
            {
                Convert.ToDouble(inp);
                return true;
            }
            catch (Exception)
            {

                Console.WriteLine("Zehmet olmasa  reqem daxil edin!");
                return false;
            }
        }
    }
}
