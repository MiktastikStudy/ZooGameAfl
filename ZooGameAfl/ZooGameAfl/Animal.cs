using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooGameAfl
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int HungerLevel { get; set; } // 0 = fuld, 100 = meget sulten
        public Mood CurrentMood { get; private set; }

        public Animal(string name)
        {
            Name = name;
            HungerLevel = 50;
            
        }

        
    }
}
