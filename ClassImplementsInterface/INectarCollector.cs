using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassImplementsInterface
{
    interface INectarCollector
    {
        int Nectar { get; set; }

        void FindFlowers();
        void GatherNectar();
        void ReturnToHive();
    }
}
