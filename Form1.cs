using System;
using System.IO;

//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstGUI
{
    public partial class UsbFormatterForm : Form
    {
        public UsbFormatterForm()
        {
            InitializeComponent();
        }

        private void UsbFormatterForm_Load(object sender, EventArgs e)
        {
            // Get all drives
            foreach (var drive in DriveInfo.GetDrives())
            {
                if (drive.DriveType == DriveType.Removable)
                {
                    double sizeGB = drive.TotalSize / (1024.0 * 1024 * 1024);
                    comboDrives.Items.Add($"{drive.Name} ({sizeGB:F1} GB)");
                }
            }

            if (comboDrives.Items.Count > 0)
                comboDrives.SelectedIndex = 0;

            comboFsType.SelectedIndex = 0;
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            string drive = comboDrives.SelectedItem.ToString().Split(' ')[0].TrimEnd('\\'); // stop at 1st space, e.g. E:
            string fsType = comboFsType.SelectedItem.ToString();

            // Confirmation
            var confirm = MessageBox.Show(
                $"This will EARASE ALL DATA on {drive}.\nFormat as {fsType}?",
                "Confirm Format",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                if (comboDrives.SelectedItem == null || comboFsType.SelectedItem == null)
                {
                    MessageBox.Show(
                        "Please select a drive and file system type.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                statusLabel.Text = $"Formatting {drive} as {fsType}...";
                progressBar.Value = 0;

                try
                {
                    // Build format command
                    var psi = new System.Diagnostics.ProcessStartInfo("format.com")
                    {
                        Arguments = $"{drive} /FS:{fsType} /Q /Y",
                        CreateNoWindow = true,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true
                    };

                    using (var proc = System.Diagnostics.Process.Start(psi))
                    {
                        // Simulate progress bar
                        while (!proc.HasExited)
                        {
                            if (progressBar.Value < 90)
                                progressBar.Value += 5;
                            System.Threading.Thread.Sleep(300);
                        }

                        progressBar.Value = 100;

                        string output = proc.StandardOutput.ReadToEnd();
                        string error = proc.StandardError.ReadToEnd();

                        if (proc.ExitCode == 0)
                        {
                            MessageBox.Show(
                                $"Drive {drive} formatted as {fsType}.",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );

                            statusLabel.Text = "Ready";
                        }
                        else
                        {
                            MessageBox.Show(
                                $"Format failed!\n{error}\n{output}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );

                            statusLabel.Text = "Error";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Exception: {ex.Message}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    statusLabel.Text = "Error";
                }
            }
        }
    }
}
