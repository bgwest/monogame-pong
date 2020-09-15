using System;

namespace monogame_pong
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new MonogamePong())
                game.Run();
        }
    }
}
