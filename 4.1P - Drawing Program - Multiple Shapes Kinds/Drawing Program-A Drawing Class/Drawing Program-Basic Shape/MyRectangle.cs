using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace Drawing_Program_Basic_Shape
{
    public class MyRectangle : Shape
    {
        private int _width, _height;

        public MyRectangle(Color clr, float x, float y, int width, int height) : base (clr)
        {
            X = x;
            Y = y;
            _width = width;
            _height = height;
        }

        public MyRectangle() : this (Color.Green, 0, 0, 100, 100)
        {
        }

        public override void Draw()
        {
            SplashKit.FillRectangle(this.Color, X, Y, _width, _height);
            if (Selected)
            {
                DrawOutline();
            }
        }

        public override void DrawOutline()
        {
            SplashKit.DrawRectangle(Color.Black, X - 2, Y -2, _width + 4, _height + 4);
        }

        public override bool IsAt(Point2D pt)
        {
            return ((pt.X > X) && (pt.Y > Y) && (pt.X < X + _width) && (pt.Y < Y + _height));           
        }
    }
}
