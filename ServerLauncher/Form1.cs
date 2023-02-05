using ServerLauncher.Properties;

namespace ServerLauncher
{
    public partial class Form1 : Form
    {
        private List<ProcessCheck> _checks = new ();

        public Form1()
        {
            InitializeComponent();
            _checks.Add(new ProcessCheck("dev_", devShowStatus, devStart, new []{ devShutdown, devKill}));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            devPathDialog.InitialDirectory = Settings.Default.dev_executablePath;
            devPathDialog.FileName = "altv-server.exe";
            devPath.Text = Settings.Default.dev_executablePath;
            devAutoRestart.Checked = Settings.Default.dev_automaticRestart;
            devRestartTime.Value = Settings.Default.dev_automaticRestartTime;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            devPathDialog.InitialDirectory = Settings.Default.dev_executablePath;
            devPathDialog.FileName = "altv-server.exe";
            devPathDialog.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            devPath.Text = devPathDialog.FileName;
            Settings.Default.dev_executablePath = devPathDialog.FileName;
            Settings.Default.Save();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = !this.Visible;
            if (this.Visible)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                this.BringToFront();
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Visible = false;
            }
        }

        private void devAutoRestart_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.dev_automaticRestart = devAutoRestart.Checked;
            Settings.Default.Save();
        }

        private void devRestartTime_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default.dev_automaticRestartTime = Decimal.ToInt32(devRestartTime.Value);
            Settings.Default.Save();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            _checks.ForEach((check => check.Dispose()));
        }

        private void devShutdown_Click(object sender, EventArgs e)
        {
            ProcessCheck.ShutDownProcess(Settings.Default.dev_executablePath, false);
        }

        private void devKill_Click(object sender, EventArgs e)
        {
            ProcessCheck.ShutDownProcess(Settings.Default.dev_executablePath, true);
        }

        private void devStart_Click(object sender, EventArgs e)
        {
            ProcessCheck.StartProcess(Settings.Default.dev_executablePath);
        }
    }
}