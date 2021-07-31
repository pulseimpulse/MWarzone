using System;

// Token: 0x0200002C RID: 44
internal sealed class Class24
{
	// Token: 0x060000F0 RID: 240 RVA: 0x00006E4C File Offset: 0x0000504C
	// Note: this type is marked as 'beforefieldinit'.
	static Class24()
	{
		string string_ = "MWarzone Vel'KoZed";
		Class17 @class = new Class17();
		@class.method_1("9311261a2a53510620c477fda695ed22");
		@class.method_3("713252");
		@class.method_5("1.0");
		Class24.class16_0 = new Class16(string_, @class);
		Class24.long_0 = 0L;
	}

	// Token: 0x060000F1 RID: 241 RVA: 0x00006E9C File Offset: 0x0000509C
	public static void smethod_0(string string_0)
	{
		new GClass1().method_0("ModernWarfare");
		try
		{
		}
		catch
		{
		}
	}

	// Token: 0x060000F2 RID: 242 RVA: 0x00006ED0 File Offset: 0x000050D0
	public static void smethod_1()
	{
		GClass1 gclass = new GClass1();
		Class24.long_0 = GClass1.smethod_0("ModernWarfare").ToInt64();
		gclass.method_0("ModernWarfare");
		string value = Class24.class16_0.method_4("8l8yvry88mvnmpeuz4cfhcws3br0dot2ral");
		Class24.long_8 = Class24.long_0 + (long)Convert.ToInt32(value);
		string value2 = Class24.class16_0.method_4("ht8dooiligkh7krayb63d2eyptitx9g7n2d");
		Class24.long_9 = Class24.long_0 + (long)Convert.ToInt32(value2);
		Class24.long_1 = gclass.method_2(Class24.long_8, Class24.long_9, "j·£A\u008c\0\0\0", "xxxxxxxx");
		Class24.long_2 = Class24.long_1 + 16L;
		Class24.long_3 = Class24.long_2 + 32L;
		Class24.long_4 = Class24.long_3 - 8L;
		Class24.long_5 = Class24.long_4 + 4L;
		Class24.long_6 = Class24.long_5 + 28L;
		Class24.long_7 = Class24.long_6 + 4L;
	}

	// Token: 0x04000066 RID: 102
	internal static readonly Class16 class16_0;

	// Token: 0x04000067 RID: 103
	public static long long_0;

	// Token: 0x04000068 RID: 104
	public static long long_1;

	// Token: 0x04000069 RID: 105
	public static long long_2;

	// Token: 0x0400006A RID: 106
	public static long long_3;

	// Token: 0x0400006B RID: 107
	public static long long_4;

	// Token: 0x0400006C RID: 108
	public static long long_5;

	// Token: 0x0400006D RID: 109
	public static long long_6;

	// Token: 0x0400006E RID: 110
	public static long long_7;

	// Token: 0x0400006F RID: 111
	public static long long_8;

	// Token: 0x04000070 RID: 112
	public static long long_9;
}
