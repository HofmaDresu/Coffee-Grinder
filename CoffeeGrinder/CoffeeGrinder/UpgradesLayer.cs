using System;
using System.Collections.Generic;
using CocosSharp;
using Microsoft.Xna.Framework;
using System.Linq;
using CoffeeGrinder.Entities;

namespace CoffeeGrinder
{
    public class UpgradesLayer : CCLayer
    {
        private CCEventListenerTouchAllAtOnce _touchListener;
        private CCPoint3 _initialCenter;
        private float _totalListHeight;

        public UpgradesLayer()
        {

            _touchListener = new CCEventListenerTouchAllAtOnce
            {
                OnTouchesMoved = HandleInput
            };
            AddEventListener(_touchListener, this);
        }

        protected override void AddedToScene()
        {
            base.AddedToScene();

            var buttonVerticalPosition = VisibleBoundsWorldspace.MaxY;
            var buttonWidth = VisibleBoundsWorldspace.MaxX - 20;
            var buttonHeight = 150;
            var buttonHeightWithSeparator = buttonHeight + 20;

            foreach (var upgrade in GameController.AllUpgrades)
            {
                buttonVerticalPosition -= buttonHeightWithSeparator;
                var upgradeButton = new UpgradeButton(buttonHeight, buttonWidth, upgrade);
                AddChild(upgradeButton);
                upgradeButton.Position = new CCPoint(5, buttonVerticalPosition);
                _totalListHeight += buttonHeightWithSeparator;
            }

            _initialCenter = Camera.CenterInWorldspace;
        }

        private void HandleInput(List<CCTouch> touches, CCEvent touchEvent)
        {
            var firstTouch = touches.FirstOrDefault();
            if(firstTouch != null)
            {
                var distanceMoved = firstTouch.Delta.Y;
                
                if(Math.Abs(distanceMoved) > 5)
                {
                    // This moves the location of the camera:
                    var center = Camera.CenterInWorldspace;
                    center.Y = Math.Min(_initialCenter.Y, Math.Max(center.Y - distanceMoved, (_initialCenter.Y * 2) + GameController.NavAreaHeight - _totalListHeight));
                    Camera.CenterInWorldspace = center;

                    // This moves where the camera is looking.
                    // If we don't do this, the camera continues
                    // to look at its center location, resulting in
                    // perspective being applied to the scene:
                    var target = Camera.TargetInWorldspace;
                    target.X = center.X;
                    target.Y = center.Y;
                    Camera.TargetInWorldspace = target;
                }
            }            
        }
    }
}

