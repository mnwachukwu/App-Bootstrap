using System.Drawing;
using System.Windows.Forms;

namespace AppBootstrap
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            textBoxFilePath = new TextBox();
            groupBox1 = new GroupBox();
            buttonOpen = new Button();
            groupBox2 = new GroupBox();
            textBoxProcessName = new TextBox();
            timerMain = new Timer(components);
            buttonStart = new Button();
            buttonStop = new Button();
            labelStatus = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxFilePath
            // 
            textBoxFilePath.Location = new Point(6, 22);
            textBoxFilePath.Name = "textBoxFilePath";
            textBoxFilePath.Size = new Size(697, 23);
            textBoxFilePath.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonOpen);
            groupBox1.Controls.Add(textBoxFilePath);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(760, 60);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "File Path to Executable";
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(709, 22);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(45, 23);
            buttonOpen.TabIndex = 2;
            buttonOpen.Text = "Open";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxProcessName);
            groupBox2.Location = new Point(12, 78);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(760, 60);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Process Name";
            // 
            // textBoxProcessName
            // 
            textBoxProcessName.Location = new Point(6, 22);
            textBoxProcessName.Name = "textBoxProcessName";
            textBoxProcessName.Size = new Size(748, 23);
            textBoxProcessName.TabIndex = 1;
            // 
            // timerMain
            // 
            timerMain.Interval = 1000;
            timerMain.Tick += timerMain_Tick;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(526, 176);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(120, 23);
            buttonStart.TabIndex = 4;
            buttonStart.Text = "Start Bootstrapping";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonStop
            // 
            buttonStop.Enabled = false;
            buttonStop.Location = new Point(652, 176);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(120, 23);
            buttonStop.TabIndex = 5;
            buttonStop.Text = "Stop Bootstrapping";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(12, 180);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(51, 15);
            labelStatus.TabIndex = 6;
            labelStatus.Text = "Stopped";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 211);
            Controls.Add(labelStatus);
            Controls.Add(buttonStop);
            Controls.Add(buttonStart);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "App Bootstrap";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFilePath;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBoxProcessName;
        private System.Windows.Forms.Timer timerMain;
        private Button buttonStart;
        private Button buttonStop;
        private Label labelStatus;
        private Button buttonOpen;
    }
}
