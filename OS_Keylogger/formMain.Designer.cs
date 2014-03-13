namespace OS_Keylogger
{
    partial class formMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearCurrentLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCurrentLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runStealthLoggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KeyGenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMain = new System.Windows.Forms.TextBox();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnConfigure = new System.Windows.Forms.Button();
            this.dialogOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.dialogSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.runToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(657, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newLogToolStripMenuItem,
            this.openToolStripMenuItem,
            this.clearCurrentLogToolStripMenuItem,
            this.deleteCurrentLogToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newLogToolStripMenuItem
            // 
            this.newLogToolStripMenuItem.Name = "newLogToolStripMenuItem";
            this.newLogToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.newLogToolStripMenuItem.Text = "New Log";
            this.newLogToolStripMenuItem.Click += new System.EventHandler(this.newLogToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.openToolStripMenuItem.Text = "Open Log";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // clearCurrentLogToolStripMenuItem
            // 
            this.clearCurrentLogToolStripMenuItem.Name = "clearCurrentLogToolStripMenuItem";
            this.clearCurrentLogToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.clearCurrentLogToolStripMenuItem.Text = "Clear Current Log";
            this.clearCurrentLogToolStripMenuItem.Click += new System.EventHandler(this.clearCurrentLogToolStripMenuItem_Click);
            // 
            // deleteCurrentLogToolStripMenuItem
            // 
            this.deleteCurrentLogToolStripMenuItem.Name = "deleteCurrentLogToolStripMenuItem";
            this.deleteCurrentLogToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.deleteCurrentLogToolStripMenuItem.Text = "Delete Current Log";
            this.deleteCurrentLogToolStripMenuItem.Click += new System.EventHandler(this.deleteCurrentLogToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.saveToolStripMenuItem.Text = "Save As";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runStealthLoggerToolStripMenuItem,
            this.KeyGenToolStripMenuItem});
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.runToolStripMenuItem.Text = "Run";
            // 
            // runStealthLoggerToolStripMenuItem
            // 
            this.runStealthLoggerToolStripMenuItem.Name = "runStealthLoggerToolStripMenuItem";
            this.runStealthLoggerToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.runStealthLoggerToolStripMenuItem.Text = "Run Stealth Logger";
            this.runStealthLoggerToolStripMenuItem.Click += new System.EventHandler(this.runStealthLoggerToolStripMenuItem_Click);
            // 
            // KeyGenToolStripMenuItem
            // 
            this.KeyGenToolStripMenuItem.Name = "KeyGenToolStripMenuItem";
            this.KeyGenToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.KeyGenToolStripMenuItem.Text = "KeyGen (Developer)";
            this.KeyGenToolStripMenuItem.Click += new System.EventHandler(this.KeyGenToolStripMenuItem_Click_1);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configureToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.configureToolStripMenuItem.Text = "Configure";
            this.configureToolStripMenuItem.Click += new System.EventHandler(this.configureToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.contentsToolStripMenuItem,
            this.registerToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.contentsToolStripMenuItem.Text = "Contents";
            // 
            // txtMain
            // 
            this.txtMain.HideSelection = false;
            this.txtMain.Location = new System.Drawing.Point(12, 28);
            this.txtMain.Multiline = true;
            this.txtMain.Name = "txtMain";
            this.txtMain.ReadOnly = true;
            this.txtMain.Size = new System.Drawing.Size(633, 409);
            this.txtMain.TabIndex = 1;
            this.txtMain.Text = "Open or create a log to display.";
            // 
            // txtFind
            // 
            this.txtFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.Location = new System.Drawing.Point(13, 443);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(406, 26);
            this.txtFind.TabIndex = 2;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(426, 443);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(219, 26);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Quick Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(13, 475);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(202, 54);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start Logging";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(222, 475);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(198, 54);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop Logging";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnConfigure
            // 
            this.btnConfigure.Location = new System.Drawing.Point(426, 475);
            this.btnConfigure.Name = "btnConfigure";
            this.btnConfigure.Size = new System.Drawing.Size(219, 54);
            this.btnConfigure.TabIndex = 6;
            this.btnConfigure.Text = "Configure";
            this.btnConfigure.UseVisualStyleBackColor = true;
            this.btnConfigure.Click += new System.EventHandler(this.btnConfigure_Click);
            // 
            // dialogOpenFile
            // 
            this.dialogOpenFile.DefaultExt = "log";
            this.dialogOpenFile.Title = "Select a Log File";
            // 
            // dialogSaveFile
            // 
            this.dialogSaveFile.DefaultExt = "log";
            this.dialogSaveFile.Title = "Save Log";
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 550);
            this.Controls.Add(this.btnConfigure);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.txtMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formMain";
            this.Text = "OS Keylogger";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TextBox txtMain;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnConfigure;
        private System.Windows.Forms.OpenFileDialog dialogOpenFile;
        private System.Windows.Forms.ToolStripMenuItem clearCurrentLogToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog dialogSaveFile;
        private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCurrentLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runStealthLoggerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KeyGenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
    }
}

