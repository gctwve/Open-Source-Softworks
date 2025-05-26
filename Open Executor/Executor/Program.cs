using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace executor
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                // Start WebView2 initialization before running the main application
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                // Initialize WebView2 before running the main form
                var webView2Initialization = InitializeWebView2Async();

                // Ensure WebView2 is initialized before launching the main form
                webView2Initialization.GetAwaiter().GetResult();

                // Run the application
                try
                {
                    Application.Run(new MainUI());
                }
                catch (Exception ex)
                {
                    // Log exception and show message box
                    LogError("Error during application run", ex);
                    MessageBox.Show("Error during application run: " + ex.ToString());
                }
            }
            catch (Exception ex)
            {
                // Log error and show message box for WebView2 initialization failure
                LogError("Error initializing WebView2", ex);
                MessageBox.Show("Error initializing WebView2: " + ex.ToString());
            }
        }

        static async Task InitializeWebView2Async()
        {
            try
            {
                // Initialize WebView2 with default settings
                await CoreWebView2Environment.CreateAsync(null);
            }
            catch (Exception ex)
            {
                // Handle and log WebView2 initialization error
                LogError("WebView2 initialization failed", ex);
                MessageBox.Show("WebView2 initialization failed: " + ex.Message);
            }
        }

        static void LogError(string message, Exception ex)
        {
            // Log error details to a file (this is just an example, use a proper logging library in production)
            string logMessage = $"{DateTime.Now}: {message}\n{ex.ToString()}\n\n";
            System.IO.File.AppendAllText("error_log.txt", logMessage);
        }
    }
}
