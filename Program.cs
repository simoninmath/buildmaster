using Raylib_cs;
using static Raylib_cs.Raylib;

public class RaylibGame
{
    public static int Main()
    {
        InitWindow(1280, 1024, "build_master");
        SetTargetFPS(60);

        InitAudioDevice();

        while (!WindowShouldClose())
        {
            BeginDrawing();
            ClearBackground(Color.RayWhite);
            DrawText("build_master", 190, 200, 20, Color.Magenta);
            EndDrawing();
        }

        CloseAudioDevice();
        CloseWindow();
        return 0;
    }
}
