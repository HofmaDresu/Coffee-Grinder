namespace CoffeeGrinder.Upgrades
{
    public class NationalFranchise : BaseUpgrade
    {
        public NationalFranchise()
        {
            DisplayName = "National Franchise";
            Level = 0;
            InitialGrindsPerAction = 113;
            GrindsPerAction = 0;
            UpgradePrice = 70000;
            IncrementType = IncrementType.PerSecond;
        }
    }
}
