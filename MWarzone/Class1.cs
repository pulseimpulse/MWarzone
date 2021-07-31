using System;
using System.IO;
using System.Security.Cryptography;

// Token: 0x02000009 RID: 9
internal sealed class Class1
{
	// Token: 0x06000031 RID: 49 RVA: 0x0000210D File Offset: 0x0000030D
	internal Class1()
	{
		this.byte_0 = new byte[32];
		this.byte_1 = new byte[16];
		this.method_2();
	}

	// Token: 0x06000032 RID: 50 RVA: 0x00002135 File Offset: 0x00000335
	internal byte[] method_0()
	{
		return this.byte_0;
	}

	// Token: 0x06000033 RID: 51 RVA: 0x0000213D File Offset: 0x0000033D
	internal byte[] method_1()
	{
		return this.byte_1;
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00002145 File Offset: 0x00000345
	internal void method_2()
	{
		RNGCryptoServiceProvider rngcryptoServiceProvider = new RNGCryptoServiceProvider();
		rngcryptoServiceProvider.GetBytes(this.method_0());
		rngcryptoServiceProvider.GetBytes(this.method_1());
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00002F20 File Offset: 0x00001120
	internal string method_3(string string_0)
	{
		string result;
		try
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged
			{
				Padding = PaddingMode.PKCS7,
				Mode = CipherMode.CBC,
				KeySize = 256,
				Key = this.method_0(),
				IV = this.method_1()
			};
			ICryptoTransform transform = rijndaelManaged.CreateEncryptor(rijndaelManaged.Key, rijndaelManaged.IV);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			StreamWriter streamWriter = new StreamWriter(cryptoStream);
			streamWriter.Write(string_0);
			streamWriter.Close();
			cryptoStream.Close();
			rijndaelManaged.Clear();
			result = Class21.smethod_0(memoryStream.ToArray());
		}
		catch (Exception inner)
		{
			throw new CryptographicException("Problem trying to encrypt.", inner);
		}
		return result;
	}

	// Token: 0x06000036 RID: 54 RVA: 0x00002FCC File Offset: 0x000011CC
	internal string method_4(string string_0)
	{
		string result;
		try
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged
			{
				Padding = PaddingMode.PKCS7,
				Mode = CipherMode.CBC,
				KeySize = 256,
				Key = this.method_0(),
				IV = this.method_1()
			};
			ICryptoTransform transform = rijndaelManaged.CreateDecryptor(rijndaelManaged.Key, rijndaelManaged.IV);
			MemoryStream memoryStream = new MemoryStream(Class21.smethod_1(string_0));
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read);
			StreamReader streamReader = new StreamReader(cryptoStream);
			string text = streamReader.ReadToEnd();
			streamReader.Close();
			cryptoStream.Close();
			memoryStream.Close();
			rijndaelManaged.Clear();
			result = text;
		}
		catch (Exception inner)
		{
			throw new CryptographicException("Problem trying to decrypt.", inner);
		}
		return result;
	}

	// Token: 0x0400000F RID: 15
	private readonly byte[] byte_0;

	// Token: 0x04000010 RID: 16
	private readonly byte[] byte_1;
}
