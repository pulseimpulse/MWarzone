using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Siticone.UI.WinForms;

// Token: 0x0200001D RID: 29
public sealed partial class Register : MetroForm
{
	// Token: 0x0600007A RID: 122 RVA: 0x000023E1 File Offset: 0x000005E1
	public Register()
	{
		this.InitializeComponent();
	}

	// Token: 0x0600007B RID: 123 RVA: 0x000023EF File Offset: 0x000005EF
	// Note: this type is marked as 'beforefieldinit'.
	static Register()
	{
		string string_ = "MWarzone Vel'KoZed";
		Class17 @class = new Class17();
		@class.method_1("9311261a2a53510620c477fda695ed22");
		@class.method_3("713252");
		@class.method_5("1.0");
		Register.class16_0 = new Class16(string_, @class);
	}

	// Token: 0x0600007C RID: 124 RVA: 0x000043C4 File Offset: 0x000025C4
	private void siticoneRoundedButton1_Click(object sender, EventArgs e)
	{
		if (Register.class16_0.method_2(this.username.Text, this.password.Text, this.license.Text))
		{
			MessageBox.Show("Register has been successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
	}

	// Token: 0x0600007D RID: 125 RVA: 0x00002426 File Offset: 0x00000626
	private void siticoneRoundedButton2_Click(object sender, EventArgs e)
	{
		base.Hide();
		new Login().Show();
	}

	// Token: 0x0400002A RID: 42
	internal static readonly Class16 class16_0;

    private void Register_Load(object sender, EventArgs e)
    {

    }
}
