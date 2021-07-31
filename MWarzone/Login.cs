using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MWarzone.Properties;
using Siticone.UI.WinForms;

// Token: 0x0200000A RID: 10
public sealed partial class Login : MetroForm
{
	// Token: 0x06000037 RID: 55 RVA: 0x00002163 File Offset: 0x00000363
	public Login()
	{
		this.InitializeComponent();
		Login.class16_0.method_0();
		if (!Login.class16_0.method_7())
		{
			MessageBox.Show("Could not verify the connection to the server!", Login.class16_0.method_8(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	// Token: 0x06000038 RID: 56 RVA: 0x000021A0 File Offset: 0x000003A0
	// Note: this type is marked as 'beforefieldinit'.
	static Login()
	{
		string string_ = "MWarzone Vel'KoZed";
		Class17 @class = new Class17();
		@class.method_1("9311261a2a53510620c477fda695ed22");
		@class.method_3("713252");
		@class.method_5("1.0");
		Login.class16_0 = new Class16(string_, @class);
	}

	// Token: 0x06000039 RID: 57 RVA: 0x0000307C File Offset: 0x0000127C
	private void method_0(object sender, EventArgs e)
	{
		if (Login.class16_0.method_1(this.username.Text, this.password.Text))
		{
			MetroMessageBox.Show(this, "You have successfully logged in!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			new Login();
			Form form = new Register();
			base.Hide();
			form.ShowDialog();
			base.Close();
		}
	}

	// Token: 0x0600003A RID: 58 RVA: 0x000030DC File Offset: 0x000012DC
	private void siticoneRoundedButton1_Click(object sender, EventArgs e)
	{
		if (Login.class16_0.method_1(this.username.Text, this.password.Text))
		{
			MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			Console.WriteLine(Login.class16_0.method_4("fo02kn106mkxfercelomej6u937aqqqz4m7"));
			Form form = new Tool();
			base.Hide();
			form.ShowDialog();
			base.Close();
		}
	}

	// Token: 0x0600003B RID: 59 RVA: 0x000021D7 File Offset: 0x000003D7
	private void siticoneRoundedButton2_Click(object sender, EventArgs e)
	{
		base.Hide();
		new Register().Show();
	}

	// Token: 0x0600003C RID: 60 RVA: 0x0000314C File Offset: 0x0000134C
	private void siticoneCheckBox1_CheckedChanged(object sender, EventArgs e)
	{
		if (this.siticoneCheckBox1.Checked)
		{
			Settings.Default.userName = this.username.Text;
			Settings.Default.Password = this.password.Text;
			Settings.Default.Save();
			return;
		}
		Settings.Default.userName = string.Empty;
		Settings.Default.Password = string.Empty;
		Settings.Default.Save();
	}

	// Token: 0x0600003D RID: 61 RVA: 0x000031C4 File Offset: 0x000013C4
	private void Login_Load(object sender, EventArgs e)
	{
		if (Settings.Default.userName != string.Empty)
		{
			this.username.Text = Settings.Default.userName;
			this.password.Text = Settings.Default.Password;
		}
	}

	// Token: 0x04000011 RID: 17
	internal static readonly Class16 class16_0;
}
