using Drawing_Program_Basic_Shape;
using SplashKitSDK;
using System;

namespace ShapeDrawer
{
    public class Program
    {
        private enum ShapeKinds
        {
            Rectangle,
            Circle,
            Line
        }
        public static void Main()
        {
            Window window  = new Window("Shape Drawer", 800, 600);
            Drawing draw = new Drawing();
            ShapeKinds kindToAdd;

            kindToAdd = ShapeKinds.Circle;

            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();
                
                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    Shape newShape;

                    if (kindToAdd == ShapeKinds.Circle)
                    {
                        MyCircle newCircle = new MyCircle();

                        newCircle.X = SplashKit.MouseX();
                        newCircle.Y = SplashKit.MouseY();
                        newShape = newCircle;
                    }
                    else if (kindToAdd == ShapeKinds.Rectangle)
                    {
                        MyRectangle newRect = new MyRectangle();
                        newRect.X = SplashKit.MouseX();
                        newRect.Y = SplashKit.MouseY();
                        newShape = newRect;
                    }
                    else
                    {
                        MyLine newLine = new MyLine();
                        newLine.X = SplashKit.MouseX();
                        newLine.Y = SplashKit.MouseY();
                        newShape = newLine;
                    }

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

                if (SplashKit.KeyTyped(KeyCode.BackspaceKey))
                {
                    foreach (Shape s in draw.SelectedShapes)
                    {
                        draw.RemoveShape(s);
                    }
                }

                if(SplashKit.KeyTyped(KeyCode.RKey))
                {
                    kindToAdd = ShapeKinds.Rectangle;
                }
                if (SplashKit.KeyTyped(KeyCode.CKey))
                {
                    kindToAdd = ShapeKinds.Circle;
                }
                if(SplashKit.KeyTyped(KeyCode.LKey))
                {
                    kindToAdd = ShapeKinds.Line;
                }

                draw.Draw();
                SplashKit.RefreshScreen();
            }

            while (!window.CloseRequested);
        }
    }
}
