namespace ServerLauncher
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.devStart = new System.Windows.Forms.Button();
            this.devKill = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.devShutdown = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.devRestartTime = new System.Windows.Forms.NumericUpDown();
            this.devAutoRestart = new System.Windows.Forms.CheckBox();
            this.devShowStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.devPath = new System.Windows.Forms.Label();
            this.selectDevPath = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.devPathDialog = new System.Windows.Forms.OpenFileDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devRestartTime)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.devStart);
            this.tabPage1.Controls.Add(this.devKill);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.devShutdown);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.devRestartTime);
            this.tabPage1.Controls.Add(this.devAutoRestart);
            this.tabPage1.Controls.Add(this.devShowStatus);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.devPath);
            this.tabPage1.Controls.Add(this.selectDevPath);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(504, 161);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dev-Server";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // devStart
            // 
            this.devStart.Enabled = false;
            this.devStart.Location = new System.Drawing.Point(178, 113);
            this.devStart.Name = "devStart";
            this.devStart.Size = new System.Drawing.Size(85, 23);
            this.devStart.TabIndex = 10;
            this.devStart.Text = "Start Server";
            this.devStart.UseVisualStyleBackColor = true;
            this.devStart.Click += new System.EventHandler(this.devStart_Click);
            // 
            // devKill
            // 
            this.devKill.Enabled = false;
            this.devKill.Location = new System.Drawing.Point(87, 113);
            this.devKill.Name = "devKill";
            this.devKill.Size = new System.Drawing.Size(85, 23);
            this.devKill.TabIndex = 9;
            this.devKill.Text = "Kill Server";
            this.devKill.UseVisualStyleBackColor = true;
            this.devKill.Click += new System.EventHandler(this.devKill_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Manual Options:";
            // 
            // devShutdown
            // 
            this.devShutdown.Enabled = false;
            this.devShutdown.Location = new System.Drawing.Point(6, 113);
            this.devShutdown.Name = "devShutdown";
            this.devShutdown.Size = new System.Drawing.Size(75, 23);
            this.devShutdown.TabIndex = 7;
            this.devShutdown.Text = "Shutdown";
            this.devShutdown.UseVisualStyleBackColor = true;
            this.devShutdown.Click += new System.EventHandler(this.devShutdown_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Minutes";
            // 
            // devRestartTime
            // 
            this.devRestartTime.Location = new System.Drawing.Point(217, 64);
            this.devRestartTime.Name = "devRestartTime";
            this.devRestartTime.Size = new System.Drawing.Size(39, 23);
            this.devRestartTime.TabIndex = 5;
            this.devRestartTime.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.devRestartTime.ValueChanged += new System.EventHandler(this.devRestartTime_ValueChanged);
            // 
            // devAutoRestart
            // 
            this.devAutoRestart.AutoSize = true;
            this.devAutoRestart.Location = new System.Drawing.Point(8, 65);
            this.devAutoRestart.Name = "devAutoRestart";
            this.devAutoRestart.Size = new System.Drawing.Size(203, 19);
            this.devAutoRestart.TabIndex = 4;
            this.devAutoRestart.Text = "Automatically Restart Server After";
            this.devAutoRestart.UseVisualStyleBackColor = true;
            this.devAutoRestart.CheckedChanged += new System.EventHandler(this.devAutoRestart_CheckedChanged);
            // 
            // devShowStatus
            // 
            this.devShowStatus.AutoSize = true;
            this.devShowStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.devShowStatus.Location = new System.Drawing.Point(119, 32);
            this.devShowStatus.Name = "devShowStatus";
            this.devShowStatus.Size = new System.Drawing.Size(172, 19);
            this.devShowStatus.TabIndex = 3;
            this.devShowStatus.Text = "Please Select Executable";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Status:";
            // 
            // devPath
            // 
            this.devPath.Location = new System.Drawing.Point(178, 10);
            this.devPath.Name = "devPath";
            this.devPath.Size = new System.Drawing.Size(320, 19);
            this.devPath.TabIndex = 1;
            this.devPath.Text = "Please Select....";
            // 
            // selectDevPath
            // 
            this.selectDevPath.Location = new System.Drawing.Point(6, 6);
            this.selectDevPath.Name = "selectDevPath";
            this.selectDevPath.Size = new System.Drawing.Size(166, 23);
            this.selectDevPath.TabIndex = 0;
            this.selectDevPath.Text = "Select Server Executable";
            this.selectDevPath.UseVisualStyleBackColor = true;
            this.selectDevPath.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(512, 189);
            this.tabControl1.TabIndex = 0;
            // 
            // devPathDialog
            // 
            this.devPathDialog.DefaultExt = "altv-server.exe";
            this.devPathDialog.FileName = "openFileDialog1";
            this.devPathDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "TT-AltV-ServerLauncher";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 189);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TT-AltV-ServerLauncher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devRestartTime)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage tabPage1;
        private Button selectDevPath;
        private TabControl tabControl1;
        private OpenFileDialog devPathDialog;
        private Label devPath;
        private Label label1;
        private Button devStart;
        private Button devKill;
        private Label label3;
        private Button devShutdown;
        private Label label2;
        private NumericUpDown devRestartTime;
        private CheckBox devAutoRestart;
        private Label devShowStatus;
        private NotifyIcon notifyIcon1;
    }
}