using System;

// Token: 0x02000029 RID: 41
internal sealed class Class21
{
	// Token: 0x060000EB RID: 235 RVA: 0x00002933 File Offset: 0x00000B33
	internal static string smethod_0(byte[] byte_0)
	{
		return Convert.ToBase64String(byte_0).Replace('+', '-').Replace('/', '_');
	}

	// Token: 0x060000EC RID: 236 RVA: 0x0000294D File Offset: 0x00000B4D
	internal static byte[] smethod_1(string string_0)
	{
		return Convert.FromBase64String(string_0.Replace('-', '+').Replace('_', '/'));
	}
}
