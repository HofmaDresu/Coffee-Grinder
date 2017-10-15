namespace CoffeeGrinder.Upgrades
{
    public class NationalFranchise : BaseUpgrade
    {
        public NationalFranchise()
        {
            DisplayName = "Local Chains";
            Level = 0;
            InitialGrindsPerAction = 113;
            GrindsPerAction = 0;
            UpgradePrice = 70000;
            IncrementType = IncrementType.PerSecond;
        }
    }
}
