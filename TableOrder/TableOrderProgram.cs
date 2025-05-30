namespace TableOrder
{
    internal static class TableOrderProgram
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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new TableOrderBoundary());
        }
    }
}