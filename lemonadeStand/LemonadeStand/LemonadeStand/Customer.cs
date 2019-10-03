using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        // variables
        public List<string> names;
        static Random rng = new Random(DateTime.Now.Millisecond);
        public double satisfaction;
        public double tempMultiplier;
        public double weatherMultiplier;
        public double satisfactionMultiplier;
        public double customerWhim;
        // constructor
        public Customer()
        {
            names = new List<string>() { "Juan Rombaldi", "Jason JavirSchmidt", "Ash Jager", "Zofia Montagne", "Mustachio Joans", "Pistachio Pete", "Dirk the Clerk", "Chimmy Sweeps",
                "Cotter Putin", "Mona Simpson", "Moe Anna", "Eggy Mule", "Shorty Boyd", "Dennis Cutty", "Blake Donny", "Ichobad Crane", "Sonny Day", "Revolver Ocelot", "Mugsy Boags",
                "Seymore Banks", "Chimcham Bamma", "Johnny Flan", "Jim Jamb", "Baba Yaga", "Sasha Shaem", "Lance Doozey", "Buster Cripps", "Hugh Jnuthin", "Sarah Micks", "Josh Odoner",
                "Tron", "Clayton Bigsby", "Arthur Tiller", "Phrank Ocean", "Lionel Sims", "Barbara Waters", "Ahya Stahk", "Jimbo Janus", "Stannis Mannis", "Sword Becher", "Hugo Thattaway",
                "Ylgo Dissweh", "Moe Shemp", "Pate le PigBwah", "Gerry the Incel", "Susie Bimmer", "Spittoon Spencer", "Tammy Bobammy", "Sir Don Plour", "Chimchim Chimmaram", "Comishna Gordin",
                "Kevin Boston", "Vinny Deleo", "Alny Palmy", "Balmy Wetha", "Aria Sirius", "Lexus Texas", "Howland Reed", "Kenya Reed", "Cletus Bananas", "Kuvern Macaque", "Levernius Tucker",
                "Frankie Carbone", "Artie Schwartz", "Gerry McCreary", "Chippy McGuire" };

            satisfactionMultiplier = 1;
            
        }

        public void ChangeSatisfaction(int ice, int lemons, int sugar, double price, int temp)
        {
            double change = 0;
            if (ice < 3 && temp < 70)
            {
                change += .005;
            }
            else if (ice > 3 && temp > 70)
            {
                change += .005;
            }
            else
            {
                change -= .005;
            }
            if (lemons >= 10)
            {
                change += .005;
            }
            else
            {
                change -= .005;
            }
            if (sugar >= 6)
            {
                change += .005;
            }
            else
            {
                change -= .005;
            }
            if (price <= 1)
            {
                change += .005;
            }
            else
            {
                change -= .005;
            }
            satisfactionMultiplier += change;
        }

        public double GetSatisfaction()
        {
            return satisfactionMultiplier;
        }
        
        public string GetName(int person)
        {
            string name = names[person];
            return name;
        }

        public bool ChanceToBuy(int weather, int temp, double whim, double satisfaction)
        {
            if (temp > 85)
            {
                tempMultiplier = 1.2;
            }
            else if (temp > 70 && temp <= 85)
            {
                tempMultiplier = 1.1;
            }
            else if (temp > 55 && temp <= 70)
            {
                tempMultiplier = 0.9;
            }
            else if (temp > 40 && temp <= 55)
            {
                tempMultiplier = 0.8;
            }

            if (weather == 0)
            {
                weatherMultiplier = 1.2;
            }
            else if (weather == 1)
            {
                weatherMultiplier = 1.1;
            }
            else if (weather == 2)
            {
                weatherMultiplier = 1.0;
            }
            else if (weather == 3)
            {
                weatherMultiplier = 0.9;
            }
            else if (weather == 4)
            {
                weatherMultiplier = 0.7;
            }
            else if (weather == 5)
            {
                weatherMultiplier = 0.2;
            }

            if (whim > 2)
            {
                customerWhim = 1.1;
            }
            else if (whim <= 2)
            {
                customerWhim = .9;
            }

            double chance = rng.Next(1, 100);
            double modChance = (chance * tempMultiplier * weatherMultiplier * customerWhim * satisfaction);
            if (modChance > 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int CupQuality(int sugarCubes, int lemons, int iceCubes, double price, int temp)
        {
            int recipeMultiplier;
            int iceCubesMultiplier;
            int quality;
            if (sugarCubes > 2 && lemons > 6 && price <= 1.00)
            {
                recipeMultiplier = 1;
            }
            else
            {
                recipeMultiplier = 0;
            }

            if (temp > 70 && iceCubes > 4)
            {
                iceCubesMultiplier = 1;
            }
            else if (temp <= 70 && iceCubes <= 4)
            {
                iceCubesMultiplier = 1;
            }
            else
            {
                iceCubesMultiplier = 0;
            }

            quality = recipeMultiplier + iceCubesMultiplier;
            return quality;
        } 
    }
}
