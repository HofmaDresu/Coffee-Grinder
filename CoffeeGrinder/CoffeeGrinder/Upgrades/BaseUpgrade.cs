using System;

namespace CoffeeGrinder.Upgrades
{
    public class BaseUpgrade
    {
        public int Level { get; set; }
        public int GrindsPerAction { get; set; }
        public int UpgradePrice { get; set; }
        public int InitialGrindsPerAction { get; set; }
        
        public void Upgrade()
        {
            Level++;
            GrindsPerAction += (int)Math.Ceiling(GrindsPerAction * .15);
            UpgradePrice += (int)Math.Ceiling(UpgradePrice * 1.5);
        }
    }
}
