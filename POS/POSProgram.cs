using POS.Boundary;

namespace POS
{
    internal static class PosProgram
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 고해상도 모니터 대응
            Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);

            // 윈도우 테마 스타일
            Application.EnableVisualStyles();

            // 최신 텍스트 렌더링
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationConfiguration.Initialize();
            Application.Run(new SalesManagerBoundary());
        }
    }
}  