// Token: 0x0200000A RID: 10
public sealed partial class Login : global::MetroFramework.Forms.MetroForm
{
	// Token: 0x0600003E RID: 62 RVA: 0x000021E9 File Offset: 0x000003E9
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x0600003F RID: 63 RVA: 0x00003214 File Offset: 0x00001414
	private void InitializeComponent()
	{
		global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Login));
		this.siticoneCheckBox1 = new global::Siticone.UI.WinForms.SiticoneCheckBox();
		this.siticoneRoundedButton1 = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
		this.password = new global::Siticone.UI.WinForms.SiticoneRoundedTextBox();
		this.username = new global::Siticone.UI.WinForms.SiticoneRoundedTextBox();
		this.siticoneRoundedButton2 = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
		this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
		((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		base.SuspendLayout();
		this.siticoneCheckBox1.AutoSize = true;
		this.siticoneCheckBox1.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(209, 17, 65);
		this.siticoneCheckBox1.CheckedState.BorderRadius = 2;
		this.siticoneCheckBox1.CheckedState.BorderThickness = 0;
		this.siticoneCheckBox1.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(209, 17, 65);
		this.siticoneCheckBox1.ForeColor = global::System.Drawing.Color.White;
		this.siticoneCheckBox1.Location = new global::System.Drawing.Point(108, 210);
		this.siticoneCheckBox1.Name = "siticoneCheckBox1";
		this.siticoneCheckBox1.Size = new global::System.Drawing.Size(94, 17);
		this.siticoneCheckBox1.TabIndex = 52;
		this.siticoneCheckBox1.Text = "Remember me";
		this.siticoneCheckBox1.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
		this.siticoneCheckBox1.UncheckedState.BorderRadius = 2;
		this.siticoneCheckBox1.UncheckedState.BorderThickness = 0;
		this.siticoneCheckBox1.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
		this.siticoneCheckBox1.UseVisualStyleBackColor = true;
		this.siticoneCheckBox1.CheckedChanged += new global::System.EventHandler(this.siticoneCheckBox1_CheckedChanged);
		this.siticoneRoundedButton1.CheckedState.Parent = this.siticoneRoundedButton1;
		this.siticoneRoundedButton1.CustomImages.Parent = this.siticoneRoundedButton1;
		this.siticoneRoundedButton1.FillColor = global::System.Drawing.Color.FromArgb(255, 128, 0);
		this.siticoneRoundedButton1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
		this.siticoneRoundedButton1.ForeColor = global::System.Drawing.Color.White;
		this.siticoneRoundedButton1.HoveredState.Parent = this.siticoneRoundedButton1;
		this.siticoneRoundedButton1.Location = new global::System.Drawing.Point(87, 246);
		this.siticoneRoundedButton1.Name = "siticoneRoundedButton1";
		this.siticoneRoundedButton1.PressedDepth = 0;
		this.siticoneRoundedButton1.ShadowDecoration.Parent = this.siticoneRoundedButton1;
		this.siticoneRoundedButton1.Size = new global::System.Drawing.Size(137, 28);
		this.siticoneRoundedButton1.TabIndex = 51;
		this.siticoneRoundedButton1.Text = "Login";
		this.siticoneRoundedButton1.Click += new global::System.EventHandler(this.siticoneRoundedButton1_Click);
		this.password.BorderColor = global::System.Drawing.Color.FromArgb(255, 128, 0);
		this.password.Cursor = global::System.Windows.Forms.Cursors.IBeam;
		this.password.DefaultText = string.Empty;
		this.password.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
		this.password.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
		this.password.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
		this.password.DisabledState.Parent = this.password;
		this.password.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
		this.password.FillColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
		this.password.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(209, 17, 65);
		this.password.FocusedState.Parent = this.password;
		this.password.ForeColor = global::System.Drawing.Color.White;
		this.password.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(209, 17, 65);
		this.password.HoveredState.Parent = this.password;
		this.password.Location = new global::System.Drawing.Point(87, 173);
		this.password.Name = "password";
		this.password.PasswordChar = '\0';
		this.password.PlaceholderText = "Password";
		this.password.SelectedText = string.Empty;
		this.password.ShadowDecoration.Parent = this.password;
		this.password.Size = new global::System.Drawing.Size(137, 31);
		this.password.TabIndex = 50;
		this.password.UseSystemPasswordChar = true;
		this.username.BorderColor = global::System.Drawing.Color.FromArgb(255, 128, 0);
		this.username.Cursor = global::System.Windows.Forms.Cursors.IBeam;
		this.username.DefaultText = string.Empty;
		this.username.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
		this.username.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
		this.username.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
		this.username.DisabledState.Parent = this.username;
		this.username.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
		this.username.FillColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
		this.username.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(209, 17, 65);
		this.username.FocusedState.Parent = this.username;
		this.username.ForeColor = global::System.Drawing.Color.White;
		this.username.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(209, 17, 65);
		this.username.HoveredState.Parent = this.username;
		this.username.Location = new global::System.Drawing.Point(87, 136);
		this.username.Name = "username";
		this.username.PasswordChar = '\0';
		this.username.PlaceholderText = "Username";
		this.username.SelectedText = string.Empty;
		this.username.ShadowDecoration.Parent = this.username;
		this.username.Size = new global::System.Drawing.Size(137, 31);
		this.username.TabIndex = 49;
		this.siticoneRoundedButton2.CheckedState.Parent = this.siticoneRoundedButton2;
		this.siticoneRoundedButton2.CustomImages.Parent = this.siticoneRoundedButton2;
		this.siticoneRoundedButton2.FillColor = global::System.Drawing.Color.FromArgb(255, 128, 0);
		this.siticoneRoundedButton2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
		this.siticoneRoundedButton2.ForeColor = global::System.Drawing.Color.White;
		this.siticoneRoundedButton2.HoveredState.Parent = this.siticoneRoundedButton2;
		this.siticoneRoundedButton2.Location = new global::System.Drawing.Point(87, 280);
		this.siticoneRoundedButton2.Name = "siticoneRoundedButton2";
		this.siticoneRoundedButton2.PressedDepth = 0;
		this.siticoneRoundedButton2.ShadowDecoration.Parent = this.siticoneRoundedButton2;
		this.siticoneRoundedButton2.Size = new global::System.Drawing.Size(137, 28);
		this.siticoneRoundedButton2.TabIndex = 48;
		this.siticoneRoundedButton2.Text = "Register";
		this.siticoneRoundedButton2.Click += new global::System.EventHandler(this.siticoneRoundedButton2_Click);
	
		this.pictureBox1.Location = new global::System.Drawing.Point(87, 83);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new global::System.Drawing.Size(137, 47);
		this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.pictureBox1.TabIndex = 47;
		this.pictureBox1.TabStop = false;
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new global::System.Drawing.Size(323, 391);
		base.Controls.Add(this.siticoneCheckBox1);
		base.Controls.Add(this.siticoneRoundedButton1);
		base.Controls.Add(this.password);
		base.Controls.Add(this.username);
		base.Controls.Add(this.siticoneRoundedButton2);
		base.Controls.Add(this.pictureBox1);
		base.Name = "Login";
		base.Style = global::MetroFramework.MetroColorStyle.Orange;
		this.Text = "Login";
		base.Theme = global::MetroFramework.MetroThemeStyle.Dark;
		base.Load += new global::System.EventHandler(this.Login_Load);
		((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x04000012 RID: 18
	private global::System.ComponentModel.IContainer icontainer_0;

	// Token: 0x04000013 RID: 19
	private global::Siticone.UI.WinForms.SiticoneCheckBox siticoneCheckBox1;

	// Token: 0x04000014 RID: 20
	private global::Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton1;

	// Token: 0x04000015 RID: 21
	private global::Siticone.UI.WinForms.SiticoneRoundedTextBox password;

	// Token: 0x04000016 RID: 22
	private global::Siticone.UI.WinForms.SiticoneRoundedTextBox username;

	// Token: 0x04000017 RID: 23
	private global::Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton2;

	// Token: 0x04000018 RID: 24
	private global::System.Windows.Forms.PictureBox pictureBox1;
}
