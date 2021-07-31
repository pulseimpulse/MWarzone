using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;

// Token: 0x02000021 RID: 33
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
internal sealed class Class18
{
	// Token: 0x060000B2 RID: 178 RVA: 0x00002084 File Offset: 0x00000284
	internal Class18()
	{
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x000025EB File Offset: 0x000007EB
	internal static ResourceManager smethod_0()
	{
		if (Class18.resourceManager_0 == null)
		{
			Class18.resourceManager_0 = new ResourceManager("MWarzone.Properties.Resources", typeof(Class18).Assembly);
		}
		return Class18.resourceManager_0;
	}

	// Token: 0x060000B4 RID: 180 RVA: 0x00002617 File Offset: 0x00000817
	internal static CultureInfo smethod_1()
	{
		return Class18.cultureInfo_0;
	}

	// Token: 0x060000B5 RID: 181 RVA: 0x0000261E File Offset: 0x0000081E
	internal static void smethod_2(CultureInfo cultureInfo_1)
	{
		Class18.cultureInfo_0 = cultureInfo_1;
	}

	// Token: 0x060000B6 RID: 182 RVA: 0x00002626 File Offset: 0x00000826
	internal static Bitmap smethod_3()
	{
		return (Bitmap)Class18.smethod_0().GetObject("Sellix-Avatar", Class18.cultureInfo_0);
	}

	// Token: 0x04000049 RID: 73
	private static ResourceManager resourceManager_0;

	// Token: 0x0400004A RID: 74
	private static CultureInfo cultureInfo_0;
}
