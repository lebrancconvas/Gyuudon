using System;

namespace gyuudon
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new Gyuudon())
                game.Run();
        }
    }
}
