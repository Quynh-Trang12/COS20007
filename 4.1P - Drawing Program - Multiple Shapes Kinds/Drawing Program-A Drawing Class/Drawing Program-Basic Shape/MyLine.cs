using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace Drawing_Program_Basic_Shape
{
    public class MyLine : Shape
    {
        private float _endX, _endY;

        public MyLine() : this (Color.Red, 0, 0, 400, 300)
        {
        }

        public MyLine(Color color, float startX, float startY, float endX, float endY)
        {
            _endX = endX;
            _endY = endY;
            Color = color;
            startX = X;
            startY = Y;
            
        }

        public float EndX
        {
            get
            {
                return _endX;
            }
            set
            {
                _endX = value;
            }
        }
        public float EndY
        {
            get
            {
                return _endY;
            }
            set
            {
                _endY = value;
            }
        }

        public override void Draw()
        {
            SplashKit.DrawLine(Color, X, Y, EndX, EndY);
            if (Selected)
            {
                DrawOutline();
            }
        }

        public override void DrawOutline()
        {
            SplashKit.DrawLine(Color.Black, X, Y, EndX, EndY);
        }

        public override bool IsAt(Point2D pt)
        {
            return SplashKit.PointOnLine(pt, SplashKit.LineFrom(X,Y, EndX, EndY));
        }
    }
}
