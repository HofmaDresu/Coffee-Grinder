namespace CoffeeGrinder.Upgrades
{
    public class LocalChain : BaseUpgrade
    {
        public LocalChain()
        {
            DisplayName = "Local Chains";
            Level = 0;
            InitialGrindsPerAction = 51;
            GrindsPerAction = 0;
            UpgradePrice = 10000;
            IncrementType = IncrementType.PerSecond;
        }
    }
}
