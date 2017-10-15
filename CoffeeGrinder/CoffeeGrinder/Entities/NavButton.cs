using CocosSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeGrinder.Entities
{
    public class NavButton : CCNode
    {
        CCLabel _buttonLabel;
        CCSprite _buttonSprite;
        CCEventListenerTouchAllAtOnce touchListener;

        public NavButton(string buttonLabel)
        {
            var size = GameController.NavAreaHeight;
            ContentSize = new CCSize(size, size);
            AnchorPoint = CCPoint.AnchorLowerLeft;
            var halfSize = .5f * size;
            var drawNode = new CCDrawNode();

            var buttonBackgroundPoints = new CCPoint[] { new CCPoint(0, 0), new CCPoint(0, size), new CCPoint(size, size), new CCPoint(size, 0) };
            drawNode.DrawPolygon(buttonBackgroundPoints, buttonBackgroundPoints.Length, CCColor4B.Gray, 1, CCColor4B.Black);
            AddChild(drawNode);

            _buttonLabel = new CCLabel(buttonLabel, "Arial", 30, CCLabelFormat.SystemFont);
            _buttonLabel.Position = new CCPoint(halfSize, halfSize);
            AddChild(_buttonLabel);

            touchListener = new CCEventListenerTouchAllAtOnce
            {
                OnTouchesEnded = HandleInput
            };
            AddEventListener(touchListener, this);
        }


        private void HandleInput(List<CCTouch> touches, CCEvent touchEvent)
        {
            var firstTouch = touches.FirstOrDefault();

            if (firstTouch != null)
            {

                bool isTouchInside = BoundingBoxTransformedToWorld.ContainsPoint(firstTouch.Location);

                if (isTouchInside)
                {
                    int foo = 1;
                }
            }
        }
    }
}
