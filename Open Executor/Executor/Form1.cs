using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Newtonsoft.Json;
using DiscordRPC;
using DiscordRPC.Logging;
using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace executor
{
    public partial class MainUI : Form
    {

        private AppSettings _settings;
        public Guna2Panel overlayPanel;
        private Form _currentForm;
        Timestamps timestamps;
        const string InfoUrl = "https://pastebin.com/raw/3cdzkmFZ";


        string directoryPath = Path.Combine(Environment.CurrentDirectory, "workspace", "scripts");
        readonly System.Timers.Timer refreshtimer = new System.Timers.Timer(2000);

        public static string GetMemoryUsage()
        {
            var process = Process.GetCurrentProcess();
            return $"{(process.WorkingSet64 / 1024 / 1024)} MB";
        }


        public DiscordRpcClient client;
        private bool IsDiscordRunning()
        {
            foreach (var process in Process.GetProcessesByName("Discord"))
            {
                if (process.ProcessName.Equals("Discord"))
                {
                    return true;
                }
            }
            return false;
        }
        public MainUI()
        {

            // Refreshes List every 2 seconds
            refreshtimer.Elapsed += TimerElapsed;
            refreshtimer.Start();

            InitializeComponent();

            SharedData.dontsave = false;

            _settings = AppSettingsManager.LoadSettings();

            this.BackColor = Color.FromArgb(10, 10, 10);
            this.MinimumSize = new Size(883, 450);
            this.DoubleBuffered = true;

            overlayPanel = new Guna2Panel();
            this.Controls.Add(overlayPanel);
            overlayPanel.FillColor = Color.Transparent;
            overlayPanel.Dock = DockStyle.Fill;
            overlayPanel.Visible = false;
            overlayPanel.UseTransparentBackground = true;
            overlayPanel.BringToFront();

            void Initialize()
            {
                if (!IsDiscordRunning())
                {
                    Console.WriteLine("Starting without Discord RPC");
                    return;
                }

                client = new DiscordRpcClient("1336314005932740668"); //Change to your App ID

                client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };

                client.OnReady += (sender, e) =>
                {
                    Console.WriteLine("Received Ready from user {0}", e.User.Username);
                };


                client.Initialize();
                client.SetPresence(new RichPresence()
                {
                    Details = "Exploiting with Open Executor",
                    State = $"Usage : {GetMemoryUsage()}",
                    Timestamps = Timestamps.Now,
                    Assets = new Assets()
                    {
                        LargeImageKey = "large_image",
                        LargeImageText = "Open Source Softworks",
                    }
                });
                timestamps = Timestamps.Now;
            }
            Initialize();
        }

        void Deinitialize()
        {
            client.Dispose();
        }
        protected override CreateParams CreateParams // Reduce Resize flicker
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Executor exe = new Executor(_settings);
            exe.TopLevel = false;
            exe.Dock = DockStyle.Fill;
            InnerFormBackground.Controls.Add(exe);
            exe.BringToFront();
            exe.Show();
            _currentForm = exe;
            TimerElapsed(null, null);
            CheckVersion();
        }


        private void LoadInForm(string formload)
        {
            if (_currentForm != null)
            {
                if ((formload == "executor" && _currentForm is Executor) ||
                    (formload == "scripthub" && _currentForm is ScriptHub) ||
                    (formload == "settings" && _currentForm is Settings) ||
                    (formload == "home" && _currentForm is Home))

                {
                    return;
                }
            }

            //Dispose the old form.
            DisposeCurrentForm();

            // Load the requested form.
            switch (formload)
            {
                case "executor":
                    LoadExecutorForm();
                    break;
                case "scripthub":
                    LoadScriptHubForm();
                    break;
                case "settings":
                    LoadSettingsForm();
                    break;
                case "home":
                    LoadHomeForm();
                    break;
                default:
                    // Optional: Log an error or throw an exception for unknown form names
                    Console.WriteLine($"Unknown Form Type: {formload}");
                    break;
            }
        }

        // Helper methods to encapsulate loading each form type.
        private async void DisposeCurrentForm()
        {
            // If theres no forms, return
            if (_currentForm == null) return;

            // Make sure executor is saved before disposing
            if (_currentForm is Executor executor)
            {
                SharedData.dontsave = true; // Don't save while disposing
                executor.SaveTabs();
                executor.savetimer?.Stop();
                executor.savetimer?.Dispose();
                executor.time?.Stop();
                executor.time?.Dispose();
                InnerFormBackground.Controls.Remove(executor);

                await Task.Delay(200);

                executor.Dispose();
                _currentForm = null;
                SharedData.dontsave = false;
                return;
            }

            // Remove form from background
            else if (_currentForm is Form form)
            {
                InnerFormBackground.Controls.Remove(form);
            }

            // If there is a form, dispose it
            if (_currentForm != null)
            {
                _currentForm.Dispose();
                _currentForm = null;
            }

        }
        private async Task EnsureWebView2InitializedAsync(Microsoft.Web.WebView2.WinForms.WebView2 webView)
{
    try
    {
        if (webView != null)
        {
            // This will ensure that WebView2 is initialized before performing any operations on it.
            await webView.EnsureCoreWebView2Async();
            Console.WriteLine("WebView2 is initialized.");
        }
    }
    catch (Exception ex)
    {
        // Handle any exceptions that may occur during initialization
        Console.WriteLine($"Error initializing WebView2: {ex.Message}");
    }
}

        private async void LoadExecutorForm()
        {
            tabLabel.Text = ("Editor");
            scripthubButton.Image = executor.Properties.Resources.script2;
            editorButton.Image = executor.Properties.Resources.EDITOR;
            homeButton.Image = executor.Properties.Resources.home2;
            editorButton_Panel.Visible = true;
            homeButton_Panel.Visible = false;
            scripthubButton_Panel.Visible = false;
            settingsButton_Panel.Visible = false;

            if (SharedData.dontsave == false)
            {
                Executor executor = new Executor(_settings);

                LoadForm(executor);

                // Load the tabs asynchronously after the form is initialized
                await LoadTabsAsync(executor);
            }
        }
        private async Task LoadTabsAsync(Executor executor)
        {
            await Task.Delay(500); 

            this.Invoke(new Action(() =>
            {
            }));
        }

        private void LoadScriptHubForm()
        {
            tabLabel.Text = ("Script Hub");
            scripthubButton.Image = executor.Properties.Resources.script;
            editorButton.Image = executor.Properties.Resources.EDITOR2;
            homeButton.Image = executor.Properties.Resources.home2;
            scripthubButton_Panel.Visible = true;
            homeButton_Panel.Visible = false;
            editorButton_Panel.Visible = false;
            settingsButton_Panel.Visible = false;
            ScriptHub scripthub = new ScriptHub();
            LoadForm(scripthub);
        }

        private void LoadSettingsForm()
        {
            tabLabel.Text = ("Settings");
            settingsButton_Panel.Visible = true;
            homeButton_Panel.Visible = false;
            editorButton_Panel.Visible = false;
            scripthubButton_Panel.Visible = false;
            Settings settings = new Settings(_settings);
            LoadForm(settings);
        }

        private void LoadHomeForm()
        {
            tabLabel.Text = ("Home");
            homeButton.Image = executor.Properties.Resources.home;
            editorButton.Image = executor.Properties.Resources.EDITOR2;
            scripthubButton.Image = executor.Properties.Resources.script2;
            editorButton_Panel.Visible = false;
            homeButton_Panel.Visible = true;
            scripthubButton_Panel.Visible = false;
            settingsButton_Panel.Visible = false;
            Home home = new Home();  
            LoadForm(home);
        }

        private async void CheckVersion()
        {
            string info = await HttpGet(InfoUrl);
            var infoJson = JObject.Parse(info);
            string localVersion = "1.2.0"; // Local Version

            if (localVersion != infoJson["SoftwareVersion"]?.ToString())
            {
                MessageBox.Show("Current version: " + localVersion +". Please download version " + infoJson["SoftwareVersion"] + " via Bootstrapper.", "Version Checker | Open Executor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        static async Task<string> HttpGet(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    return await client.GetStringAsync(url);
                }
                catch
                {
                    return string.Empty;
                }
            }
        }

        // Load in the form
        private void LoadForm(Form form)
        {
            _currentForm = form;

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            InnerFormBackground.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void Close_Func(object sender, EventArgs e)
        {
            Executor executorForm = Application.OpenForms["Executor"] as Executor;


            if (executorForm != null)
            {

                executorForm.SaveTabs();
                Task.Delay(200).ContinueWith((t) =>
                {
                    Task.Run(async () =>
                    {
                        while (SharedData.dontsave == true || executorForm.tabsloaded == false)
                        {
                            await Task.Delay(10);
                        }

                        this.Invoke(new Action(() =>
                        {
                            Close();
                            Deinitialize();
                        }));
                    });
                });
            }
            else
            {
                Close();
                Deinitialize();
            }
        }

        private void Minimize_Func(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void LoadSettings_Func(object sender, EventArgs e)
        {
            LoadInForm("settings");
        }
        

        private void LoadScriptHub_Func(object sender, EventArgs e)
        {
            LoadInForm("scripthub");
        }

        private void LoadEditor_Func(object sender, EventArgs e)
        {
            LoadInForm("executor");
        }

        private void LoadHome_Funcs(object sender, EventArgs e)
        {
            LoadInForm("home");
        }


        private string currentSearchText = "";

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                // Populate the listbox with the current search text
                PopulateListBox(listBox1, directoryPath, currentSearchText, "lua", "txt");
            }));
        }



        public static void PopulateListBox(ListBox lsb, string folder, string searchText = "", params string[] filetypes)
        {
            DirectoryInfo dinfo = new DirectoryInfo(folder);
            FileInfo[] files = filetypes.SelectMany(ft => dinfo.GetFiles($"*.{ft}")).ToArray();

            if (!string.IsNullOrEmpty(searchText))
            {
                files = files.Where(f => f.Name.ToLower().Contains(searchText.ToLower())).ToArray();
            }

            var newFileNames = files.Select(file => file.Name).ToArray();

            // Only update the list if the items are different
            if (!newFileNames.SequenceEqual(lsb.Items.Cast<string>()))
            {
                lsb.Items.Clear();
                lsb.Items.AddRange(newFileNames);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedItem = File.ReadAllText(Path.Combine(directoryPath, listBox1.SelectedItem.ToString()));

                foreach (Form form in Application.OpenForms)
                {
                    if (form is Executor executor)
                    {
                        executor.LoadIntoCurrentTab(selectedItem);
                    }
                }
            }
        }

        private void OpenDirectory_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(directoryPath))
            {
                Process.Start("explorer.exe", directoryPath);
            }
            else
            {
                Directory.CreateDirectory(directoryPath);
                Process.Start("explorer.exe", directoryPath);
            }
        }



        private async void Form1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (filePaths.Length > 0)
                {
                    string filePath = filePaths[0];
                    try
                    {
                        string fileContent = File.ReadAllText(filePath);
                        string jsonContent = JsonConvert.SerializeObject(fileContent);
                        foreach (Form form in Application.OpenForms)
                        {
                            if (form is Executor executor)
                            {
                                overlayPanel.Visible = false;
                                Microsoft.Web.WebView2.WinForms.WebView2 webView2 = (Microsoft.Web.WebView2.WinForms.WebView2)executor.guna2TabControl1.SelectedTab.Controls[0];
                                await webView2.CoreWebView2.ExecuteScriptAsync($"editor.setValue({jsonContent});");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error reading file: {ex.Message}");
                    }
                }
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            {
                overlayPanel.Visible = true;
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    e.Effect = DragDropEffects.Copy;  // Allow copy operation
                }
                else
                {
                    e.Effect = DragDropEffects.None;  // Reject non-file data
                }
            }
        }

        private void Form1_DragLeave(object sender, EventArgs e)
        {
            overlayPanel.Visible = false;
        }

        private void OnFormClose(object sender, FormClosingEventArgs e)
        {
            timer2.Stop();
            timer2.Dispose();
            refreshtimer.Stop();
            refreshtimer.Dispose();
            Deinitialize();
            overlayPanel.Dispose();

        }



        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {
            // Update the current search text when the user types in the search box
            currentSearchText = searchBox.Text.ToLower();

            // Populate the list with the current search text
            PopulateListBox(listBox1, directoryPath, currentSearchText, "lua", "txt");
        }

        private void timer1_Tick(object sender, EventArgs e) // Startup Animation
        {
            Opacity += .2; // Gradually increase opacity

            if (Opacity >= 1) 
            {
                timer1.Stop();
                timer1.Dispose();
            }
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e) // Updates Discord RPC
        {
            client.SetPresence(new RichPresence()
            {
                Details = "Exploiting with Open Executor",
                State = $"Usage : {GetMemoryUsage()}",
                Timestamps = Timestamps.Now,
                Assets = new Assets()
                {
                    LargeImageKey = "large_image",
                    LargeImageText = "Open Source Softworks",
                }
            });
        }
    }

    public static class SharedData
    {
        public static bool dontsave { get; set; }
    }

    public class AppSettings
    {
        [JsonProperty("istopmost")]
        public bool IsTopmost { get; set; }

        [JsonProperty("hasconfirm")]
        public bool DisableConfirm { get; set; }

        [JsonProperty("chosenapi")]
        public string ChosenApi { get; set; }

        [JsonProperty("minimaptoggle")]
        public bool MinimapToggle { get; set; }
    }

        
    public static class AppSettingsManager
    {
        private static string localAppDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "OpenSourceExecutor");
        private static readonly string FilePath = Path.Combine(localAppDataPath, "settings.json");

        public static AppSettings LoadSettings()
        {
            if (!File.Exists(FilePath))
            {
                // If no file, create the settings folder if it doesn't exists
                if (!Directory.Exists(localAppDataPath))
                {
                    Directory.CreateDirectory(localAppDataPath);
                }
                // Create a default settings object if none is found
                return new AppSettings() { IsTopmost = false, DisableConfirm = true, ChosenApi = "QuroumAPI", MinimapToggle = true };
            }

            try
            {
                string json = File.ReadAllText(FilePath);
                return JsonConvert.DeserializeObject<AppSettings>(json);
            }
            catch (Exception)
            {
                // Handle error reading file
                return new AppSettings() { IsTopmost = false, DisableConfirm = true, ChosenApi = "ratapi", MinimapToggle = true };
            }
        }

        public static void SaveSettings(AppSettings settings)
        {
            // If no folder, create it first
            if (!Directory.Exists(localAppDataPath))
            {
                Directory.CreateDirectory(localAppDataPath);
            }
            try
            {
                string json = JsonConvert.SerializeObject(settings, Formatting.Indented);
                File.WriteAllText(FilePath, json);
            }
            catch (Exception ex)
            {
                // Handle error saving (optional: Log or show message)
                Console.WriteLine($"Error saving settings: {ex.Message}");
            }

        }

    }

}
