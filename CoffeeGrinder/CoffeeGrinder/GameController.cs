using CocosSharp;
using CoffeeGrinder.Upgrades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeGrinder
{
    public static class GameController
    {
        public static double BeansGround;
        public static float NavAreaHeight;

        public static HandGrinder CoffeeHandGrinder = new HandGrinder();
        public static ElectricGrinder CoffeeElectricGrinder = new ElectricGrinder();
        public static Barista CoffeeBarista = new Barista();
        public static Roastery CoffeeRoastery = new Roastery();
        public static Shop CoffeeShop = new Shop();
        public static LocalChain CoffeeLocalChain = new LocalChain();
        public static NationalFranchise CoffeeNationalFranchise = new NationalFranchise();
        public static InternationalFranchise CoffeeInternationalFranchise = new InternationalFranchise();


        public static List<BaseUpgrade> AllUpgrades => new List<BaseUpgrade> { CoffeeHandGrinder, CoffeeElectricGrinder, CoffeeBarista, CoffeeRoastery, CoffeeShop, CoffeeLocalChain, CoffeeNationalFranchise, CoffeeInternationalFranchise };

        public static long GrindsPerSecond => AllUpgrades.Where(u => u.IncrementType == IncrementType.PerSecond).Sum(u => u.GrindsPerAction);

        public static CCGameView GameView
        {
            get;
            private set;
        }

        public static void Initialize(CCGameView gameView)
        {
            GameView = gameView;

            var contentSearchPaths = new List<string>() { "Fonts", "Sounds" };

            contentSearchPaths.Add("Images");
            GameView.ContentManager.SearchPaths = contentSearchPaths;
                
            int width = 768;
            int height = 1024;
            GameView.DesignResolution = new CCSizeI(width, height);
            
            gameView.RunWithScene(new GameScene(GameView));
            InitializeAudio();
        }

        private static void InitializeAudio()
        {
            //CCAudioEngine.SharedEngine.PlayBackgroundMusic("CoffeeBlack", true);
        }

        public static void GoToGrinder()
        {
            GameView.Director.ReplaceScene(new GameScene(GameView));
        }

        public static void GoToUpgrades()
        {
            GameView.Director.ReplaceScene(new UpgradesScene(GameView));
        }
    }
}
