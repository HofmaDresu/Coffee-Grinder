namespace CoffeeGrinder.Upgrades
{
    public class ElectricGrinder : BaseUpgrade
    {
        public ElectricGrinder()
        {
            Level = 0;
            InitialGrindsPerAction = 1;
            GrindsPerAction = 0;
            UpgradePrice = 100;
            IncrementType = IncrementType.PerSecond;
        }
    }
}
