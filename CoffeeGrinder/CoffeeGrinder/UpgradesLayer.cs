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

        public UpgradesLayer()
        {

        }

        protected override void AddedToScene()
        {
            var buttonHeight = 100;
            var buttonHeightWithSeparator = 120;
            base.AddedToScene();

            var buttonVerticalPosition = VisibleBoundsWorldspace.MaxY;
            var buttonWidth = VisibleBoundsWorldspace.MaxX - 20;

            foreach (var upgrade in GameController.AllUpgrades)
            {
                buttonVerticalPosition -= buttonHeightWithSeparator;
                var upgradeButton = new UpgradeButton(buttonHeight, buttonWidth, upgrade);
                AddChild(upgradeButton);
                upgradeButton.Position = new CCPoint(5, buttonVerticalPosition);
            }
        }
	}
}

