using System;
using System.Collections.Generic;

using CocosSharp;
using CocosDenshion;

namespace CoffeeGrinder
{
    public static class GameDelegate
    {
        public static long BeansGround = 0;

        public static void LoadGame(object sender, EventArgs e)
        {
            CCGameView gameView = sender as CCGameView;

            if (gameView != null)
            {
                var contentSearchPaths = new List<string>() { "Fonts", "Sounds" , "Images"};
                CCSizeI viewSize = gameView.ViewSize;

                int height = 2048;
                int width = 1326;

                // Set world dimensions
                gameView.DesignResolution = new CCSizeI(width, height);

                gameView.ContentManager.SearchPaths = contentSearchPaths;

                CCScene gameScene = new CCScene(gameView);
                gameScene.AddLayer(new GameLayer());
                gameView.RunWithScene(gameScene);
            }
        }
	
    }
}