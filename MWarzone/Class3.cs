using System;
using System.Windows.Forms;

// Token: 0x0200000F RID: 15
internal static class Class3
{
	// Token: 0x06000057 RID: 87 RVA: 0x000022B4 File Offset: 0x000004B4
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run(new Login());
	}
}
