namespace OS_Keylogger
{
    partial class formSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSplash));
            this.lblRegistered = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRegistered
            // 
            this.lblRegistered.AutoSize = true;
            this.lblRegistered.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistered.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistered.ForeColor = System.Drawing.Color.White;
            this.lblRegistered.Location = new System.Drawing.Point(385, 288);
            this.lblRegistered.Name = "lblRegistered";
            this.lblRegistered.Size = new System.Drawing.Size(170, 32);
            this.lblRegistered.TabIndex = 0;
            this.lblRegistered.Text = "Unregistered";
            // 
            // formSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(638, 408);
            this.Controls.Add(this.lblRegistered);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formSplash";
            this.Load += new System.EventHandler(this.formSplash_Load);
            this.DoubleClick += new System.EventHandler(this.formSplash_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistered;

    }
}