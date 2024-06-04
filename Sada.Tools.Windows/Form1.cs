using Sada.Tools.Windows.AppSettings;
using System;
using System.Diagnostics;
using System.Text.Json;

namespace Sada.Tools.Windows
{
    public partial class Form1 : Form
    {
        private readonly string USERSECRETS = "user-secrets";
        private AppSettingsModel model;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.InitialDirectory = Environment.CurrentDirectory;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = dialog.SelectedPath;
            }
        }

        private void btnInitSecrets_Click(object sender, EventArgs e)
        {
            if (txtPath.Text != "")
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "dotnet";
                startInfo.Arguments = USERSECRETS + " init";
                startInfo.CreateNoWindow = true;
                startInfo.RedirectStandardOutput = true;
                startInfo.WorkingDirectory = txtPath.Text;
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
                MessageBox.Show(process.StandardOutput.ReadToEnd(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gbInsert.Enabled = true;
            }
            else
            {
                MessageBox.Show("Startup Project is not Defined.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtKey.Text) || string.IsNullOrEmpty(txtValue.Text)))
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "dotnet";
                startInfo.Arguments = USERSECRETS + " set " + "\"" + txtKey.Text + "\" \"" + txtValue.Text + "\"";
                startInfo.CreateNoWindow = true;
                startInfo.RedirectStandardOutput = true;
                startInfo.WorkingDirectory = txtPath.Text;
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
                MessageBox.Show(process.StandardOutput.ReadToEnd(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Key or Value is Empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowseJson_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Multiselect = false;
                dialog.InitialDirectory = Environment.CurrentDirectory;
                dialog.Filter = "AppSettings file(*.json)|*.json";
                dialog.DefaultExt = "*.json";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtJsonPath.Text = dialog.FileName;

                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtJsonPath.Text))
            {
                string jsonString = File.ReadAllText(txtJsonPath.Text);
                var settings = JsonSerializer.Deserialize<AppSettingsModel>(jsonString);
                model = settings;
                if (settings != null)
                {
                    txtKeyJWT.Text = settings.Jwt.Key;
                    txtIssuer.Text = settings.Jwt.Issuer;
                    txtAudience.Text = settings.Jwt.Audience;
                }
            }
        }

        private void btnInsertJWT_Click(object sender, EventArgs e)
        {
            AppSettingsModel appSettings = new AppSettingsModel();
            appSettings.Logging = new Logging()
            {
                LogLevel = new LogLevel()
                {
                    Default = model.Logging.LogLevel.Default,
                    MicrosoftAspNetCore = model.Logging.LogLevel.MicrosoftAspNetCore
                }
            };
            appSettings.AllowedHosts = model.AllowedHosts;
            appSettings.Jwt = new JWT()
            {
                Key = txtKeyJWT.Text,
                Issuer = txtIssuer.Text,
                Audience = txtAudience.Text
            };
            string jsonString = JsonSerializer.Serialize<AppSettingsModel>(appSettings);
            File.WriteAllText(txtJsonPath.Text, jsonString);
        }
    }
}
