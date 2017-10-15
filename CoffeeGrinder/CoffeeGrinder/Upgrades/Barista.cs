﻿namespace CoffeeGrinder.Upgrades
{
    public class Barista : BaseUpgrade
    {
        public Barista()
        {
            Level = 0;
            InitialGrindsPerAction = 5;
            GrindsPerAction = 0;
            UpgradePrice = 500;
            IncrementType = IncrementType.PerSecond;
        }
    }
}
