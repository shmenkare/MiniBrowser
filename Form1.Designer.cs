namespace MiniBrowser
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
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnNavegar = new System.Windows.Forms.Button();
            this.WebBrowserCtl = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(12, 12);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(861, 20);
            this.txtURL.TabIndex = 0;
            // 
            // btnNavegar
            // 
            this.btnNavegar.Location = new System.Drawing.Point(879, 12);
            this.btnNavegar.Name = "btnNavegar";
            this.btnNavegar.Size = new System.Drawing.Size(75, 23);
            this.btnNavegar.TabIndex = 1;
            this.btnNavegar.Text = "Navegar";
            this.btnNavegar.UseVisualStyleBackColor = true;
            this.btnNavegar.Click += new System.EventHandler(this.btnNavegar_Click);
            // 
            // WebBrowserCtl
            // 
            this.WebBrowserCtl.Location = new System.Drawing.Point(12, 38);
            this.WebBrowserCtl.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowserCtl.Name = "WebBrowserCtl";
            this.WebBrowserCtl.Size = new System.Drawing.Size(952, 528);
            this.WebBrowserCtl.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 578);
            this.Controls.Add(this.WebBrowserCtl);
            this.Controls.Add(this.btnNavegar);
            this.Controls.Add(this.txtURL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiniBrowser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnNavegar;
        private System.Windows.Forms.WebBrowser WebBrowserCtl;
    }
}

