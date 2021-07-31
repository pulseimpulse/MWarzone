using System;
using System.Security.Cryptography;

// Token: 0x0200000B RID: 11
internal sealed class Class15 : Class14
{
	// Token: 0x06000041 RID: 65 RVA: 0x00002210 File Offset: 0x00000410
	internal byte[] method_0(byte[] byte_0)
	{
		return ((RSACryptoServiceProvider)Class14.x509Certificate2_0.PublicKey.Key).Encrypt(byte_0, false);
	}
}
