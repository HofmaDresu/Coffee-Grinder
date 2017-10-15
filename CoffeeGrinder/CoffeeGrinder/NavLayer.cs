using CocosSharp;
using CoffeeGrinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeGrinder
{
    public class NavLayer : CCLayer
    {
        NavButton _clickerButton;
        NavButton _upgradesButton;
        NavButton _achievementsButton;
        NavButton _settingsButton;

        protected override void AddedToScene()
        {
            base.AddedToScene();


            GameController.NavAreaHeight = VisibleBoundsWorldspace.MaxX / 4f;
            _clickerButton = new NavButton("Grinder");
            AddChild(_clickerButton);

            _upgradesButton = new NavButton("Upgrades")
            {
                PositionX = GameController.NavAreaHeight,
                PositionY = VisibleBoundsWorldspace.MinY,
            };
            AddChild(_upgradesButton);

            _achievementsButton = new NavButton("Achievements")
            {
                PositionX = GameController.NavAreaHeight * 2,
                PositionY = VisibleBoundsWorldspace.MinY
            };
            AddChild(_achievementsButton);

            _settingsButton = new NavButton("Settings")
            {
                PositionX = GameController.NavAreaHeight * 3,
                PositionY = VisibleBoundsWorldspace.MinY
            };
            AddChild(_settingsButton);
        }
    }
}
