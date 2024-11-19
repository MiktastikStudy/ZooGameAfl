using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ZooGameAfl
{
    public class Monkey : Animal
    {
        public Monkey(string name) : base(name) { }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} laver lyde: Ooh ooh aah aah!");
        }

        public override string GetInfo()
        {
            return base.GetInfo() + " Den elsker bananer!";
        }
    }
}
