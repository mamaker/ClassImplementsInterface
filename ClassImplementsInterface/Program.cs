﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassImplementsInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            NectarStinger bobTheBee = new NectarStinger();
            bobTheBee.LookForEnemies();
            bobTheBee.FindFlowers();
        }
    }
}
