using System;
using System.Collections.Generic;
using CocosSharp;
using Microsoft.Xna.Framework;

namespace CoffeeGrinder
{
    public class GrinderLayer : CCLayerColor
    {

        // Define a label variable
        CCLabel _titleLabel;
        CCLabel _countLabel;
        CCSprite _grinderSprite;

        public GrinderLayer() : base(CCColor4B.Gray)
        {
            _titleLabel = new CCLabel("Coffee Grinder", "Arial", 62, CCLabelFormat.SystemFont);
            AddChild(_titleLabel);
            _countLabel = new CCLabel($"{GameController.BeansGround} Beans Ground", "Arial", 36, CCLabelFormat.SystemFont);
            AddChild(_countLabel);

            _grinderSprite = new CCSprite("BasicGrinder");
            _grinderSprite.Scale = 1;
            AddChild(_grinderSprite);

            Schedule(RunGameLogic);
        }

        private void RunGameLogic(float obj)
        {
            _countLabel.Text = $"{GameController.BeansGround} Beans Ground";
        }

        protected override void AddedToScene()
        {
            base.AddedToScene();

            // Use the bounds to layout the positioning of our drawable assets
            var bounds = VisibleBoundsWorldspace;

            _grinderSprite.Position = bounds.Center;
            _titleLabel.Position = new CCPoint(bounds.Center.X, bounds.MaxY - 50);
            _countLabel.Position = new CCPoint(bounds.Center.X, bounds.MaxY - 150);

            // Register for touch events
            var touchListener = new CCEventListenerTouchAllAtOnce();
            touchListener.OnTouchesEnded = OnTouchesEnded;
            AddEventListener(touchListener, this);
        }

        void OnTouchesEnded(List<CCTouch> touches, CCEvent touchEvent)
        {
            if (touches.Count > 0)
            {
                GameController.BeansGround += touches.Count;
            }
        }
	}
}

