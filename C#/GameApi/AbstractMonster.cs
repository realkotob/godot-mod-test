using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApi
{
    public abstract class AbstractMonster
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }
    }
}
