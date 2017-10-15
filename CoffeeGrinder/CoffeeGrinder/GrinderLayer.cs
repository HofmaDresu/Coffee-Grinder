using System;
using System.Collections.Generic;
using CocosSharp;
using Microsoft.Xna.Framework;
using System.Linq;

namespace CoffeeGrinder
{
    public class GrinderLayer : CCLayer
    {
        // Define a label variable
        CCLabel _titleLabel;
        CCLabel _countLabel;
        CCSprite _grinderSprite;
        CCNode _clickableArea;

        public GrinderLayer()
        {
            _titleLabel = new CCLabel("Coffee Grinder", "Arial", 62, CCLabelFormat.SystemFont);
            AddChild(_titleLabel);

            _countLabel = new CCLabel($"{GameController.BeansGround} Beans Ground", "Arial", 36, CCLabelFormat.SystemFont);
            AddChild(_countLabel);

            _grinderSprite = new CCSprite("BasicGrinder");
            AddChild(_grinderSprite);
            
            _clickableArea = new CCNode();
            AddChild(_clickableArea);

            Schedule(RunGameLogic);
        }

        private void RunGameLogic(float obj)
        {
            _countLabel.Text = $"{GameController.BeansGround} Beans Ground";
        }

        protected override void AddedToScene()
        {
            base.AddedToScene();
            
            _clickableArea.ContentSize = new CCSize(VisibleBoundsWorldspace.MaxX, VisibleBoundsWorldspace.MaxY - GameController.NavAreaHeight);
            _clickableArea.PositionY = GameController.NavAreaHeight;

            var bounds = _clickableArea.ContentSize;

            _grinderSprite.Position = bounds.Center;
            _titleLabel.Position = new CCPoint(bounds.Center.X, bounds.Height - 50);
            _countLabel.Position = new CCPoint(bounds.Center.X, bounds.Height - 150);



            // Register for touch events
            var touchListener = new CCEventListenerTouchAllAtOnce
            {
                OnTouchesEnded = OnTouchesEnded
            };
            AddEventListener(touchListener, this);
        }

        void OnTouchesEnded(List<CCTouch> touches, CCEvent touchEvent)
        {
            var firstTouch = touches.FirstOrDefault();

            if (firstTouch != null)
            {

                bool isTouchInside = _clickableArea.BoundingBoxTransformedToWorld.ContainsPoint(firstTouch.Location);

                if (isTouchInside)
                {
                    GameController.BeansGround += touches.Count * GameController.CoffeeHandGrinder.GrindsPerAction;
                }
            }
        }
	}
}

