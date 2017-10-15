namespace CoffeeGrinder.Upgrades
{
    public class Barista : BaseUpgrade
    {
        public Barista()
        {
            Level = 0;
            InitialGrindsPerAction = 1;
            GrindsPerAction = 0;
            UpgradePrice = 100;
        }
    }
}
