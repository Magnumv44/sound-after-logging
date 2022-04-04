using System.IO;
using System.Media;

namespace SoundAfterLogging
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowHideCmd.DisappearConsole();

            string sMediaPath = @"C:\Windows\Media"; //Для указания относительного пути к файлу нужно использовать ".\Media"
            SoundPlayer sndPlayer = new SoundPlayer();
            sndPlayer.Stream = File.OpenRead(Path.Combine(sMediaPath, "Alarm01.wav"));
            sndPlayer.PlaySync();
            sndPlayer.Dispose();
        }
    }
}
