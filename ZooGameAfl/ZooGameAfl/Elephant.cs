using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooGameAfl
{
    public class Elephant : Animal
    {
        public Elephant(string name) : base(name) { }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} trutter: PRRRRR!");
        }
    }
}
