using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

using MWarzone;


namespace MWarzone
{
	public sealed class GClass5
	{
		// Token: 0x060000B8 RID: 184 RVA: 0x00002641 File Offset: 0x00000841
		public string method_0()
		{
			return new WebClient().DownloadString("http://icanhazip.com/");
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002652 File Offset: 0x00000852
		public string method_1()
		{
			return new GClass5.Class20().method_0();
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00005D64 File Offset: 0x00003F64
		public string method_2(string string_0)
		{
			string result;
			using (MD5 md = MD5.Create())
			{
				using (FileStream fileStream = File.OpenRead(string_0))
				{
					result = BitConverter.ToString(md.ComputeHash(fileStream)).Replace("-", string.Empty).ToLowerInvariant();
				}
			}
			return result;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000265E File Offset: 0x0000085E
		public string method_3(string string_0)
		{
			return BitConverter.ToString(new MD5CryptoServiceProvider().ComputeHash(Encoding.Default.GetBytes(string_0))).Replace("-", string.Empty);
		}

		// Token: 0x02000023 RID: 35
		public sealed class GClass6
		{
			// Token: 0x060000BD RID: 189 RVA: 0x00002689 File Offset: 0x00000889
			public static System.Threading.Timer smethod_0()
			{
				return GClass5.GClass6.timer_0;
			}

			// Token: 0x060000BE RID: 190 RVA: 0x00002690 File Offset: 0x00000890
			public static void smethod_1(System.Threading.Timer timer_1)
			{
				GClass5.GClass6.timer_0 = timer_1;
			}

			// Token: 0x060000BF RID: 191 RVA: 0x00002698 File Offset: 0x00000898
			public string method_0()
			{
				return this.string_0;
			}

			// Token: 0x060000C0 RID: 192 RVA: 0x000026A0 File Offset: 0x000008A0
			public void method_1(string string_1)
			{
				this.string_0 = string_1;
			}

			// Token: 0x060000C1 RID: 193 RVA: 0x000026A9 File Offset: 0x000008A9
			public void method_2()
			{
				this.method_1(this.method_6());
				GClass5.GClass6.smethod_1(new System.Threading.Timer(new TimerCallback(this.method_7), null, 5000, -1));
			}

			// Token: 0x060000C2 RID: 194 RVA: 0x000026D4 File Offset: 0x000008D4
			public void method_3()
			{
				GClass5.GClass6.smethod_0().Dispose();
				if (this.method_6() != this.method_0())
				{
					MessageBox.Show("Security breach detected!, Closing...", GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Environment.Exit(0);
					return;
				}
			}

			// Token: 0x060000C3 RID: 195 RVA: 0x00005DD4 File Offset: 0x00003FD4
			public IPAddress method_4()
			{
				return NetworkInterface.GetAllNetworkInterfaces().Where(new Func<NetworkInterface, bool>(GClass5.GClass6.Class19.class19_0.method_0)).Where(new Func<NetworkInterface, bool>(GClass5.GClass6.Class19.class19_0.method_1)).SelectMany(new Func<NetworkInterface, IEnumerable<GatewayIPAddressInformation>>(GClass5.GClass6.Class19.class19_0.method_2)).Select(new Func<GatewayIPAddressInformation, IPAddress>(GClass5.GClass6.Class19.class19_0.method_3)).FirstOrDefault(new Func<IPAddress, bool>(GClass5.GClass6.Class19.class19_0.method_4));
			}

			// Token: 0x060000C4 RID: 196 RVA: 0x00005E9C File Offset: 0x0000409C
			public string method_5()
			{
				string empty;
				using (Process process = Process.Start(new ProcessStartInfo
				{
					FileName = "C:\\Windows\\System32\\arp.exe",
					Arguments = "-a",
					UseShellExecute = false,
					RedirectStandardOutput = true,
					CreateNoWindow = true
				}))
				{
					if (process != null)
					{
						using (StreamReader standardOutput = process.StandardOutput)
						{
							return standardOutput.ReadToEnd();
						}
					}
					empty = string.Empty;
				}
				return empty;
			}

			// Token: 0x060000C5 RID: 197 RVA: 0x0000270D File Offset: 0x0000090D
			public string method_6()
			{
				return new Regex(string.Format("({0} [\\W]*) ([a-z0-9-]*)", this.method_4())).Match(this.method_5()).Groups[2].ToString();
			}

			// Token: 0x060000C6 RID: 198 RVA: 0x0000273F File Offset: 0x0000093F
			private void method_7(object object_0)
			{
				this.method_3();
			}

			// Token: 0x0400004B RID: 75
			private static System.Threading.Timer timer_0;

			// Token: 0x0400004C RID: 76
			private string string_0;

			// Token: 0x02000024 RID: 36
			[Serializable]
			private sealed class Class19
			{
				// Token: 0x060000C9 RID: 201 RVA: 0x00002753 File Offset: 0x00000953
				internal bool method_0(NetworkInterface networkInterface_0)
				{
					return networkInterface_0.OperationalStatus == OperationalStatus.Up;
				}

				// Token: 0x060000CA RID: 202 RVA: 0x0000275E File Offset: 0x0000095E
				internal bool method_1(NetworkInterface networkInterface_0)
				{
					return networkInterface_0.NetworkInterfaceType != NetworkInterfaceType.Loopback;
				}

				// Token: 0x060000CB RID: 203 RVA: 0x0000276D File Offset: 0x0000096D
				internal IEnumerable<GatewayIPAddressInformation> method_2(NetworkInterface networkInterface_0)
				{
					IPInterfaceProperties ipproperties = networkInterface_0.GetIPProperties();
					if (ipproperties == null)
					{
						return null;
					}
					return ipproperties.GatewayAddresses;
				}

				// Token: 0x060000CC RID: 204 RVA: 0x00002780 File Offset: 0x00000980
				internal IPAddress method_3(GatewayIPAddressInformation gatewayIPAddressInformation_0)
				{
					if (gatewayIPAddressInformation_0 == null)
					{
						return null;
					}
					return gatewayIPAddressInformation_0.Address;
				}

				// Token: 0x060000CD RID: 205 RVA: 0x0000278D File Offset: 0x0000098D
				internal bool method_4(IPAddress ipaddress_0)
				{
					return ipaddress_0 != null;
				}

				// Token: 0x0400004D RID: 77
				public static readonly GClass5.GClass6.Class19 class19_0 = new GClass5.GClass6.Class19();

				// Token: 0x0400004E RID: 78
				public static Func<NetworkInterface, bool> func_0;

				// Token: 0x0400004F RID: 79
				public static Func<NetworkInterface, bool> func_1;

				// Token: 0x04000050 RID: 80
				public static Func<NetworkInterface, IEnumerable<GatewayIPAddressInformation>> func_2;

				// Token: 0x04000051 RID: 81
				public static Func<GatewayIPAddressInformation, IPAddress> func_3;

				// Token: 0x04000052 RID: 82
				public static Func<IPAddress, bool> func_4;
			}
		}

		// Token: 0x02000025 RID: 37
		internal sealed class Class20
		{
			// Token: 0x060000CE RID: 206 RVA: 0x00005F2C File Offset: 0x0000412C
			public Class20()
			{
				string str = this.method_2();
				string str2 = GClass5.Class20.smethod_0();
				string str3 = GClass5.Class20.smethod_2();
				this.method_1(str + str2 + str3);
			}

			// Token: 0x060000CF RID: 207 RVA: 0x00002793 File Offset: 0x00000993
			public string method_0()
			{
				return this.string_0;
			}

			// Token: 0x060000D0 RID: 208 RVA: 0x0000279B File Offset: 0x0000099B
			public void method_1(string string_1)
			{
				this.string_0 = string_1;
			}

			// Token: 0x060000D1 RID: 209 RVA: 0x00005F60 File Offset: 0x00004160
			private string method_2()
			{
				string text = string.Empty;
				foreach (DriveInfo driveInfo in DriveInfo.GetDrives())
				{
					if (driveInfo.IsReady)
					{
						text = driveInfo.RootDirectory.ToString();
					IL_34:
						if (!string.IsNullOrEmpty(text) && text.EndsWith(":\\"))
						{
							text = text.Substring(0, text.Length - 2);
						}
						ManagementObject managementObject = new ManagementObject("win32_logicaldisk.deviceid=\"" + text + ":\"");
						managementObject.Get();
						string result = managementObject["VolumeSerialNumber"].ToString();
						managementObject.Dispose();
						return result;
					}
				}
				goto IL_34;
			}

			// Token: 0x060000D2 RID: 210
			[DllImport("user32", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
			private static extern IntPtr CallWindowProcW([In] byte[] byte_0, IntPtr intptr_0, int int_0, [In][Out] byte[] byte_1, IntPtr intptr_1);

			// Token: 0x060000D3 RID: 211
			[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			public static extern bool VirtualProtect([In] byte[] byte_0, IntPtr intptr_0, int int_0, out int int_1);

			// Token: 0x060000D4 RID: 212 RVA: 0x00005FFC File Offset: 0x000041FC
			public static string smethod_0()
			{
				byte[] value = new byte[8];
				if (GClass5.Class20.smethod_1(ref value))
				{
					return string.Format("{0:X8}{1:X8}", BitConverter.ToUInt32(value, 4), BitConverter.ToUInt32(value, 0));
				}
				return "ND";
			}

			// Token: 0x060000D5 RID: 213 RVA: 0x00006044 File Offset: 0x00004244
			private static bool smethod_1(ref byte[] byte_0)
			{
				byte[] array;
				if (IntPtr.Size == 8)
				{
					array = new byte[]
					{
					83,
					72,
					199,
					192,
					1,
					0,
					0,
					0,
					15,
					162,
					65,
					137,
					0,
					65,
					137,
					80,
					4,
					91,
					195
					};
				}
				else
				{
					array = new byte[]
					{
					85,
					137,
					229,
					87,
					139,
					125,
					16,
					106,
					1,
					88,
					83,
					15,
					162,
					137,
					7,
					137,
					87,
					4,
					91,
					95,
					137,
					236,
					93,
					194,
					16,
					0
					};
				}
				IntPtr intPtr = new IntPtr(array.Length);
				int num;
				if (!GClass5.Class20.VirtualProtect(array, intPtr, 64, out num))
				{
					Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
				}
				intPtr = new IntPtr(byte_0.Length);
				return GClass5.Class20.CallWindowProcW(array, IntPtr.Zero, 0, byte_0, intPtr) != IntPtr.Zero;
			}

			// Token: 0x060000D6 RID: 214 RVA: 0x000060C8 File Offset: 0x000042C8
			public static string smethod_2()
			{
				string text = string.Empty;
				ManagementObjectCollection managementObjectCollection = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_OperatingSystem").Get();
				bool flag = !string.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432"));
				using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = managementObjectCollection.GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						ManagementObject managementObject = (ManagementObject)enumerator.Current;
						object value = managementObject.Properties["Caption"].Value;
						text = ((value != null) ? value.ToString() : null) + Environment.UserName + (string)managementObject.Properties["Version"].Value;
					}
				}
				text = text.Replace(" ", string.Empty).Replace("Windows", string.Empty).Replace("windows", string.Empty);
				text += (flag ? " 64bit" : " 32bit");
				return BitConverter.ToString(MD5.Create().ComputeHash(Encoding.Default.GetBytes(text))).Replace("-", string.Empty);
			}

			// Token: 0x04000053 RID: 83
			private string string_0;
		}
	}
}
