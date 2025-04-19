using Drawing_Program_Basic_Shape;
using SplashKitSDK;
using System;

namespace ShapeDrawer
{
    public class Program
    {
        public static void Main()
        {
            Window window  = new Window("Shape Drawer", 800, 600);
            Drawing draw = new Drawing();

            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();
                
                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    Shape newShape = new Shape();
                    newShape.X = SplashKit.MouseX();
                    newShape.Y = SplashKit.MouseY();

                    draw.AddShape(newShape);
 
                }
                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    draw.Background = Color.RandomRGB(255);
                }

                if (SplashKit.MouseClicked(MouseButton.RightButton))
                {
                    draw.SelectShapesAt(SplashKit.MousePosition());
                }

                draw.Draw();
                SplashKit.RefreshScreen();
            }

            while (!window.CloseRequested);
        }
    }
}
