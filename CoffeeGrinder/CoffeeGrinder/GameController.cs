﻿using CocosSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeGrinder
{
    public static  class GameController
    {
        public static long BeansGround;

        public static CCGameView GameView
        {
            get;
            private set;
        }

        public static void Initialize(CCGameView gameView)
        {
            GameView = gameView;

            var contentSearchPaths = new List<string>() { "Fonts", "Sounds" };

            contentSearchPaths.Add("Images");
            GameView.ContentManager.SearchPaths = contentSearchPaths;

            // We use a lower-resolution display to get a pixellated appearance
            int width = 768;
            int height = 1024;
            GameView.DesignResolution = new CCSizeI(width, height);            
            
            gameView.RunWithScene(new GameScene(GameView));
        }

        public static void GoToScene(CCScene scene)
        {
            GameView.Director.ReplaceScene(scene);
        }
    }
}
