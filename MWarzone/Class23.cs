using System;
using System.IO;
using System.Net;
using System.Text;

// Token: 0x0200002B RID: 43
internal sealed class Class23
{
	// Token: 0x060000ED RID: 237 RVA: 0x00002967 File Offset: 0x00000B67
	internal Class23()
	{
		Class23.cookieContainer_0 = new CookieContainer();
	}

	// Token: 0x060000EE RID: 238 RVA: 0x00006DA4 File Offset: 0x00004FA4
	internal string method_0(string string_0, string string_1)
	{
		string result;
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(string_1);
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_0);
			httpWebRequest.Method = "POST";
			httpWebRequest.ContentType = "application/x-www-form-urlencoded";
			httpWebRequest.ContentLength = (long)bytes.Length;
			httpWebRequest.CookieContainer = Class23.cookieContainer_0;
			Stream requestStream = httpWebRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
			result = new StreamReader(((HttpWebResponse)httpWebRequest.GetResponse()).GetResponseStream()).ReadToEnd();
		}
		catch (Exception ex)
		{
			result = "ERROR: " + ex.Message;
		}
		return result;
	}

	// Token: 0x04000065 RID: 101
	private static CookieContainer cookieContainer_0;
}
