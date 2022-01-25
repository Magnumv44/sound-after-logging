using System;
using System.Runtime.InteropServices;

namespace SoundAfterLogging
{
    class ShowHideCmd
    {
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private const int Hide = 0;

        /// <summary>
        /// Метод скрывает отображение консоли если в переменной Hide на вход приходит 0.
        /// </summary>
        /// <returns>
        /// Не возвращает значений.
        /// </returns>
        public static void DisappearConsole()
        {
            ShowWindow(GetConsoleWindow(), Hide);
        }
    }
}
