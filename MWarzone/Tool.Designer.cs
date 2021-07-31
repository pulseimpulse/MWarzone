// Token: 0x02000028 RID: 40
public sealed partial class Tool : global::MetroFramework.Forms.MetroForm
{
	// Token: 0x060000E8 RID: 232 RVA: 0x00002914 File Offset: 0x00000B14
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x060000E9 RID: 233 RVA: 0x00006408 File Offset: 0x00004608
	private void InitializeComponent()
	{
            this.components = new System.ComponentModel.Container();
            this.timer_0 = new System.Windows.Forms.Timer(this.components);
            this.timer_1 = new System.Windows.Forms.Timer(this.components);
            this.timer_2 = new System.Windows.Forms.Timer(this.components);
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.siticoneRoundedButton12 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.siticoneRoundedButton1 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton2 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // timer_0
            // 
            this.timer_0.Enabled = true;
            this.timer_0.Tick += new System.EventHandler(this.timer_0_Tick);
            // 
            // timer_1
            // 
            this.timer_1.Enabled = true;
            this.timer_1.Interval = 50;
            this.timer_1.Tick += new System.EventHandler(this.timer_1_Tick);
            // 
            // timer_2
            // 
            this.timer_2.Enabled = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(106, 155);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(65, 15);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel9.TabIndex = 53;
            this.metroLabel9.Text = "Not Ready";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel9.UseStyleColors = true;
            // 
            // siticoneRoundedButton12
            // 
            this.siticoneRoundedButton12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.siticoneRoundedButton12.CheckedState.Parent = this.siticoneRoundedButton12;
            this.siticoneRoundedButton12.CustomImages.Parent = this.siticoneRoundedButton12;
            this.siticoneRoundedButton12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.siticoneRoundedButton12.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneRoundedButton12.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton12.HoveredState.Parent = this.siticoneRoundedButton12;
            this.siticoneRoundedButton12.ImageSize = new System.Drawing.Size(18, 18);
            this.siticoneRoundedButton12.Location = new System.Drawing.Point(55, 125);
            this.siticoneRoundedButton12.Name = "siticoneRoundedButton12";
            this.siticoneRoundedButton12.ShadowDecoration.Parent = this.siticoneRoundedButton12;
            this.siticoneRoundedButton12.Size = new System.Drawing.Size(168, 27);
            this.siticoneRoundedButton12.TabIndex = 119;
            this.siticoneRoundedButton12.Text = "Enable Constant UAV & Exit";
            this.siticoneRoundedButton12.Click += new System.EventHandler(this.siticoneRoundedButton12_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.Location = new System.Drawing.Point(5, 469);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(37, 15);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroLabel1.TabIndex = 120;
            this.metroLabel1.Text = "Offset";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.Visible = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.Location = new System.Drawing.Point(5, 484);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(37, 15);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroLabel2.TabIndex = 121;
            this.metroLabel2.Text = "Offset";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.Visible = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.Location = new System.Drawing.Point(23, 75);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(60, 15);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroLabel3.TabIndex = 122;
            this.metroLabel3.Text = "Welcome, ";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.Location = new System.Drawing.Point(23, 90);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(43, 15);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroLabel4.TabIndex = 123;
            this.metroLabel4.Text = "Expire: ";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // siticoneRoundedButton1
            // 
            this.siticoneRoundedButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.siticoneRoundedButton1.CheckedState.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.CustomImages.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.siticoneRoundedButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneRoundedButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton1.HoveredState.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.ImageSize = new System.Drawing.Size(18, 18);
            this.siticoneRoundedButton1.Location = new System.Drawing.Point(72, 192);
            this.siticoneRoundedButton1.Name = "siticoneRoundedButton1";
            this.siticoneRoundedButton1.ShadowDecoration.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.Size = new System.Drawing.Size(52, 27);
            this.siticoneRoundedButton1.TabIndex = 124;
            this.siticoneRoundedButton1.Text = "Option1";
            // 
            // siticoneRoundedButton2
            // 
            this.siticoneRoundedButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.siticoneRoundedButton2.CheckedState.Parent = this.siticoneRoundedButton2;
            this.siticoneRoundedButton2.CustomImages.Parent = this.siticoneRoundedButton2;
            this.siticoneRoundedButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.siticoneRoundedButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneRoundedButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton2.HoveredState.Parent = this.siticoneRoundedButton2;
            this.siticoneRoundedButton2.ImageSize = new System.Drawing.Size(18, 18);
            this.siticoneRoundedButton2.Location = new System.Drawing.Point(130, 192);
            this.siticoneRoundedButton2.Name = "siticoneRoundedButton2";
            this.siticoneRoundedButton2.ShadowDecoration.Parent = this.siticoneRoundedButton2;
            this.siticoneRoundedButton2.Size = new System.Drawing.Size(54, 27);
            this.siticoneRoundedButton2.TabIndex = 125;
            this.siticoneRoundedButton2.Text = "Option2";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.Location = new System.Drawing.Point(23, 223);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(43, 15);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroLabel5.TabIndex = 126;
            this.metroLabel5.Text = "Expire: ";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel6.Location = new System.Drawing.Point(23, 238);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(43, 15);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroLabel6.TabIndex = 127;
            this.metroLabel6.Text = "Expire: ";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Tool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 184);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.siticoneRoundedButton2);
            this.Controls.Add(this.siticoneRoundedButton1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.siticoneRoundedButton12);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Tool";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "MWarzone";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Tool_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

	}

	// Token: 0x04000057 RID: 87
	private global::System.ComponentModel.IContainer icontainer_0;

	// Token: 0x04000058 RID: 88
	private global::System.Windows.Forms.Timer timer_0;

	// Token: 0x04000059 RID: 89
	private global::System.Windows.Forms.Timer timer_1;

	// Token: 0x0400005A RID: 90
	private global::System.Windows.Forms.Timer timer_2;

	// Token: 0x0400005B RID: 91
	private global::MetroFramework.Controls.MetroLabel metroLabel9;

	// Token: 0x0400005C RID: 92
	private global::Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton12;

	// Token: 0x0400005D RID: 93
	private global::MetroFramework.Controls.MetroLabel metroLabel1;

	// Token: 0x0400005E RID: 94
	private global::MetroFramework.Controls.MetroLabel metroLabel2;

	// Token: 0x0400005F RID: 95
	private global::MetroFramework.Controls.MetroLabel metroLabel3;

	// Token: 0x04000060 RID: 96
	private global::MetroFramework.Controls.MetroLabel metroLabel4;

	// Token: 0x04000061 RID: 97
	private global::Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton1;

	// Token: 0x04000062 RID: 98
	private global::Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton2;

	// Token: 0x04000063 RID: 99
	private global::MetroFramework.Controls.MetroLabel metroLabel5;

	// Token: 0x04000064 RID: 100
	private global::MetroFramework.Controls.MetroLabel metroLabel6;
    private System.ComponentModel.IContainer components;
}
