namespace H800_Controls
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusLabel = new System.Windows.Forms.Label();
            this.currentAssignmentText = new System.Windows.Forms.TextBox();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openStatusWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsModeChk = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pressedLabel = new System.Windows.Forms.Label();
            this.notifyMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(119, 9);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(35, 13);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "label1";
            // 
            // currentAssignmentText
            // 
            this.currentAssignmentText.Location = new System.Drawing.Point(156, 139);
            this.currentAssignmentText.Name = "currentAssignmentText";
            this.currentAssignmentText.Size = new System.Drawing.Size(100, 20);
            this.currentAssignmentText.TabIndex = 2;
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.notifyMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Logitech H800 Controller";
            this.trayIcon.Visible = true;
            this.trayIcon.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // notifyMenu
            // 
            this.notifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusMenuItem,
            this.toolStripSeparator1,
            this.openStatusWindowToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.notifyMenu.Name = "notifyMenu";
            this.notifyMenu.Size = new System.Drawing.Size(147, 76);
            // 
            // statusMenuItem
            // 
            this.statusMenuItem.Name = "statusMenuItem";
            this.statusMenuItem.Size = new System.Drawing.Size(146, 22);
            this.statusMenuItem.Text = "Disconnected";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // openStatusWindowToolStripMenuItem
            // 
            this.openStatusWindowToolStripMenuItem.Name = "openStatusWindowToolStripMenuItem";
            this.openStatusWindowToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openStatusWindowToolStripMenuItem.Text = "Settings";
            this.openStatusWindowToolStripMenuItem.Click += new System.EventHandler(this.openStatusWindowToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsModeChk
            // 
            this.settingsModeChk.Appearance = System.Windows.Forms.Appearance.Button;
            this.settingsModeChk.AutoSize = true;
            this.settingsModeChk.Location = new System.Drawing.Point(70, 42);
            this.settingsModeChk.Name = "settingsModeChk";
            this.settingsModeChk.Size = new System.Drawing.Size(137, 23);
            this.settingsModeChk.TabIndex = 3;
            this.settingsModeChk.Text = "Change Key Assignments";
            this.settingsModeChk.UseVisualStyleBackColor = true;
            this.settingsModeChk.CheckedChanged += new System.EventHandler(this.settingsModeChk_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pressed Key: ";
            // 
            // pressedLabel
            // 
            this.pressedLabel.AutoSize = true;
            this.pressedLabel.Location = new System.Drawing.Point(90, 142);
            this.pressedLabel.Name = "pressedLabel";
            this.pressedLabel.Size = new System.Drawing.Size(0, 13);
            this.pressedLabel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.pressedLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.settingsModeChk);
            this.Controls.Add(this.currentAssignmentText);
            this.Controls.Add(this.statusLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logitech H800 Controller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.notifyMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox currentAssignmentText;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip notifyMenu;
        private System.Windows.Forms.ToolStripMenuItem statusMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem openStatusWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.CheckBox settingsModeChk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pressedLabel;
    }
}

