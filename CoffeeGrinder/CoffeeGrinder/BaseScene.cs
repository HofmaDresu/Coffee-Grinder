using CocosSharp;

namespace CoffeeGrinder
{
    public class BaseScene : CCScene
    {
        CCLayer _navLayer;
        CCLayer _backgroundLayer;

        public BaseScene(CCGameView gameView) : base(gameView)
        {
            _backgroundLayer = new CCLayerColor(CCColor4B.LightGray);
            AddLayer(_backgroundLayer);

            _navLayer = new NavLayer();
            AddLayer(_navLayer, 1000);

            Schedule(GrindPerSecond, 1);
        }

        protected void GrindPerSecond(float obj)
        {
            GameController.BeansGround += GameController.GrindsPerSecond;
        }
    }
}
