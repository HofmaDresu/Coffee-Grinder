﻿using CocosSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeGrinder
{
    public class GameScene : CCScene
    {
        CCLayer _grinderLayer;

        public GameScene(CCGameView gameView) : base(gameView)
        {
            _grinderLayer = new GrinderLayer();
            AddLayer(_grinderLayer);
        }
    }
}