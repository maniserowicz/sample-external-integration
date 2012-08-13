namespace SubversionIntegration.WinForms
{
	partial class FrmMain
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
			this.btnLog = new System.Windows.Forms.Button();
			this.tbOutput = new System.Windows.Forms.TextBox();
			this.btnCheckout = new System.Windows.Forms.Button();
			this.btnRepoSettings = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnLog
			// 
			this.btnLog.Location = new System.Drawing.Point(2, 41);
			this.btnLog.Name = "btnLog";
			this.btnLog.Size = new System.Drawing.Size(75, 23);
			this.btnLog.TabIndex = 0;
			this.btnLog.Text = "GetLog";
			this.btnLog.UseVisualStyleBackColor = true;
			this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
			// 
			// tbOutput
			// 
			this.tbOutput.Location = new System.Drawing.Point(2, 70);
			this.tbOutput.Multiline = true;
			this.tbOutput.Name = "tbOutput";
			this.tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbOutput.Size = new System.Drawing.Size(470, 220);
			this.tbOutput.TabIndex = 1;
			// 
			// btnCheckout
			// 
			this.btnCheckout.Location = new System.Drawing.Point(397, 41);
			this.btnCheckout.Name = "btnCheckout";
			this.btnCheckout.Size = new System.Drawing.Size(75, 23);
			this.btnCheckout.TabIndex = 2;
			this.btnCheckout.Text = "Checkout";
			this.btnCheckout.UseVisualStyleBackColor = true;
			this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
			// 
			// btnRepoSettings
			// 
			this.btnRepoSettings.Location = new System.Drawing.Point(2, 12);
			this.btnRepoSettings.Name = "btnRepoSettings";
			this.btnRepoSettings.Size = new System.Drawing.Size(130, 23);
			this.btnRepoSettings.TabIndex = 3;
			this.btnRepoSettings.Text = "Configure repository";
			this.btnRepoSettings.UseVisualStyleBackColor = true;
			this.btnRepoSettings.Click += new System.EventHandler(this.btnRepoSettings_Click);
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(476, 296);
			this.Controls.Add(this.btnRepoSettings);
			this.Controls.Add(this.btnCheckout);
			this.Controls.Add(this.tbOutput);
			this.Controls.Add(this.btnLog);
			this.Name = "FrmMain";
			this.Text = "SVN Integration";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnLog;
		private System.Windows.Forms.TextBox tbOutput;
		private System.Windows.Forms.Button btnCheckout;
		private System.Windows.Forms.Button btnRepoSettings;
	}
}

