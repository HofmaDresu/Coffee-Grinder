using System;
using static System.Math;

namespace CoffeeGrinder.Upgrades
{
    public class BaseUpgrade
    {
        public string DisplayName { get; set; }
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

            UpgradePrice = (int)Ceiling(UpgradePrice * 1.45);
        }

        public int NextGrindsPerAction => GrindsPerAction == 0 ? InitialGrindsPerAction : IncrementType == IncrementType.PerTap ? (int)Ceiling(GrindsPerAction + Max(1, GrindsPerAction * .1)) : GrindsPerAction + (int)Ceiling(GrindsPerAction * (Level / (Level + 1m)) );
    }


    public enum IncrementType
    {
        PerTap,
        PerSecond
    }
}
