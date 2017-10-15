namespace CoffeeGrinder.Upgrades
{
    public class Shop : BaseUpgrade
    {
        public Shop()
        {
            DisplayName = "Coffee Shops";
            Level = 0;
            InitialGrindsPerAction = 19;
            GrindsPerAction = 0;
            UpgradePrice = 2500;
            IncrementType = IncrementType.PerSecond;
        }
    }
}
