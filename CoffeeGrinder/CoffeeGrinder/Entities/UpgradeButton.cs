using CocosSharp;
using CoffeeGrinder.Upgrades;
using System.Collections.Generic;
using System.Linq;
using System;

namespace CoffeeGrinder.Entities
{
    public class UpgradeButton : CCNode
    {
        CCLabel _upgradeTitleLabel;
        CCLabel _upgradeCostLabel;
        CCLabel _upgradeEffectLabel;
        CCSprite _buttonSprite;
        CCEventListenerTouchAllAtOnce touchListener;
        BaseUpgrade _upgrade;
        bool _countTouchAsTap;

        public UpgradeButton(float height, float width, BaseUpgrade upgrade)
        {
            _upgrade = upgrade;

            ContentSize = new CCSize(width, height);
            var drawNode = new CCDrawNode();

            var buttonBackgroundPoints = new CCPoint[] { new CCPoint(10, 0), new CCPoint(10, height), new CCPoint(width, height), new CCPoint(width, 0) };
            drawNode.DrawPolygon(buttonBackgroundPoints, buttonBackgroundPoints.Length, CCColor4B.Gray, 1, CCColor4B.Black);
            AddChild(drawNode);

            _upgradeTitleLabel = new CCLabel($"{_upgrade.DisplayName} (Lvl {_upgrade.Level})", "Arial", 40, CCLabelFormat.SystemFont)
            {
                AnchorPoint = CCPoint.AnchorUpperLeft,
                Position = new CCPoint(20, height - 10)
            };
            AddChild(_upgradeTitleLabel);

            _upgradeCostLabel = new CCLabel($"{_upgrade.UpgradePrice} ground beans", "Arial", 30, CCLabelFormat.SystemFont)
            {
                AnchorPoint = CCPoint.AnchorLowerLeft,
                Position = new CCPoint(20, 10)
            };
            AddChild(_upgradeCostLabel);

            _upgradeEffectLabel = new CCLabel($"{_upgrade.GrindsPerAction} -> {_upgrade.NextGrindsPerAction} {GetIncrementTypeString()}", "Arial", 30, CCLabelFormat.SystemFont)
            {
                AnchorPoint = CCPoint.AnchorMiddleRight,
                Position = new CCPoint(width - 10, height / 2 - 10)
            };
            AddChild(_upgradeEffectLabel);

            touchListener = new CCEventListenerTouchAllAtOnce
            {
                OnTouchesBegan = HandleTouchBegin,
                OnTouchesMoved = HandleTouchMoved,
                OnTouchesEnded = HandleUpgradeTapped
            };
            AddEventListener(touchListener, this);
        }

        private void HandleTouchBegin(List<CCTouch> touches, CCEvent touchEvent)
        {
            var firstTouch = touches.FirstOrDefault();

            if (firstTouch != null)
            {
                _countTouchAsTap = BoundingBoxTransformedToWorld.ContainsPoint(firstTouch.Location);
            }
        }

        private void HandleTouchMoved(List<CCTouch> touches, CCEvent touchEvent)
        {
            var firstTouch = touches.FirstOrDefault();
            if (firstTouch != null)
            {
                var distanceMoved = firstTouch.Delta.Y;

                if (Math.Abs(distanceMoved) > 5)
                {
                    _countTouchAsTap = false;
                }
            }
        }

        private void HandleUpgradeTapped(List<CCTouch> touches, CCEvent touchEvent)
        {
            if (_countTouchAsTap && GameController.BeansGround >= _upgrade.UpgradePrice)
            {
                _upgrade.Upgrade();
                _upgradeTitleLabel.Text = $"{_upgrade.DisplayName} (Lvl {_upgrade.Level})";
                _upgradeCostLabel.Text = $"{_upgrade.UpgradePrice} ground beans";
                _upgradeEffectLabel.Text = $"{_upgrade.GrindsPerAction} -> {_upgrade.NextGrindsPerAction} {GetIncrementTypeString()}";
            }
        }

        private string GetIncrementTypeString()
        {
            return _upgrade.IncrementType == IncrementType.PerTap ? "Per Tap" : "Per Second";
        }
    }
}
