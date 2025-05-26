using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Guna.UI2.WinForms;


namespace executor
{
    public partial class Settings : Form
    {
        private AppSettings _settings;
        public bool IsTopmost = false;
        public Settings(AppSettings settings)
        {
            InitializeComponent();
            _settings = settings;

            // You must do this to avoid overwriting the files
            TopMost_Switch.CheckedChanged -= ToggleTopmost;
            Disable_CloseTabMessage_Switch.CheckedChanged -= Toggle_CloseTabText;
            Minimap_Switch.CheckedChanged -= Minimap_Switch_CheckedChanged;

            TopMost_Switch.Checked = _settings.IsTopmost;
            Disable_CloseTabMessage_Switch.Checked = _settings.DisableConfirm;

            Minimap_Switch.Checked = _settings.MinimapToggle;

            APISwitch1.Checked = _settings.ChosenApi == "QuorumAPI";
            APISwitch2.Checked = _settings.ChosenApi == "OSSAPI";
            APISwitch3.Checked = _settings.ChosenApi == "SpashAPI";

            if (!APISwitch1.Checked && !APISwitch2.Checked && !APISwitch3.Checked)
            {
                APISwitch1.Checked = true;
            }

            APISwitch1.CheckedChanged += APISwitch_CheckedChanged;
            APISwitch2.CheckedChanged += APISwitch_CheckedChanged;
            APISwitch3.CheckedChanged += APISwitch_CheckedChanged;

            TopMost_Switch.CheckedChanged += ToggleTopmost;
            Disable_CloseTabMessage_Switch.CheckedChanged += Toggle_CloseTabText;
            Minimap_Switch.CheckedChanged += Minimap_Switch_CheckedChanged;

        }

        public static class WindowTopMostSet
        {
            [DllImport("user32.dll")]
            [return: MarshalAs(UnmanagedType.Bool)]
            static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

            private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
            private static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);
            private const uint SWP_NOSIZE = 0x0001;
            private const uint SWP_NOMOVE = 0x0002;

            public static void SetApplicationTopmost()
            {
                IntPtr mainWindowHandle = System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle;
                if (mainWindowHandle != IntPtr.Zero)
                {
                    SetWindowPos(mainWindowHandle, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE);
                }
            }
            public static void RemoveApplicationTopmost()
            {
                IntPtr mainWindowHandle = System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle;
                if (mainWindowHandle != IntPtr.Zero)
                {
                    SetWindowPos(mainWindowHandle, HWND_NOTOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE);
                }
            }

        }

        private void guna2Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void ToggleTopmost(object sender, EventArgs e)
        {
            if (TopMost_Switch.Checked)
            {
                WindowTopMostSet.SetApplicationTopmost();
                IsTopmost = true;
                SaveSettings();
            }
            else
            {
                WindowTopMostSet.RemoveApplicationTopmost();
                IsTopmost = false;
                SaveSettings();
            }
        }


        private void Toggle_CloseTabText(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void SaveSettings()
        {

            // get updated settings from UI
            _settings.IsTopmost = TopMost_Switch.Checked;
            _settings.DisableConfirm = Disable_CloseTabMessage_Switch.Checked;
            _settings.MinimapToggle = Minimap_Switch.Checked;
            _settings.ChosenApi = APISwitch1.Checked ? "QuorumAPI" : APISwitch2.Checked ? "OSSAPI" : "SpashAPI";

            // Save settings
            AppSettingsManager.SaveSettings(_settings);
        }

        private void Minimap_Switch_CheckedChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }


        private void APISwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is Guna2CustomRadioButton radioButton && radioButton.Checked)
            {
                SaveSettings();
            }
        }

        private void APISwitch2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
