using System;
using System.Collections.Generic;
using CocosSharp;
using Microsoft.Xna.Framework;

namespace CoffeeGrinder
{
    public class GameLayer : CCLayerColor
    {

        // Define a label variable
        CCLabel _titleLabel;
        CCLabel _countLabel;
        CCSprite _grinderSprite;

        public GameLayer() : base(CCColor4B.Gray)
        {
            _titleLabel = new CCLabel("Coffee Grinder", "Arial", 124, CCLabelFormat.SystemFont);
            AddChild(_titleLabel);
            _countLabel = new CCLabel($"{GameDelegate.BeansGround} Beans Ground", "Arial", 72, CCLabelFormat.SystemFont);
            AddChild(_countLabel);

            _grinderSprite = new CCSprite("BasicGrinder");
            _grinderSprite.Scale = 2;
            AddChild(_grinderSprite);

            Schedule(RunGameLogic);
        }

        private void RunGameLogic(float obj)
        {
            _countLabel.Text = $"{GameDelegate.BeansGround} Beans Ground";
        }

        protected override void AddedToScene()
        {
            base.AddedToScene();

            // Use the bounds to layout the positioning of our drawable assets
            var bounds = VisibleBoundsWorldspace;

            _grinderSprite.Position = bounds.Center;
            _titleLabel.Position = new CCPoint(bounds.Center.X, bounds.MaxY - 100);
            _countLabel.Position = new CCPoint(bounds.Center.X, bounds.MaxY - 300);

            // Register for touch events
            var touchListener = new CCEventListenerTouchAllAtOnce();
            touchListener.OnTouchesEnded = OnTouchesEnded;
            AddEventListener(touchListener, this);
        }

        void OnTouchesEnded(List<CCTouch> touches, CCEvent touchEvent)
        {
            if (touches.Count > 0)
            {
                GameDelegate.BeansGround += touches.Count;
            }
        }
	}
}

