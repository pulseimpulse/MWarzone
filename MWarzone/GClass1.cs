using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

// Token: 0x02000007 RID: 7
public sealed class GClass1
{
	// Token: 0x0600000F RID: 15
	[DllImport("kernel32.dll")]
	public static extern IntPtr OpenProcess(uint uint_0, bool bool_0, int int_1);

	// Token: 0x06000010 RID: 16
	[DllImport("kernel32.dll")]
	public static extern bool CloseHandle(IntPtr intptr_2);

	// Token: 0x06000011 RID: 17
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool ReadProcessMemory(IntPtr intptr_2, long long_0, [In] [Out] byte[] byte_0, ulong ulong_0, out IntPtr intptr_3);

	// Token: 0x06000012 RID: 18
	[DllImport("kernel32.dll")]
	public static extern bool WriteProcessMemory(IntPtr intptr_2, long long_0, [In] [Out] byte[] byte_0, ulong ulong_0, out IntPtr intptr_3);

	// Token: 0x06000013 RID: 19
	[DllImport("kernel32", SetLastError = true)]
	public static extern IntPtr VirtualAllocEx(IntPtr intptr_2, IntPtr intptr_3, uint uint_0, uint uint_1, uint uint_2);

	// Token: 0x06000014 RID: 20
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool VirtualProtectEx(IntPtr intptr_2, IntPtr intptr_3, uint uint_0, uint uint_1, out uint uint_2);

