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
        UpgradeButton _grinderUpgradesButton;
        UpgradeButton _baristaUpgradesButton;

        public UpgradesLayer()
        {

        }

        protected override void AddedToScene()
        {
            var buttonHeight = 100;
            var buttonHeightWithSeparator = 120;
            base.AddedToScene();

            var buttonVerticalPosition = VisibleBoundsWorldspace.MaxY - buttonHeightWithSeparator;
            var buttonWidth = VisibleBoundsWorldspace.MaxX - 20;

            _grinderUpgradesButton = new UpgradeButton("Grinder", buttonHeight, buttonWidth, GameController.CoffeeGrinder);
            AddChild(_grinderUpgradesButton);
            _grinderUpgradesButton.Position = new CCPoint(5, buttonVerticalPosition);

            buttonVerticalPosition -= buttonHeightWithSeparator;
            _baristaUpgradesButton = new UpgradeButton("Baristas", buttonHeight, buttonWidth, GameController.CoffeeBarista);
            AddChild(_baristaUpgradesButton);
            _baristaUpgradesButton.Position = new CCPoint(5, buttonVerticalPosition);
        }
	}
}

