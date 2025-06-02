using Raylib_cs;

namespace RaylibCSharpWorkshop;

class Program
{
    [STAThread]
    public static void Main()
    {
        Raylib.InitWindow(800, 680, "Hello World");

        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.White);
            Raylib.DrawText("Hello world!", 12, 12, 20, Color.Red);
            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
}