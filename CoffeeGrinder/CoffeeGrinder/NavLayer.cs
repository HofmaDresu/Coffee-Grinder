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


            var navButtonSize = VisibleBoundsWorldspace.MaxX / 4f;
            _clickerButton = new NavButton("Grinder", navButtonSize)
            {
                PositionX = navButtonSize / 2,
                PositionY = navButtonSize / 2
            };
            AddChild(_clickerButton);

            _upgradesButton = new NavButton("Upgrades", navButtonSize)
            {
                PositionX = navButtonSize / 2 + navButtonSize,
                PositionY = navButtonSize / 2
            };
            AddChild(_upgradesButton);

            _achievementsButton = new NavButton("Achievements", navButtonSize)
            {
                PositionX = navButtonSize / 2 + navButtonSize * 2,
                PositionY = navButtonSize / 2
            };
            AddChild(_achievementsButton);

            _settingsButton = new NavButton("Settings", navButtonSize)
            {
                PositionX = navButtonSize / 2 + navButtonSize * 3,
                PositionY = navButtonSize / 2
            };
            AddChild(_settingsButton);
        }
    }
}
