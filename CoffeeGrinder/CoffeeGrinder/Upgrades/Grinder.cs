using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeGrinder.Upgrades
{
    public class Grinder
    {
        public int Level { get; set; } = 1;
        public int GrindsPerAction { get; set; } = 1;
        public int UpgradePrice { get; set; } = 15;
        
        public void Upgrade()
        {
            Level++;
            GrindsPerAction += (int)Math.Ceiling(GrindsPerAction * .15);
            UpgradePrice += (int)Math.Ceiling(UpgradePrice * 1.5);
        }
    }
}
