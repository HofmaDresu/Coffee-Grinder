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
            if(GrindsPerAction == 0)
            {
                GrindsPerAction = InitialGrindsPerAction;
            }
            else
            {
                GrindsPerAction += (int)Math.Ceiling(GrindsPerAction * .1);
            }

            GameController.BeansGround -= UpgradePrice;

            UpgradePrice = (int)Math.Ceiling(UpgradePrice * 1.25);
        }
    }
}
