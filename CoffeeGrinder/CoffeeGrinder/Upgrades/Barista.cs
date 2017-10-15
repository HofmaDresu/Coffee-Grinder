namespace CoffeeGrinder.Upgrades
{
    public class Barista : BaseUpgrade
    {
        public Barista()
        {
            DisplayName = "Baristas";
            Level = 0;
            InitialGrindsPerAction = 5;
            GrindsPerAction = 0;
            UpgradePrice = 300;
            IncrementType = IncrementType.PerSecond;
        }
    }
}
