﻿using CocosSharp;
using CoffeeGrinder.Entities;
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
        CCLayer _backgroundLayer;
        CCLayer _navLayer;

        public GameScene(CCGameView gameView) : base(gameView)
        {
            _backgroundLayer = new CCLayerColor(CCColor4B.LightGray);
            AddLayer(_backgroundLayer);

            _grinderLayer = new GrinderLayer();
            AddLayer(_grinderLayer);

            _navLayer = new NavLayer();
            AddLayer(_navLayer);
        }
    }
}
