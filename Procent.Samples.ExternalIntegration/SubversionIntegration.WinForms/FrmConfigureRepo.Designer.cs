namespace SubversionIntegration.WinForms
{
	partial class FrmConfigureRepo
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
			System.Windows.Forms.Label passwordLabel;
			System.Windows.Forms.Label remoteLocationLabel;
			System.Windows.Forms.Label userNameLabel;
			System.Windows.Forms.Label workingCopyPathLabel;
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.svnRepositoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.remoteLocationTextBox = new System.Windows.Forms.TextBox();
			this.userNameTextBox = new System.Windows.Forms.TextBox();
			this.workingCopyPathTextBox = new System.Windows.Forms.TextBox();
			this.btnOK = new System.Windows.Forms.Button();
			passwordLabel = new System.Windows.Forms.Label();
			remoteLocationLabel = new System.Windows.Forms.Label();
			userNameLabel = new System.Windows.Forms.Label();
			workingCopyPathLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.svnRepositoryBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// passwordLabel
			// 
			passwordLabel.AutoSize = true;
			passwordLabel.Location = new System.Drawing.Point(12, 87);
			passwordLabel.Name = "passwordLabel";
			passwordLabel.Size = new System.Drawing.Size(56, 13);
			passwordLabel.TabIndex = 1;
			passwordLabel.Text = "Password:";
			// 
			// remoteLocationLabel
			// 
			remoteLocationLabel.AutoSize = true;
			remoteLocationLabel.Location = new System.Drawing.Point(12, 9);
			remoteLocationLabel.Name = "remoteLocationLabel";
			remoteLocationLabel.Size = new System.Drawing.Size(91, 13);
			remoteLocationLabel.TabIndex = 3;
			remoteLocationLabel.Text = "Remote Location:";
			// 
			// userNameLabel
			// 
			userNameLabel.AutoSize = true;
			userNameLabel.Location = new System.Drawing.Point(12, 61);
			userNameLabel.Name = "userNameLabel";
			userNameLabel.Size = new System.Drawing.Size(63, 13);
			userNameLabel.TabIndex = 5;
			userNameLabel.Text = "User Name:";
			// 
			// workingCopyPathLabel
			// 
			workingCopyPathLabel.AutoSize = true;
			workingCopyPathLabel.Location = new System.Drawing.Point(12, 35);
			workingCopyPathLabel.Name = "workingCopyPathLabel";
			workingCopyPathLabel.Size = new System.Drawing.Size(102, 13);
			workingCopyPathLabel.TabIndex = 7;
			workingCopyPathLabel.Text = "Working Copy Path:";
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.svnRepositoryBindingSource, "Password", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.passwordTextBox.Location = new System.Drawing.Point(120, 84);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(527, 20);
			this.passwordTextBox.TabIndex = 3;
			// 
			// svnRepositoryBindingSource
			// 
			this.svnRepositoryBindingSource.DataSource = typeof(Procent.Samples.ExternalIntegration.Subversion.SvnRepository);
			// 
			// remoteLocationTextBox
			// 
			this.remoteLocationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.svnRepositoryBindingSource, "RemoteLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.remoteLocationTextBox.Location = new System.Drawing.Point(120, 6);
			this.remoteLocationTextBox.Name = "remoteLocationTextBox";
			this.remoteLocationTextBox.Size = new System.Drawing.Size(527, 20);
			this.remoteLocationTextBox.TabIndex = 0;
			// 
			// userNameTextBox
			// 
			this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.svnRepositoryBindingSource, "UserName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.userNameTextBox.Location = new System.Drawing.Point(120, 58);
			this.userNameTextBox.Name = "userNameTextBox";
			this.userNameTextBox.Size = new System.Drawing.Size(527, 20);
			this.userNameTextBox.TabIndex = 2;
			// 
			// workingCopyPathTextBox
			// 
			this.workingCopyPathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.svnRepositoryBindingSource, "WorkingCopyPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.workingCopyPathTextBox.Location = new System.Drawing.Point(120, 32);
			this.workingCopyPathTextBox.Name = "workingCopyPathTextBox";
			this.workingCopyPathTextBox.Size = new System.Drawing.Size(527, 20);
			this.workingCopyPathTextBox.TabIndex = 1;
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(15, 114);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(178, 23);
			this.btnOK.TabIndex = 4;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// FrmConfigureRepo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(659, 149);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(passwordLabel);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(remoteLocationLabel);
			this.Controls.Add(this.remoteLocationTextBox);
			this.Controls.Add(userNameLabel);
			this.Controls.Add(this.userNameTextBox);
			this.Controls.Add(workingCopyPathLabel);
			this.Controls.Add(this.workingCopyPathTextBox);
			this.Name = "FrmConfigureRepo";
			this.Text = "FrmConfigureRepo";
			((System.ComponentModel.ISupportInitialize)(this.svnRepositoryBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource svnRepositoryBindingSource;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.TextBox remoteLocationTextBox;
		private System.Windows.Forms.TextBox userNameTextBox;
		private System.Windows.Forms.TextBox workingCopyPathTextBox;
		private System.Windows.Forms.Button btnOK;
	}
}