﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooGameAfl
{
    public class Lion : Animal
    {
        public Lion(string name) : base(name) { }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} brøler: ROAR!");
        }
    }
}
