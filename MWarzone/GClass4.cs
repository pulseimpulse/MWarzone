using MWarzone;
using System;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

// Token: 0x02000010 RID: 16
public sealed class GClass4 : GClass3
{
	// Token: 0x06000059 RID: 89 RVA: 0x00003CB8 File Offset: 0x00001EB8
	public void method_9()
	{
		if (GClass3.smethod_1())
		{
			MessageBox.Show("Session already started, closing for security reasons...", GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
			Environment.Exit(0);
			return;
		}
		string path = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\drivers\\etc\\hosts";
		if (File.Exists(path))
		{
			StreamReader streamReader = new StreamReader(path);
			try
			{
				if (streamReader.ReadToEnd().Contains("authenty.me"))
				{
					MessageBox.Show("DNS redirection found, closing the application...", GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Environment.Exit(0);
				}
			}
			finally
			{
				((IDisposable)streamReader).Dispose();
			}
		}
		new GClass5.GClass6().method_2();
		GClass3.smethod_2(true);
		ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, new RemoteCertificateValidationCallback(this.method_11));
	}

	// Token: 0x0600005A RID: 90 RVA: 0x00003D7C File Offset: 0x00001F7C
	public void method_10()
	{
		if (!GClass3.smethod_1())
		{
			MessageBox.Show("The session hasn't started yet, closing for security reasons...", GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
			Environment.Exit(0);
		}
		GClass3.smethod_2(false);
		ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(GClass4.Class4.class4_0.method_0);
	}

	// Token: 0x0600005B RID: 91 RVA: 0x000022D3 File Offset: 0x000004D3
	private bool method_11(object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0)
	{
		if (x509Certificate_0 != null && x509Certificate_0.GetPublicKeyString() == Class14.smethod_0())
		{
			return true;
		}
		MessageBox.Show("Error when establishing a secure SSL connection with the server.", GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
		Environment.Exit(0);
		return false;
	}

	// Token: 0x02000011 RID: 17
	[Serializable]
	private sealed class Class4
	{
		// Token: 0x0600005E RID: 94 RVA: 0x00002312 File Offset: 0x00000512
		internal bool method_0(object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0)
		{
			return true;
		}

		// Token: 0x04000022 RID: 34
		public static readonly GClass4.Class4 class4_0 = new GClass4.Class4();

		// Token: 0x04000023 RID: 35
		public static RemoteCertificateValidationCallback remoteCertificateValidationCallback_0;
	}
}
