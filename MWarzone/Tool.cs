using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Siticone.UI.WinForms;

// Token: 0x02000028 RID: 40
public sealed partial class Tool : MetroForm
{
	// Token: 0x060000E3 RID: 227 RVA: 0x000028F9 File Offset: 0x00000AF9
	public Tool()
	{
		this.InitializeComponent();
	}

	// Token: 0x060000E4 RID: 228 RVA: 0x0000624C File Offset: 0x0000444C
	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (this.gclass1_0.method_1())
		{
			if (this.gclass1_0.method_5(Class24.long_1).ToString() == "0")
			{
				this.metroLabel9.Text = "Not Ready";
			}
			else
			{
				this.metroLabel9.Text = "Ready";
			}
			this.metroLabel9.UseCustomForeColor = true;
			this.timer_2.Interval = 500;
			if (!this.timer_1.Enabled)
			{
				this.timer_1.Start();
			}
			if (this.int_0 == 0)
			{
				Class24.smethod_1();
				this.int_0 = 1;
				return;
			}
		}
		else
		{
			this.gclass1_0.method_0("ModernWarfare");
			this.timer_2.Interval = 100;
		}
	}

	// Token: 0x060000E5 RID: 229 RVA: 0x00006318 File Offset: 0x00004518
	private void siticoneRoundedButton12_Click(object sender, EventArgs e)
	{
		this.gclass1_0.method_12(Class24.long_2, 1);
		this.gclass1_0.method_12(Class24.long_3, 1);
		this.gclass1_0.method_12(Class24.long_4, 1364573007);
		this.gclass1_0.method_12(Class24.long_5, 2041474550);
		this.gclass1_0.method_12(Class24.long_6, 1364573007);
		this.gclass1_0.method_12(Class24.long_7, 2041474550);
		Application.Exit();
	}

	// Token: 0x060000E6 RID: 230 RVA: 0x000063A0 File Offset: 0x000045A0
	private void timer_1_Tick(object sender, EventArgs e)
	{
		this.metroLabel3.Text = "Welcome, " + GClass0.smethod_0();
		this.metroLabel4.Text = "Expire: " + GClass0.smethod_6();
		this.metroLabel5.Text = "baseuav address: 0x" + Class24.long_1.ToString("X");
	}

	// Token: 0x060000E7 RID: 231 RVA: 0x00002912 File Offset: 0x00000B12
	private void method_0(object sender, EventArgs e)
	{
	}

	// Token: 0x04000055 RID: 85
	private int int_0;

	// Token: 0x04000056 RID: 86
	private GClass1 gclass1_0 = new GClass1();

    private void Tool_Load(object sender, EventArgs e)
    {

    }
}
