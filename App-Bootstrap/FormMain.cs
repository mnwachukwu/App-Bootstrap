using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AppBootstrap
{
    public partial class FormMain : Form
    {
        private int processStarts;

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, System.EventArgs e)
        {
            using var dialog = new OpenFileDialog();

            dialog.Title = "Select App to Bootstrap";
            dialog.Filter = "Applications|*.exe";
            dialog.InitialDirectory = textBoxFilePath.Text;

            var dialogResult = dialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                textBoxFilePath.Text = dialog.FileName;
                textBoxProcessName.Text = Path.GetFileName(dialog.FileName).Split('.')[0];
            }
        }

        private void buttonStart_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFilePath.Text))
            {
                MessageBox.Show("File Path can't be empty.", "App Bootstrap");
                return;
            }

            if (!File.Exists(textBoxFilePath.Text))
            {
                MessageBox.Show("You can't bootstrap a file that doesn't exist.", "App Bootstrap");
                return;
            }

            if (!textBoxFilePath.Text.EndsWith(".exe"))
            {
                MessageBox.Show("You can only bootstrap an application.", "App Bootstrap");
                return;
            }

            StartBootstrapping();
        }

        private void buttonStop_Click(object sender, System.EventArgs e)
        {
            StopBootstrapping();
        }

        private void timerMain_Tick(object sender, System.EventArgs e)
        {
            var processes = Process.GetProcessesByName(textBoxProcessName.Text);

            if (!processes.Any())
            {
                var startInfo = new ProcessStartInfo(textBoxFilePath.Text)
                {
                    WorkingDirectory = Path.GetDirectoryName(textBoxFilePath.Text)
                };

                Process.Start(startInfo);
                processStarts++;
                labelStatus.Text = $"Picked itself up by the bootstraps {processStarts} times";
            }
        }

        private void StartBootstrapping()
        {
            labelStatus.Text = "Started";
            buttonStart.Enabled = false;
            buttonStop.Enabled = true;
            textBoxFilePath.Enabled = false;
            textBoxProcessName.Enabled = false;
            buttonOpen.Enabled = false;
            processStarts = 0;
            timerMain.Start();
        }

        private void StopBootstrapping()
        {
            timerMain.Stop();
            labelStatus.Text = "Stopped";
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
            textBoxFilePath.Enabled = true;
            textBoxProcessName.Enabled = true;
            buttonOpen.Enabled = true;
        }
    }
}
