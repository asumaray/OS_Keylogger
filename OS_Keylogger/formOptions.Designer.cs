namespace OS_Keylogger
{
    partial class formOptions
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
            this.grpLogOptions = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdioLowercase = new System.Windows.Forms.RadioButton();
            this.rdioUppercase = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmboDelimiter = new System.Windows.Forms.ComboBox();
            this.chkText = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            this.lblHotkey = new System.Windows.Forms.Label();
            this.txtHotkey = new System.Windows.Forms.TextBox();
            this.grpScrenCap = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBrowseScreenDirectory = new System.Windows.Forms.Button();
            this.txtScreenDirectory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkScreenCap = new System.Windows.Forms.CheckBox();
            this.dialogScreenFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.grpLogOptions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpScrenCap.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLogOptions
            // 
            this.grpLogOptions.Controls.Add(this.groupBox1);
            this.grpLogOptions.Controls.Add(this.label1);
            this.grpLogOptions.Controls.Add(this.cmboDelimiter);
            this.grpLogOptions.Controls.Add(this.chkText);
            this.grpLogOptions.Location = new System.Drawing.Point(25, 22);
            this.grpLogOptions.Name = "grpLogOptions";
            this.grpLogOptions.Size = new System.Drawing.Size(327, 122);
            this.grpLogOptions.TabIndex = 0;
            this.grpLogOptions.TabStop = false;
            this.grpLogOptions.Text = "Log Options";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdioLowercase);
            this.groupBox1.Controls.Add(this.rdioUppercase);
            this.groupBox1.Location = new System.Drawing.Point(204, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(96, 70);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Capitalization";
            // 
            // rdioLowercase
            // 
            this.rdioLowercase.AutoSize = true;
            this.rdioLowercase.Location = new System.Drawing.Point(7, 44);
            this.rdioLowercase.Name = "rdioLowercase";
            this.rdioLowercase.Size = new System.Drawing.Size(77, 17);
            this.rdioLowercase.TabIndex = 1;
            this.rdioLowercase.TabStop = true;
            this.rdioLowercase.Text = "Lowercase";
            this.rdioLowercase.UseVisualStyleBackColor = true;
            // 
            // rdioUppercase
            // 
            this.rdioUppercase.AutoSize = true;
            this.rdioUppercase.Location = new System.Drawing.Point(7, 20);
            this.rdioUppercase.Name = "rdioUppercase";
            this.rdioUppercase.Size = new System.Drawing.Size(77, 17);
            this.rdioUppercase.TabIndex = 0;
            this.rdioUppercase.TabStop = true;
            this.rdioUppercase.Text = "Uppercase";
            this.rdioUppercase.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Log Delimiter:";
            // 
            // cmboDelimiter
            // 
            this.cmboDelimiter.FormattingEnabled = true;
            this.cmboDelimiter.Items.AddRange(new object[] {
            "Space",
            "New Line",
            "Comma",
            "None"});
            this.cmboDelimiter.Location = new System.Drawing.Point(24, 78);
            this.cmboDelimiter.Name = "cmboDelimiter";
            this.cmboDelimiter.Size = new System.Drawing.Size(121, 21);
            this.cmboDelimiter.TabIndex = 1;
            // 
            // chkText
            // 
            this.chkText.AutoSize = true;
            this.chkText.Location = new System.Drawing.Point(24, 29);
            this.chkText.Name = "chkText";
            this.chkText.Size = new System.Drawing.Size(77, 17);
            this.chkText.TabIndex = 0;
            this.chkText.Text = "Text Mode";
            this.chkText.UseVisualStyleBackColor = true;
            this.chkText.CheckedChanged += new System.EventHandler(this.chkText_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(135, 348);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(248, 348);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(25, 348);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(104, 23);
            this.btnDefault.TabIndex = 3;
            this.btnDefault.Text = "Back To Defaults";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // lblHotkey
            // 
            this.lblHotkey.AutoSize = true;
            this.lblHotkey.Location = new System.Drawing.Point(26, 154);
            this.lblHotkey.Name = "lblHotkey";
            this.lblHotkey.Size = new System.Drawing.Size(148, 13);
            this.lblHotkey.TabIndex = 4;
            this.lblHotkey.Text = "Stealth Mode Disable Hotkey:";
            // 
            // txtHotkey
            // 
            this.txtHotkey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtHotkey.Location = new System.Drawing.Point(180, 151);
            this.txtHotkey.Name = "txtHotkey";
            this.txtHotkey.ReadOnly = true;
            this.txtHotkey.Size = new System.Drawing.Size(172, 20);
            this.txtHotkey.TabIndex = 5;
            this.txtHotkey.Text = "Click here to set hotkey.";
            this.txtHotkey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHotkey.Click += new System.EventHandler(this.txtHotkey_Click);
            // 
            // grpScrenCap
            // 
            this.grpScrenCap.Controls.Add(this.label5);
            this.grpScrenCap.Controls.Add(this.txtInterval);
            this.grpScrenCap.Controls.Add(this.label4);
            this.grpScrenCap.Controls.Add(this.btnBrowseScreenDirectory);
            this.grpScrenCap.Controls.Add(this.txtScreenDirectory);
            this.grpScrenCap.Controls.Add(this.label3);
            this.grpScrenCap.Controls.Add(this.chkScreenCap);
            this.grpScrenCap.Location = new System.Drawing.Point(25, 192);
            this.grpScrenCap.Name = "grpScrenCap";
            this.grpScrenCap.Size = new System.Drawing.Size(327, 138);
            this.grpScrenCap.TabIndex = 6;
            this.grpScrenCap.TabStop = false;
            this.grpScrenCap.Text = "Screen Capture Options";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "seconds";
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(129, 95);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(58, 20);
            this.txtInterval.TabIndex = 5;
            this.txtInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Screenshot Interval:";
            // 
            // btnBrowseScreenDirectory
            // 
            this.btnBrowseScreenDirectory.Location = new System.Drawing.Point(220, 66);
            this.btnBrowseScreenDirectory.Name = "btnBrowseScreenDirectory";
            this.btnBrowseScreenDirectory.Size = new System.Drawing.Size(98, 20);
            this.btnBrowseScreenDirectory.TabIndex = 3;
            this.btnBrowseScreenDirectory.Text = "Browse";
            this.btnBrowseScreenDirectory.UseVisualStyleBackColor = true;
            this.btnBrowseScreenDirectory.Click += new System.EventHandler(this.btnBrowseScreenDirectory_Click);
            // 
            // txtScreenDirectory
            // 
            this.txtScreenDirectory.Location = new System.Drawing.Point(24, 66);
            this.txtScreenDirectory.Name = "txtScreenDirectory";
            this.txtScreenDirectory.Size = new System.Drawing.Size(190, 20);
            this.txtScreenDirectory.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Screen Capture Directory:";
            // 
            // chkScreenCap
            // 
            this.chkScreenCap.AutoSize = true;
            this.chkScreenCap.Location = new System.Drawing.Point(24, 20);
            this.chkScreenCap.Name = "chkScreenCap";
            this.chkScreenCap.Size = new System.Drawing.Size(163, 17);
            this.chkScreenCap.TabIndex = 0;
            this.chkScreenCap.Text = "Capure Periodic Screenshots";
            this.chkScreenCap.UseVisualStyleBackColor = true;
            this.chkScreenCap.CheckedChanged += new System.EventHandler(this.chkScreenCap_CheckedChanged);
            // 
            // formOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 398);
            this.Controls.Add(this.grpScrenCap);
            this.Controls.Add(this.txtHotkey);
            this.Controls.Add(this.lblHotkey);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpLogOptions);
            this.HelpButton = true;
            this.Name = "formOptions";
            this.Text = "Configure";
            this.Load += new System.EventHandler(this.formOptions_Load);
            this.grpLogOptions.ResumeLayout(false);
            this.grpLogOptions.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpScrenCap.ResumeLayout(false);
            this.grpScrenCap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLogOptions;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdioLowercase;
        private System.Windows.Forms.RadioButton rdioUppercase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmboDelimiter;
        private System.Windows.Forms.CheckBox chkText;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Label lblHotkey;
        private System.Windows.Forms.TextBox txtHotkey;
        private System.Windows.Forms.GroupBox grpScrenCap;
        private System.Windows.Forms.Button btnBrowseScreenDirectory;
        private System.Windows.Forms.TextBox txtScreenDirectory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkScreenCap;
        private System.Windows.Forms.FolderBrowserDialog dialogScreenFolder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInterval;
    }
}