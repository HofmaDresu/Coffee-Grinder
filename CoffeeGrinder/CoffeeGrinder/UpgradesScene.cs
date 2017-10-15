using CocosSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeGrinder
{
    public class UpgradesScene : BaseScene
    {
        CCLayer _upgradesLayer;

        public UpgradesScene(CCGameView gameView) : base(gameView)
        {
            _upgradesLayer = new UpgradesLayer();
            AddLayer(_upgradesLayer);
        }
    }
}
