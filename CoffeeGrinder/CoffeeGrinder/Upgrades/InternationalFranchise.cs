namespace CoffeeGrinder.Upgrades
{
    public class InternationalFranchise : BaseUpgrade
    {
        public InternationalFranchise()
        {
            DisplayName = "International Franchise";
            Level = 0;
            InitialGrindsPerAction = 500;
            GrindsPerAction = 0;
            UpgradePrice = 210000;
            IncrementType = IncrementType.PerSecond;
        }
    }
}
