using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace UniversityApp
{
    public partial class SettingsForm : Form
    {
        private string settingsFilePath;

        public event Action<string, string> SettingsChanged;

        public SettingsForm()
        {
            InitializeComponent();
            settingsFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "settings.json");
            EnsureFileExists(settingsFilePath);
            LoadSettings();
        }

        private void LoadSettings()
        {
            string json = File.ReadAllText(settingsFilePath);
            var settings = JsonConvert.DeserializeObject<AppSettings>(json) ?? new AppSettings();

            if (settings.DarkMode)
            {
                radioButtonDarkMode.Checked = true;
            }
            else
            {
                radioButtonLightMode.Checked = true;
            }

            switch (settings.TextSize)
            {
                case "Small":
                    radioButtonSmall.Checked = true;
                    break;
                case "Medium":
                    radioButtonMedium.Checked = true;
                    break;
            }
        }

        private void SaveSettings()
        {
            var settings = new AppSettings
            {
                DarkMode = radioButtonDarkMode.Checked,
                TextSize = radioButtonSmall.Checked ? "Small" : "Medium"
            };

            string json = JsonConvert.SerializeObject(settings, Formatting.Indented);
            File.WriteAllText(settingsFilePath, json);

            SettingsChanged?.Invoke(settings.DarkMode ? "Dark" : "Light", settings.TextSize);
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            SaveSettings();
            MessageBox.Show("Settings applied successfully.");
        }

        private void EnsureFileExists(string path)
        {
            string directoryPath = Path.GetDirectoryName(path);
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            if (!File.Exists(path))
            {
                File.WriteAllText(path, "{}");
            }
        }
    }

   
}
