namespace CoffeeGrinder.Upgrades
{
    public class ElectricGrinder : BaseUpgrade
    {
        public ElectricGrinder()
        {
            DisplayName = "Electric Grinders";
            Level = 0;
            InitialGrindsPerAction = 1;
            GrindsPerAction = 0;
            UpgradePrice = 100;
            IncrementType = IncrementType.PerSecond;
        }
    }
}
