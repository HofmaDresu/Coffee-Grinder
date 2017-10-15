using System;

namespace CoffeeGrinder.Upgrades
{
    public class BaseUpgrade
    {
        public int Level { get; set; }
        public int GrindsPerAction { get; set; }
        public int UpgradePrice { get; set; }
        public int InitialGrindsPerAction { get; set; }
        public IncrementType IncrementType { get; set; }

        public void Upgrade()
        {
            Level++;
            GrindsPerAction = NextGrindsPerAction;

            GameController.BeansGround -= UpgradePrice;

            UpgradePrice = (int)Math.Ceiling(UpgradePrice * 1.25);
        }

        public int NextGrindsPerAction => GrindsPerAction == 0 ? InitialGrindsPerAction : (int)Math.Ceiling(GrindsPerAction * (IncrementType == IncrementType.PerTap ? 1.1 : 1.25));
    }


    public enum IncrementType
    {
        PerTap,
        PerSecond
    }
}
