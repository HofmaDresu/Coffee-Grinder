namespace CoffeeGrinder.Upgrades
{
    public class Roastery : BaseUpgrade
    {
        public Roastery()
        {
            DisplayName = "Roasteries";
            Level = 0;
            InitialGrindsPerAction = 10;
            GrindsPerAction = 0;
            UpgradePrice = 1000;
            IncrementType = IncrementType.PerSecond;
        }
    }
}
