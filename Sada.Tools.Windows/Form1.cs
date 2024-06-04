using System;
using System.Diagnostics;

namespace Sada.Tools.Windows
{
    public partial class Form1 : Form
    {
        private readonly string USERSECRETS = "user-secrets";

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
    }
}
