using System;

namespace Human
{
    public class Human
    {
        public string name;
        public int strength;
        public int intelligence;
        public int dexterity;
        public int health;

        public Human(string n)
        {
            name = n;
            strength = 3;
            intelligence = 3;
            dexterity = 3;
            health = 100;
        }

        public Human(string n, int s, int i, int d, int h)
        {
            name = n;
            strength = s;
            intelligence = i;
            dexterity = d;
            health = h;
        }

        public void attack(Object h)
        {
            if(h is Human)
            {
                Human hum = h as Human;
                int damage = this.strength * 5;
                Console.WriteLine("{0} attacks {1} for {2} damage!", this.name, hum.name, damage);
                hum.health -= damage;
                Console.WriteLine("{0} now has {1} health.", hum.name, hum.health);
            }
            else 
            {
                Console.WriteLine("You can only attack humans!");
            }
        }

    }

}