	// Token: 0x06000015 RID: 21 RVA: 0x000029F4 File Offset: 0x00000BF4
	~GClass1()
	{
		if (this.intptr_0 != IntPtr.Zero)
		{
			GClass1.CloseHandle(this.intptr_0);
		}
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00002A38 File Offset: 0x00000C38
	public bool method_0(string string_1)
	{
		Process[] processesByName = Process.GetProcessesByName(string_1);
		if (processesByName.Length != 0)
		{
			this.intptr_1 = processesByName[0].MainModule.BaseAddress;
			this.process_0 = processesByName[0];
			this.int_0 = processesByName[0].Id;
			this.string_0 = string_1;
			this.intptr_0 = GClass1.OpenProcess(56U, false, this.int_0);
			return this.intptr_0 != IntPtr.Zero;
		}
		return false;
	}

	// Token: 0x06000017 RID: 23 RVA: 0x000020E6 File Offset: 0x000002E6
	public bool method_1()
	{
		return !(this.string_0 == string.Empty) && this.method_0(this.string_0);
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00002AAC File Offset: 0x00000CAC
	internal static IntPtr smethod_0(string string_1)
	{
		IntPtr result;
		try
		{
			result = Process.GetProcessesByName(string_1)[0].MainModule.BaseAddress;
		}
		catch
		{
			result = IntPtr.Zero;
		}
		return result;
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00002AE8 File Offset: 0x00000CE8
	public long method_2(long long_0, long long_1, string string_1, string string_2)
	{
		byte[] array = new byte[long_1 - long_0];
		IntPtr intPtr;
		GClass1.ReadProcessMemory(this.intptr_0, long_0, array, (ulong)((long)array.Length), out intPtr);
		for (long num = 0L; num < (long)array.Length; num += 1L)
		{
			int num2 = 0;
			while (num2 < string_1.Length && ((char)array[(int)(checked((IntPtr)(unchecked(num + (long)num2))))] == string_1[num2] || string_2[num2] == '?'))
			{
				if (num2 == string_1.Length - 1)
				{
					return long_0 + num;
				}
				num2++;
			}
		}
		return -1L;
	}

	// Token: 0x0600001A RID: 26
	[DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory")]
	protected static extern bool ReadProcessMemory_1(IntPtr intptr_2, IntPtr intptr_3, byte[] byte_0, uint uint_0, int int_1);

	// Token: 0x0600001B RID: 27 RVA: 0x00002B7C File Offset: 0x00000D7C
	private static byte[] smethod_1(string string_1)
	{
		string_1 = Regex.Replace(string_1, "[^a-fA-F0-9?]", string.Empty);
		if (string_1.Length % 2 != 0)
		{
			string_1 = string_1.Substring(0, string_1.Length - 1);
		}
		byte[] array = new byte[string_1.Length / 2];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = ((string_1.Substring(i * 2, 2) != "??") ? byte.Parse(string_1.Substring(i * 2, 2), NumberStyles.HexNumber) : 63);
		}
		return array;
	}

	// Token: 0x0600001C RID: 28
	[DllImport("kernel32.dll", EntryPoint = "WriteProcessMemory")]
	private static extern bool WriteProcessMemory_1(IntPtr intptr_2, IntPtr intptr_3, byte[] byte_0, uint uint_0, [Out] int int_1);

	// Token: 0x0600001D RID: 29
	[DllImport("kernel32")]
	public static extern IntPtr CreateRemoteThread(IntPtr intptr_2, IntPtr intptr_3, uint uint_0, IntPtr intptr_4, IntPtr intptr_5, uint uint_1, out IntPtr intptr_6);

	// Token: 0x0600001E RID: 30
	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern bool VirtualFreeEx(IntPtr intptr_2, IntPtr intptr_3, UIntPtr uintptr_0, uint uint_0);

	// Token: 0x0600001F RID: 31 RVA: 0x00002C04 File Offset: 0x00000E04
	public int method_3(long long_0, long[] long_1, int int_1)
	{
		long long_2 = long_0;
		for (int i = 0; i < int_1; i++)
		{
			long_2 = this.method_7(long_2) + long_1[i];
		}
		return this.method_5(long_2);
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00002C34 File Offset: 0x00000E34
	public long method_4(long long_0, long[] long_1, int int_1)
	{
		long num = long_0;
		for (int i = 0; i < int_1; i++)
		{
			num = this.method_7(num) + long_1[i];
		}
		return num;
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00002C5C File Offset: 0x00000E5C
	public int method_5(long long_0)
	{
		byte[] array = new byte[4];
		IntPtr intPtr;
		GClass1.ReadProcessMemory(this.intptr_0, long_0, array, 4UL, out intPtr);
		return BitConverter.ToInt32(array, 0);
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00002C90 File Offset: 0x00000E90
	public uint method_6(long long_0)
	{
		byte[] array = new byte[4];
		IntPtr intPtr;
		GClass1.ReadProcessMemory(this.intptr_0, long_0, array, 4UL, out intPtr);
		return BitConverter.ToUInt32(array, 0);
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00002CC4 File Offset: 0x00000EC4
	public long method_7(long long_0)
	{
		byte[] array = new byte[8];
		IntPtr intPtr;
		GClass1.ReadProcessMemory(this.intptr_0, long_0, array, 8UL, out intPtr);
		return BitConverter.ToInt64(array, 0);
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00002CF8 File Offset: 0x00000EF8
	public ulong method_8(long long_0)
	{
		byte[] array = new byte[8];
		IntPtr intPtr;
		GClass1.ReadProcessMemory(this.intptr_0, long_0, array, 8UL, out intPtr);
		return BitConverter.ToUInt64(array, 0);
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00002D2C File Offset: 0x00000F2C
	public float method_9(long long_0)
	{
		byte[] array = new byte[4];
		IntPtr intPtr;
		GClass1.ReadProcessMemory(this.intptr_0, long_0, array, 4UL, out intPtr);
		return BitConverter.ToSingle(array, 0);
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00002D60 File Offset: 0x00000F60
	public string method_10(long long_0, ulong ulong_0)
	{
		byte[] array = new byte[ulong_0];
		IntPtr intPtr;
		GClass1.ReadProcessMemory(this.intptr_0, long_0, array, ulong_0, out intPtr);
		return Encoding.UTF8.GetString(array);
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00002D94 File Offset: 0x00000F94
	public void method_11(long long_0, byte[] byte_0)
	{
		uint num;
		GClass1.VirtualProtectEx(this.intptr_0, (IntPtr)long_0, (uint)byte_0.Length, 4U, out num);
		IntPtr intPtr;
		GClass1.WriteProcessMemory(this.intptr_0, long_0, byte_0, (ulong)byte_0.Length, out intPtr);
	}

	// Token: 0x06000028 RID: 40 RVA: 0x00002DD0 File Offset: 0x00000FD0
	public void method_12(long long_0, int int_1)
	{
		byte[] bytes = BitConverter.GetBytes(int_1);
		this.method_11(long_0, bytes);
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00002DEC File Offset: 0x00000FEC
	public void method_13(long long_0, long long_1)
	{
		byte[] bytes = BitConverter.GetBytes(long_1);
		this.method_11(long_0, bytes);
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00002E08 File Offset: 0x00001008
	public void method_14(long long_0, uint uint_0)
	{
		byte[] bytes = BitConverter.GetBytes(uint_0);
		this.method_11(long_0, bytes);
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00002E24 File Offset: 0x00001024
	public void method_15(long long_0, float float_0)
	{
		byte[] bytes = BitConverter.GetBytes(float_0);
		this.method_11(long_0, bytes);
	}

	// Token: 0x0600002C RID: 44 RVA: 0x00002E40 File Offset: 0x00001040
	public void method_16(long long_0, byte byte_0)
	{
		byte[] bytes = BitConverter.GetBytes((short)byte_0);
		IntPtr zero = IntPtr.Zero;
		GClass1.WriteProcessMemory(this.intptr_0, long_0, bytes, (ulong)(bytes.Length - 1), out zero);
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00002E70 File Offset: 0x00001070
	public void method_17(long long_0, byte[] byte_0)
	{
		IntPtr zero = IntPtr.Zero;
		GClass1.WriteProcessMemory(this.intptr_0, long_0, byte_0, (ulong)byte_0.Length, out zero);
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00002E9C File Offset: 0x0000109C
	public void method_18(long long_0, string string_1)
	{
		byte[] bytes = new ASCIIEncoding().GetBytes(string_1);
		IntPtr zero = IntPtr.Zero;
		GClass1.WriteProcessMemory(this.intptr_0, long_0, bytes, (ulong)this.method_10(long_0, 1024UL).Length, out zero);
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00002EE4 File Offset: 0x000010E4
	public void method_19(long long_0)
	{
		byte[] array = new byte[]
		{
			144,
			144,
			144,
			144,
			144
		};
		IntPtr zero = IntPtr.Zero;
		GClass1.WriteProcessMemory(this.intptr_0, long_0, array, (ulong)array.Length, out zero);
	}

	// Token: 0x0400000A RID: 10
	private Process process_0;

	// Token: 0x0400000B RID: 11
	private IntPtr intptr_0;

	// Token: 0x0400000C RID: 12
	private string string_0;

	// Token: 0x0400000D RID: 13
	private int int_0;

	// Token: 0x0400000E RID: 14
	public IntPtr intptr_1;
}
