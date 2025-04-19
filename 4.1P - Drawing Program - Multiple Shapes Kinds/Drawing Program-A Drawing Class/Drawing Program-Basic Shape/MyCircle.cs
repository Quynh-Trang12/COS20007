using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace Drawing_Program_Basic_Shape
{
    public class MyCircle : Shape
    {
        private int _radius;

        public int Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = value;
            }
        }

        public MyCircle() : this(Color.Blue, 50)
        {
        }

        public MyCircle(Color clr, int radius)
        {
            _radius = radius;
            Color = clr;
        }

        public override void Draw()
        {
            SplashKit.FillCircle(Color, X, Y, _radius);
            if (Selected)
            {
                DrawOutline();
            }                
        }

        public override void DrawOutline()
        {
            SplashKit.DrawCircle(Color.Black, X, Y, _radius + 2);
        }

        public override bool IsAt(Point2D pt)
        {
            return (SplashKit.PointInCircle(pt.X, pt.Y, X, Y, _radius));
        }

    }
}
