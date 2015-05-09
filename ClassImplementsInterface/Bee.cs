﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassImplementsInterface
{
    class Bee : IStingPatrol
    {
        public int AlertLevel { get; private set; }
        public int StingerLength { get; set; }
        public bool LookForEnemies() {
            return true;
        }
        public int SharpenStinger(int length) {
            return 0;
        }
    }
}
