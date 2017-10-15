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
            base.AddedToScene();

            var buttonVerticalPosition = VisibleBoundsWorldspace.MaxY - 110;
            var buttonWidth = VisibleBoundsWorldspace.MaxX - 20;

            _grinderUpgradesButton = new UpgradeButton("Grinder", 100, buttonWidth, GameController.CoffeeGrinder);
            AddChild(_grinderUpgradesButton);
            _grinderUpgradesButton.Position = new CCPoint(10, buttonVerticalPosition);

            buttonVerticalPosition -= 110;
            _baristaUpgradesButton = new UpgradeButton("Baristas", 100, buttonWidth, GameController.CoffeeBarista);
            AddChild(_baristaUpgradesButton);
            _baristaUpgradesButton.Position = new CCPoint(10, buttonVerticalPosition);
        }
	}
}

