using CocosSharp;

namespace CoffeeGrinder
{
    public class BaseScene : CCScene
    {
        public BaseScene(CCGameView gameView) : base(gameView)
        {
            Schedule(GrindPerSecond, 1);
        }

        protected void GrindPerSecond(float obj)
        {
            GameController.BeansGround += GameController.CoffeeElectricGrinder.GrindsPerAction + GameController.CoffeeBarista.GrindsPerAction;
        }
    }
}
