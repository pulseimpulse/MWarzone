using System;
using System.Collections.Generic;

// Token: 0x0200000E RID: 14
public sealed class GClass2
{
	// Token: 0x06000044 RID: 68 RVA: 0x00003B78 File Offset: 0x00001D78
	public static void smethod_0(Dictionary<string, object> dictionary_0)
	{
		GClass2.smethod_2((string)dictionary_0["version"]);
		GClass2.smethod_18(((string)dictionary_0["updater_link"] == null) ? "Undefined" : ((string)dictionary_0["updater_link"]));
		GClass2.smethod_6((string)dictionary_0["enabled"] == "1");
		GClass2.smethod_14((string)dictionary_0["hwidlock"] == "1");
		GClass2.smethod_4((string)dictionary_0["freemode"] == "1");
		GClass2.smethod_12((string)dictionary_0["devmode"] == "1");
		GClass2.smethod_8((string)dictionary_0["hashcheck"] == "1");
		GClass2.smethod_16((string)dictionary_0["optionalupdater"] == "1");
		if (GClass2.smethod_7())
		{
			GClass2.smethod_10(((string)dictionary_0["hash"] == null) ? "Undefined" : ((string)dictionary_0["hash"]));
		}
	}

	// Token: 0x06000045 RID: 69 RVA: 0x0000222D File Offset: 0x0000042D
	public static string smethod_1()
	{
		return GClass2.string_0;
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00002234 File Offset: 0x00000434
	public static void smethod_2(string string_3)
	{
		GClass2.string_0 = string_3;
	}

	// Token: 0x06000047 RID: 71 RVA: 0x0000223C File Offset: 0x0000043C
	public static bool smethod_3()
	{
		return GClass2.bool_0;
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00002243 File Offset: 0x00000443
	public static void smethod_4(bool bool_6)
	{
		GClass2.bool_0 = bool_6;
	}

	// Token: 0x06000049 RID: 73 RVA: 0x0000224B File Offset: 0x0000044B
	public static bool smethod_5()
	{
		return GClass2.bool_1;
	}

	// Token: 0x0600004A RID: 74 RVA: 0x00002252 File Offset: 0x00000452
	public static void smethod_6(bool bool_6)
	{
		GClass2.bool_1 = bool_6;
	}

	// Token: 0x0600004B RID: 75 RVA: 0x0000225A File Offset: 0x0000045A
	public static bool smethod_7()
	{
		return GClass2.bool_2;
	}

	// Token: 0x0600004C RID: 76 RVA: 0x00002261 File Offset: 0x00000461
	public static void smethod_8(bool bool_6)
	{
		GClass2.bool_2 = bool_6;
	}

	// Token: 0x0600004D RID: 77 RVA: 0x00002269 File Offset: 0x00000469
	public static string smethod_9()
	{
		return GClass2.string_1;
	}

	// Token: 0x0600004E RID: 78 RVA: 0x00002270 File Offset: 0x00000470
	public static void smethod_10(string string_3)
	{
		GClass2.string_1 = string_3;
	}

	// Token: 0x0600004F RID: 79 RVA: 0x00002278 File Offset: 0x00000478
	public static bool smethod_11()
	{
		return GClass2.bool_3;
	}

	// Token: 0x06000050 RID: 80 RVA: 0x0000227F File Offset: 0x0000047F
	public static void smethod_12(bool bool_6)
	{
		GClass2.bool_3 = bool_6;
	}

	// Token: 0x06000051 RID: 81 RVA: 0x00002287 File Offset: 0x00000487
	public static bool smethod_13()
	{
		return GClass2.bool_4;
	}

	// Token: 0x06000052 RID: 82 RVA: 0x0000228E File Offset: 0x0000048E
	public static void smethod_14(bool bool_6)
	{
		GClass2.bool_4 = bool_6;
	}

	// Token: 0x06000053 RID: 83 RVA: 0x00002296 File Offset: 0x00000496
	public static bool smethod_15()
	{
		return GClass2.bool_5;
	}

	// Token: 0x06000054 RID: 84 RVA: 0x0000229D File Offset: 0x0000049D
	public static void smethod_16(bool bool_6)
	{
		GClass2.bool_5 = bool_6;
	}

	// Token: 0x06000055 RID: 85 RVA: 0x000022A5 File Offset: 0x000004A5
	public static string smethod_17()
	{
		return GClass2.string_2;
	}

	// Token: 0x06000056 RID: 86 RVA: 0x000022AC File Offset: 0x000004AC
	public static void smethod_18(string string_3)
	{
		GClass2.string_2 = string_3;
	}

	// Token: 0x04000019 RID: 25
	private static string string_0;

	// Token: 0x0400001A RID: 26
	private static bool bool_0;

	// Token: 0x0400001B RID: 27
	private static bool bool_1;

	// Token: 0x0400001C RID: 28
	private static bool bool_2;

	// Token: 0x0400001D RID: 29
	private static string string_1;

	// Token: 0x0400001E RID: 30
	private static bool bool_3;

	// Token: 0x0400001F RID: 31
	private static bool bool_4;

	// Token: 0x04000020 RID: 32
	private static bool bool_5;

	// Token: 0x04000021 RID: 33
	private static string string_2;
}
