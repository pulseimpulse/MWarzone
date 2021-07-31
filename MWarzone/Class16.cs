using System;
using System.Windows.Forms;

// Token: 0x02000027 RID: 39
internal sealed class Class16 : Class14
{
	// Token: 0x060000D8 RID: 216 RVA: 0x000027A4 File Offset: 0x000009A4
	public Class16(string string_2, Class17 class17_0)
	{
		GClass3.smethod_8(string_2);
		GClass3.smethod_14(class17_0.method_0());
		GClass3.smethod_16(class17_0.method_4());
		GClass3.smethod_18(class17_0.method_2());
	}

	// Token: 0x060000DA RID: 218 RVA: 0x000027DF File Offset: 0x000009DF
	public Class16 method_0()
	{
		Class16.gclass3_0.method_0();
		return this;
	}

	// Token: 0x060000DB RID: 219 RVA: 0x000027EC File Offset: 0x000009EC
	public bool method_1(string string_2, string string_3)
	{
		if (!GClass3.smethod_3())
		{
			MessageBox.Show("Badly executed program, you must initialize the application before logging in!", GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
			Environment.Exit(0);
		}
		GClass7.dictionary_0.Add("password", string_3);
		return Class16.gclass3_0.method_3(string_2, string_3);
	}

	// Token: 0x060000DC RID: 220 RVA: 0x0000282A File Offset: 0x00000A2A
	public bool method_2(string string_2, string string_3, string string_4)
	{
		if (!GClass3.smethod_3())
		{
			MessageBox.Show("Badly executed program, you must initialize the application before logging in!", GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
			Environment.Exit(0);
		}
		return Class16.gclass3_0.method_4(string_2, string_3, string_4);
	}

	// Token: 0x060000DD RID: 221 RVA: 0x00002859 File Offset: 0x00000A59
	public bool method_3(string string_2, string string_3, string string_4)
	{
		if (!GClass3.smethod_3())
		{
			MessageBox.Show("Badly executed program, you must initialize the application before logging in!", GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
			Environment.Exit(0);
		}
		return Class16.gclass3_0.method_5(string_2, string_3, string_4);
	}

	// Token: 0x060000DE RID: 222 RVA: 0x00002888 File Offset: 0x00000A88
	public string method_4(string string_2)
	{
		if (GClass7.dictionary_1.ContainsKey(string_2))
		{
			return GClass7.dictionary_1[string_2];
		}
		return Class16.gclass3_0.method_7(string_2);
	}

	// Token: 0x060000DF RID: 223 RVA: 0x000028AE File Offset: 0x00000AAE
	public bool method_5(string string_2)
	{
		if (!GClass3.smethod_3())
		{
			MessageBox.Show("Badly executed program, you must initialize the application before logging in!", GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
			Environment.Exit(0);
		}
		GClass7.dictionary_0.Add("password", string_2);
		return Class16.gclass3_0.method_6(string_2);
	}

	// Token: 0x060000E0 RID: 224 RVA: 0x000061F0 File Offset: 0x000043F0
	public bool method_6(string string_2)
	{
		if (!GClass3.smethod_3())
		{
			MessageBox.Show("Badly executed program, you must initialize the application before logging in!", GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
			Environment.Exit(0);
			return false;
		}
		if (!GClass3.smethod_19())
		{
			MessageBox.Show("You can only send logs to the server when you are logged in!", GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return false;
		}
		return Class16.gclass3_0.method_8(string_2);
	}

	// Token: 0x060000E1 RID: 225 RVA: 0x000028EB File Offset: 0x00000AEB
	public bool method_7()
	{
		return GClass3.smethod_3();
	}

	// Token: 0x060000E2 RID: 226 RVA: 0x000028F2 File Offset: 0x00000AF2
	public string method_8()
	{
		return GClass3.smethod_7();
	}

	// Token: 0x04000054 RID: 84
	public static GClass3 gclass3_0 = new GClass3();
}
