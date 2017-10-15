using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeGrinder.Upgrades
{
    public class Grinder : BaseUpgrade
    {
        public Grinder()
        {
            Level = 1;
            InitialGrindsPerAction = 1;
            GrindsPerAction = 1;
            UpgradePrice = 15;
        }
    }
}
