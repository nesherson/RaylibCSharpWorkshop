using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace RaylibCSharpWorkshop;

class Program
{
    private const int WindowWidth = 800;
    private const int WindowHeight = 600;
    [STAThread]
    public static void Main()
    {
        InitWindow(WindowWidth, WindowHeight, "Hello World");

        SetTargetFPS(60);

        var rectanglePosition = new Vector2(WindowWidth / 2, WindowHeight / 2);
        var rectangleSize = new Vector2(25, 25);
        var rectangleSpeed = new Vector2(2, 0);

        while (!WindowShouldClose())
        {
            if (rectanglePosition.X + rectangleSize.X >= GetScreenWidth())
            {
                rectanglePosition.X = 0;
            }
            else
            {
                rectanglePosition.X += rectangleSpeed.X;
                rectanglePosition.Y += rectangleSpeed.Y;      
            }

            BeginDrawing();
            ClearBackground(Color.White);
            DrawRectangleV(rectanglePosition, rectangleSize, Color.Blue);
            EndDrawing();
        }

        CloseWindow();
    }
}