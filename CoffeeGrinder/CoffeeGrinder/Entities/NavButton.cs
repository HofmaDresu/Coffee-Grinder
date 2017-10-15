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

        public NavButton(string buttonLabel, float size)
        {
            var negativeHalfSize = -.5f * size;
            var halfSize = .5f * size;
            var drawNode = new CCDrawNode();
            AddChild(drawNode);

            var buttonBackgroundPoints = new CCPoint[] { new CCPoint(negativeHalfSize, negativeHalfSize), new CCPoint(negativeHalfSize, halfSize), new CCPoint(halfSize, halfSize), new CCPoint(halfSize, negativeHalfSize) };
            drawNode.DrawPolygon(buttonBackgroundPoints, buttonBackgroundPoints.Length, CCColor4B.Gray, 1, CCColor4B.Black);

            _buttonLabel = new CCLabel(buttonLabel, "Arial", 30, CCLabelFormat.SystemFont);
            AddChild(_buttonLabel);

        }

    }
}
