    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Threading.Tasks;
    using System.Timers;
    using System.Windows.Forms;
    using Guna.UI2.WinForms;
    using Newtonsoft.Json;

    namespace executor
    {
        public partial class Executor : Form
        {
            private AppSettings _settings;

            private int destroyedTabs = 0;
            private int totalTabCount = 6; // Max tabs you ever want
            private int Add_Button_X_Offset = 2; // THIS CONTROLS ADD BUTTON LOCATION!!
            private int Add_Button_Y_Offset = 1;
            private Color WebViewColor = System.Drawing.Color.FromArgb(12,12,12); // You must change it in index.html too
            private string localAppDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "OpenSourceExecutor");

            

            public bool tabsloaded = false;
            private bool IsTopmost = false;
            private bool DisableConfirm = false;
            private bool MinimapToggle = true;
            private string ChosenAPI = "SpashAPI"; // Fallback

            public System.Windows.Forms.Timer time = new System.Windows.Forms.Timer();
            public System.Timers.Timer savetimer = new System.Timers.Timer(5000);

            public Executor(AppSettings settings)
            {
                
                // Update Execution Buton
                time.Tick += timertick;
                time.Start();

                // Saves file every 5 seconds
                savetimer.Elapsed += TimerElapsed;
                savetimer.Start();
                InitializeComponent();
                guna2TabControl1.Visible = false;

                // Defines settings object
                _settings = settings;

            // Setup Close Buttons
            for (int i = 2; i <= totalTabCount; i++)
                {
                    Guna2Button newButton = new Guna2Button();

                    newButton.FillColor = closeButton1.FillColor;
                    newButton.Text = closeButton1.Text;
                    newButton.Size = new Size(closeButton1.Size.Width, closeButton1.Size.Height);
                    newButton.HoverState = closeButton1.HoverState;
                    newButton.Anchor = closeButton1.Anchor;
                    newButton.UseTransparentBackground = closeButton1.UseTransparentBackground;
                    newButton.Image = closeButton1.Image;
                    newButton.Visible = false;
                    newButton.ImageSize = closeButton1.ImageSize;
                    newButton.ImageAlign = closeButton1.ImageAlign;
                    newButton.Location = new System.Drawing.Point(closeButton1.Location.X + (guna2TabControl1.TabButtonSize.Width * (i - 1)), closeButton1.Location.Y);
                    newButton.BorderStyle = closeButton1.BorderStyle;
                    newButton.BorderThickness = closeButton1.BorderThickness;
                    newButton.BorderColor = closeButton1.BorderColor;
                    newButton.Name = $"closeButton{i}";
                    this.Controls.Add(newButton);
                    newButton.BringToFront();
                }

                // Add functions to all close buttons
                for (int i = 1; i <= totalTabCount; i++)
                {
                    // Inside the line below, if your button has a parent, add this.parentname.Controls to avoid error
                    Guna.UI2.WinForms.Guna2Button button = (Guna.UI2.WinForms.Guna2Button)this.Controls["closeButton" + i];
                    int tab = i - 1;
                    button.Click += (sender2, args2) =>
                    {
                        if (guna2TabControl1.TabCount != 1)
                        {
                            bool deleteConfirmed = true;
                            if (!DisableConfirm)
                            {
                                deleteConfirmed = MessageBox.Show("Are you sure you want to delete " + (guna2TabControl1.TabPages[tab].Text) + "?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes;
                            }

                            if (deleteConfirmed)
                            {
                                destroyedTabs++;
                                guna2TabControl1.TabPages.RemoveAt(tab);
                                if (guna2TabControl1.TabCount < totalTabCount - 1)
                                {
                                    Rectangle tabRect = guna2TabControl1.GetTabRect(guna2TabControl1.TabCount - 1);
                                    Point newLocation = new Point(tabRect.X + guna2TabControl1.TabButtonSize.Width + Add_Button_X_Offset, tabRect.Y + Add_Button_Y_Offset);
                                    Add_Tab.Location = newLocation;
                                    Add_Tab.Visible = true;

                                    for (int w = 1; w <= totalTabCount; w++)
                                    {
                                        Guna.UI2.WinForms.Guna2Button button2 = (Guna.UI2.WinForms.Guna2Button)this.Controls["closeButton" + (w)];
                                        if (w <= guna2TabControl1.TabCount)
                                        {
                                            button2.Visible = true;
                                        }
                                        else
                                        {
                                            button2.Visible = false;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                return;
                            }
                        }
                    };
                }
            }


        private void Executor_Load(object sender, EventArgs e) // Only run on form load
            {


            // If settings exist, load them in
            if (_settings.IsTopmost)
                {
                    WindowTopMostSet.SetApplicationTopmost();
                    IsTopmost = true;
                }
                else
                {
                    WindowTopMostSet.RemoveApplicationTopmost();
                    IsTopmost = false;
                }

                if (_settings.DisableConfirm)
                {
                    DisableConfirm = true;
                }

                if (_settings.MinimapToggle)
                {
                    MinimapToggle = true;
                }
                else
                {
                    MinimapToggle = false;
                }

                if (_settings.ChosenApi != null)
                {
                    ChosenAPI = _settings.ChosenApi;
                }

                LoadTabs(); // Load tabs from savefile
                guna2TabControl1.Visible = true; // Make TabControl visible after tabs are loaded
            }


        private void timertick(object sender, EventArgs e) // Current State
        {

            if (ChosenAPI == "QuorumAPI")
            {
                int result = QuorumAPI.QuorumAPI.GetAttachState();
                if (result == 1)
                {
                    Execute.ForeColor = Color.Orange;
                }
                else
                {
                    Execute.ForeColor = Color.Gray;
                }
            }

            if (ChosenAPI == "QuorumAPI")
            {
                if (Api.IsRobloxOpen())
                {
                    killRoblox.ForeColor = Color.Orange;
                }
                else
                {
                    killRoblox.ForeColor = Color.Gray;
                }
            }

            if (ChosenAPI == "OSSAPI")
            {
                bool result = OSSApi.Api.IsInjected(); 
                if (result == true)
                {
                    Execute.ForeColor = Color.Orange;
                }
                else
                {
                    Execute.ForeColor = Color.Gray;
                }
            }
            if (ChosenAPI == "OSSAPI")
            {
                if (Api.IsRobloxOpen())
                {
                    killRoblox.ForeColor = Color.Orange;
                }
                else
                {
                    killRoblox.ForeColor = Color.Gray;
                }
            }
            if (ChosenAPI == "SpashAPI")
            {
                if (Api.IsRobloxOpen()) 
                {
                    killRoblox.ForeColor = Color.Orange;
                }
                else
                {
                    killRoblox.ForeColor = Color.Gray;
                }

            }
            /*
            if (ChosenAPI == "SpashAPI")
            {
                if (SpashAPIXeno.SpashAPIXeno.IsAttached())
                {
                    guna2Button1.ForeColor = Color.Orange;
                }
                else
                {
                    guna2Button1.ForeColor = Color.Gray;
                }
            }*/
        }
            private void Inject_Click(object sender, EventArgs e) //Inject Button
            {   
                if (ChosenAPI == "QuorumAPI")
                {
                    QuorumAPI.QuorumAPI.AttachAPIWithState();
            }

                if (ChosenAPI == "OSSAPI")
                {
                    OSSApi.Api.Inject();
                }
                if (ChosenAPI == "SpashAPI")
                {
                    SpashAPIXeno.SpashAPIXeno.AttachAPI();
                }
        }


            private async void Clear_Click(object sender, EventArgs e)
            {
                try
                {
                    var selectedTab = guna2TabControl1.SelectedTab;
                    if (selectedTab != null)
                    {
                        Microsoft.Web.WebView2.WinForms.WebView2 webView = selectedTab.Controls.OfType<Microsoft.Web.WebView2.WinForms.WebView2>().FirstOrDefault();
                        if (webView != null)
                        {
                            await webView.EnsureCoreWebView2Async();
                            await webView.CoreWebView2.ExecuteScriptAsync("editor.setValue('');");
                        }
                    }
                }
                catch (Exception ex)
                {
                Clipboard.SetText(ex.Message);
                    // Log or show the error message to help debug
                    MessageBox.Show($"An error occurred: {ex.Message}");
                    
                }
            }

            private async void Execute_ClickAsync(object sender, EventArgs e) //Execute Button
            {
                Microsoft.Web.WebView2.WinForms.WebView2 webView = (Microsoft.Web.WebView2.WinForms.WebView2)guna2TabControl1.SelectedTab.Controls[0];
                var result = await webView.CoreWebView2.ExecuteScriptAsync("GetText();");
                var text = JsonConvert.DeserializeObject<string>(result);
            
                if (ChosenAPI == "QuorumAPI")
                {
                    if (Api.IsRobloxOpen())
                    {
                    QuorumAPI.QuorumAPI.ExecuteScript(text);
                    }
                }
            
                if (ChosenAPI == "OSSAPI")
                {
                        OSSApi.Api.Execute(text);
                }

            if (ChosenAPI == "SpashAPI")
            {
                SpashAPIXeno.SpashAPIXeno.AttachScript(text);
            }
        }

            public void LoadTabs() // Load Save file data into tabs
            {
                if (File.Exists(Path.Combine(localAppDataPath, "tabs.json")))
                {
                    string FilePath = System.IO.Path.Combine(localAppDataPath, "tabs.json");
                    if (!System.IO.File.Exists(FilePath))
                    {
                        Add_Tab_Click(null, EventArgs.Empty);
                        return;
                    }
                    string json = File.ReadAllText(FilePath);
                    List<TabInfo> tabInfos = JsonConvert.DeserializeObject<List<TabInfo>>(json);

                        foreach (var tabInfo in tabInfos)
                        {

                            Add_Tab.Visible = false;
                            TabPage tabPage = new TabPage(tabInfo.Name);
                            tabPage.BackColor = WebViewColor;
                            tabPage.AllowDrop = true;

                            guna2TabControl1.TabPages.Add(tabPage);
                            Microsoft.Web.WebView2.WinForms.WebView2 webBrowser = new Microsoft.Web.WebView2.WinForms.WebView2 { Dock = DockStyle.Fill, AllowExternalDrop = false };
                            webBrowser.Source = new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Monaco\index.html"));
                            webBrowser.DefaultBackgroundColor = WebViewColor;

                            tabPage.Controls.Add(webBrowser);

                            webBrowser.CoreWebView2InitializationCompleted += (sender, e) =>
                            {
                                if (e.IsSuccess)
                                {
                                    LoadContentIntoWebView(webBrowser, tabInfo.Content);
                                }
                            };
                        }
                


                    if (guna2TabControl1.TabCount < totalTabCount - 1)
                    {
                        Rectangle tabRect = guna2TabControl1.GetTabRect(guna2TabControl1.TabCount - 1);
                        Point newLocation = new Point(tabRect.X + guna2TabControl1.TabButtonSize.Width + Add_Button_X_Offset, tabRect.Y + Add_Button_Y_Offset);
                        Add_Tab.Location = newLocation;
                        Add_Tab.Visible = true;
                    }

                    for (int i = 1; i <= totalTabCount; i++)
                    {
                        Guna.UI2.WinForms.Guna2Button button = (Guna.UI2.WinForms.Guna2Button)this.Controls["closeButton" + i];
                        if (i <= guna2TabControl1.TabCount)
                        {
                            button.Visible = true;
                        }
                        else
                        {
                            button.Visible = false;
                        }
                    }
                }
                else

                {
                    Add_Tab_Click(null, EventArgs.Empty); // Add 1 default tab if no savefile
                    tabsloaded = true;
                }
            }


            private void LoadContentIntoWebView(Microsoft.Web.WebView2.WinForms.WebView2 webView, string content) // Load data into a specific tab
            {
                webView.NavigationCompleted += async (sender, e) =>
                {
                    if (e.IsSuccess)
                    {
                        await webView.ExecuteScriptAsync($"editor.setValue({content});");
                        await webView.ExecuteScriptAsync($"SwitchMinimap({MinimapToggle.ToString().ToLower()});");
                        tabsloaded = true;
                    }
                };
            }


        private bool isSavingTabs = false;

        public async void SaveTabs() // Save tabs to tabs.json in localappdata
        {
            if (tabsloaded == true && !isSavingTabs) // Check if it's already saving
            {
                isSavingTabs = true;  // Set the flag to indicate saving is in progress

                TabSaver tabSaver = new TabSaver(guna2TabControl1);
                string folderPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "OpenSourceExecutor");
                if (!System.IO.Directory.Exists(folderPath))
                {
                    System.IO.Directory.CreateDirectory(folderPath);
                }
                string filePath = System.IO.Path.Combine(folderPath, "tabs.json");

                await tabSaver.SaveTabsAsync(filePath);

                isSavingTabs = false;  // Reset the flag once saving is complete
            }
        }

        public async void LoadIntoCurrentTab(string text) // Used for Listbox loading
        {
            Microsoft.Web.WebView2.WinForms.WebView2 webView = (Microsoft.Web.WebView2.WinForms.WebView2)guna2TabControl1.SelectedTab.Controls[0];
            string jsonContent = JsonConvert.SerializeObject(text);
            await webView.CoreWebView2.ExecuteScriptAsync($"editor.setValue({jsonContent});");

            // Remove the call to SaveTabs() from here or make sure it doesn't trigger too often.
            // SaveTabs(); 
        }

        private async void Open_Click(object sender, EventArgs e) // Load file into executor with open button
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Lua or Text files (*.lua;*.txt)|*.lua;*.txt";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string fileContent = File.ReadAllText(filePath);

                    string jsonContent = JsonConvert.SerializeObject(fileContent);

                    Microsoft.Web.WebView2.WinForms.WebView2 webView = (Microsoft.Web.WebView2.WinForms.WebView2)guna2TabControl1.SelectedTab.Controls[0];
                    await webView.CoreWebView2.ExecuteScriptAsync($"editor.setValue({JsonConvert.SerializeObject(fileContent)}); editor.setValue({jsonContent});");
                    SaveTabs();
                }
            }

            private void Add_Tab_Click(object sender, EventArgs e) // Add a tab when you click the button
            {
                Add_Tab.Visible = false;
                TabPage tabPage = new TabPage($"Tab {guna2TabControl1.TabCount + 1 + destroyedTabs}");
                tabPage.BackColor = WebViewColor;

                guna2TabControl1.TabPages.Add(tabPage);
                Microsoft.Web.WebView2.WinForms.WebView2 webBrowser = new Microsoft.Web.WebView2.WinForms.WebView2 { Dock = DockStyle.Fill, AllowExternalDrop = false };
                webBrowser.BackColor = WebViewColor;
                webBrowser.DefaultBackgroundColor = WebViewColor;

                tabPage.Controls.Add(webBrowser);
                webBrowser.Source = new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Monaco\index.html"));
                guna2TabControl1.SelectedTab = tabPage;
                SaveTabs();

                // New positions for Add_Tab
                if (guna2TabControl1.TabCount < totalTabCount - 1)
                {
                    Rectangle tabRect = guna2TabControl1.GetTabRect(guna2TabControl1.TabCount - 1);
                    Point newLocation = new Point(tabRect.X + guna2TabControl1.TabButtonSize.Width + Add_Button_X_Offset, tabRect.Y + Add_Button_Y_Offset);
                    Add_Tab.Location = newLocation;
                    Add_Tab.Visible = true;
                }

                // Redo closebutton locations
                for (int i = 1; i <= totalTabCount; i++)
                {
                    Guna.UI2.WinForms.Guna2Button button = (Guna.UI2.WinForms.Guna2Button)this.Controls["closeButton" + i];
                    if (i <= guna2TabControl1.TabCount)
                    {
                        button.Visible = true;
                    }
                    else
                    {
                        button.Visible = false;
                    }
                }
            }

            // Changing tabs updates minimap
            private async void guna2TabControl1_SelectedIndexChanged(object sender, EventArgs e)
            {
                Microsoft.Web.WebView2.WinForms.WebView2 webView = (Microsoft.Web.WebView2.WinForms.WebView2)guna2TabControl1.SelectedTab.Controls[0];
                await webView.EnsureCoreWebView2Async();
                await Task.Delay(400);
                await webView.ExecuteScriptAsync($"SwitchMinimap({MinimapToggle.ToString().ToLower()});");
            }

            private void guna2TabControl1_DoubleClick(object sender, EventArgs e) // Renaming tabs
            {
                MouseEventArgs me = (MouseEventArgs)e;
                for (int i = 0; i < guna2TabControl1.TabPages.Count; i++)
                {
                    Rectangle tabRect = guna2TabControl1.GetTabRect(i);
                    if (tabRect.Contains(me.Location))
                    {
                        WindowTopMostSet.RemoveApplicationTopmost();
                        string newTabName = Microsoft.VisualBasic.Interaction.InputBox("Enter New Name for: " + guna2TabControl1.TabPages[i].Text, "Rename Tab", guna2TabControl1.TabPages[i].Text);
                        if (!string.IsNullOrEmpty(newTabName))
                        {
                            guna2TabControl1.TabPages[i].Text = newTabName;
                            SaveTabs();
                        }
                        if (IsTopmost)
                        {
                            WindowTopMostSet.SetApplicationTopmost();
                        }
                        break;
                    }
                }
            }

            private void TimerElapsed(object sender, ElapsedEventArgs e) // Every 5 seconds, save tabs
            {
                this.Invoke(new Action(() => SaveTabs()));
            }

            private void KillRoblox_Click(object sender, EventArgs e) // Kill Roblox Button
            {
                if (ChosenAPI == "QuorumAPI")
                {
                QuorumAPI.QuorumAPI.KillRoblox();
                }
                if (ChosenAPI == "OSSAPI")
                {
                OSSApi.Api.KillRoblox();
                }
                if (ChosenAPI == "SpashAPI")
                {
                    SpashAPIXeno.SpashAPIXeno.KillRoblox();
                }

            }
        }

        public class TabInfo // Tab Info Json Definiton
        {
            public string Name { get; set; }
            public string Content { get; set; }
        }

        public class TabSaver // Class for saving tabs but bigger
        {
            public Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;

            public TabSaver(Guna.UI2.WinForms.Guna2TabControl tabControl)
            {
                guna2TabControl1 = tabControl;
            }
        private async Task EnsureWebView2InitializedAsync(Microsoft.Web.WebView2.WinForms.WebView2 webView)
        {
            if (webView.CoreWebView2 == null)
            {
                try
                {
                    // Ensure WebView2 is initialized before accessing CoreWebView2
                    await webView.EnsureCoreWebView2Async();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error initializing WebView2: {ex.Message}");
                    // Handle initialization error (optional)
                }
            }
        }

        public async Task SaveTabsAsync(string filePath) // Save tabs to json
        {
            List<TabInfo> tabInfos = new List<TabInfo>();

            for (int i = 0; i < guna2TabControl1.TabCount; i++)
            {
                var tabPage = guna2TabControl1.TabPages[i];
                string tabName = tabPage.Text;
                Microsoft.Web.WebView2.WinForms.WebView2 webView = tabPage.Controls[0] as Microsoft.Web.WebView2.WinForms.WebView2;

                if (webView != null)
                {
                    // Ensure WebView2 is initialized before attempting to execute any script
                    await EnsureWebView2InitializedAsync(webView);

                    string tabContent = await GetTabContentAsync(webView);
                    tabInfos.Add(new TabInfo { Name = tabName, Content = tabContent });
                }
            }

            string json = JsonConvert.SerializeObject(tabInfos, Formatting.Indented);
            System.IO.File.WriteAllText(filePath, json);
        }


        private async Task<string> GetTabContentAsync(Microsoft.Web.WebView2.WinForms.WebView2 webView)
        {
            if (webView != null)
            {
                try
                {
                    // Ensure CoreWebView2 is initialized
                    await EnsureWebView2InitializedAsync(webView);

                    // Execute the script to get the tab content from WebView2
                    return await webView.ExecuteScriptAsync("GetText();");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error getting tab content: {ex.Message}");
                    return string.Empty; // Return empty if there's an error
                }
            }
            return string.Empty;
        }
    }

        public static class WindowTopMostSet // Set topmost window class
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
    }
