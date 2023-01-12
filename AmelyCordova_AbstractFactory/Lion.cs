﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmelyCordova_AbstractFactory
{
    class Lion : IAnimals
    {
        public void Speak()
        {
            Console.WriteLine("Roar!");
        }
    }
}
