﻿using CocosSharp;
using CoffeeGrinder.Upgrades;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeGrinder.Entities
{
    public class UpgradeButton : CCNode
    {
        CCLabel _upgradeTitleLabel;
        CCLabel _upgradeCostLabel;
        CCSprite _buttonSprite;
        CCEventListenerTouchAllAtOnce touchListener;
        BaseUpgrade _upgrade;

        public UpgradeButton(string buttonLabel, BaseUpgrade upgrade)
        {
            _upgrade = upgrade;

            var height = 100;
            var width = VisibleBoundsWorldspace.MaxY - 20;
            ContentSize = new CCSize(width, height);
            var drawNode = new CCDrawNode();

            var buttonBackgroundPoints = new CCPoint[] { new CCPoint(20, 0), new CCPoint(20, height), new CCPoint(width, height), new CCPoint(width, 0) };
            drawNode.DrawPolygon(buttonBackgroundPoints, buttonBackgroundPoints.Length, CCColor4B.Gray, 1, CCColor4B.Black);
            AddChild(drawNode);

            _upgradeTitleLabel = new CCLabel(buttonLabel, "Arial", 40, CCLabelFormat.SystemFont)
            {
                Position = new CCPoint(20, 80)
            };
            AddChild(_upgradeTitleLabel);

            _upgradeCostLabel = new CCLabel($"{_upgrade.UpgradePrice} ground beans", "Arial", 30, CCLabelFormat.SystemFont)
            {
                Position = new CCPoint(20, 20)
            };
            AddChild(_upgradeCostLabel);

            touchListener = new CCEventListenerTouchAllAtOnce
            {
                OnTouchesEnded = HandleInput
            };
            AddEventListener(touchListener, this);
        }


        private void HandleInput(List<CCTouch> touches, CCEvent touchEvent)
        {
            var firstTouch = touches.FirstOrDefault();

            if (firstTouch != null)
            {

                bool isTouchInside = BoundingBoxTransformedToWorld.ContainsPoint(firstTouch.Location);

                if (isTouchInside && GameController.BeansGround >= _upgrade.UpgradePrice)
                {
                    _upgrade.Upgrade();
                    _upgradeCostLabel.Text = $"{_upgrade.UpgradePrice} ground beans";
                }
            }
        }
    }
}
