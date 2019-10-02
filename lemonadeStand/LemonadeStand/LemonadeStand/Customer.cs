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
        private List<string> names;
        static Random rng = new Random(DateTime.Now.Millisecond);
        private string name;
        // constructor
        public Customer()
        {
            names = new List<string>() { "Juan Rombaldi", "Jason JavirSchmidt", "Ash Jager", "Zofia Montagne", "Mustachio Joans", "Pistachio Pete", "Dirk the Clerk", "Chimmy Sweeps",
                "Cotter Putin", "Mona Simpson", "Moe Anna", "Eggy Mule", "Shorty Boyd", "Dennis Cutty", "Blake Donny", "Ichobad Crane", "Sonny Day", "Revolver Ocelot", "Mugsy Boags",
                "Seymore Banks", "Chimcham Bamma", "Johnny Flan", "Jim Jamb", "Baba Yaga", "Sasha Shaem", "Lance Doozey", "Buster Cripps", "Hugh Jnuthin", "Sarah Micks", "Josh Odoner",
                "Tron", "Clayton Bigsby", "Arthur Tiller", "Phrank Ocean", "Lionel Sims", "Barbara Waters", "Ahya Stahk", "Jimbo Janus", "Stannis Mannis", "Sword Becher", "Hugo Thattaway",
                "Ylgo Dissweh", "Moe Shemp", "Pate le PigBwah", "Gerry the Incel", "Susie Bimmer", "Spittoon Spencer", "Tammy Bobammy", "Sir Don Plour", "Chimchim Chimmaram", "Comishna Gordin",
                "Kevin Boston", "Vinny Deleo", "Alny Palmy", "Balmy Wetha", "Aria Sirius", "Lexus Texas", "Howland Reed", "Kenya Reed", "Cletus Bananas",  };

            
        }

        // methods
        public string GetName(int person)
        {
            string name = names[person];
            return name;
        }

        public bool ChanceToBuy(int weather, int temp)
        {
            int lowEnd = temp;
            int highEnd = (100 + weather);
            int chance = rng.Next(lowEnd, highEnd);
            if (chance == 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
