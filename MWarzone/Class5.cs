using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;

// Token: 0x02000012 RID: 18
internal static class Class5
{
	// Token: 0x06000060 RID: 96 RVA: 0x00003DD4 File Offset: 0x00001FD4
	internal static long smethod_0()
	{
		if (Assembly.GetCallingAssembly() == typeof(Class5).Assembly && Class5.smethod_1())
		{
			long result;
			lock (Class5.class11_0)
			{
				long num = Class5.class11_0.method_0();
				if (num == 0L)
				{
					Assembly executingAssembly = Assembly.GetExecutingAssembly();
					List<byte> list = new List<byte>();
					AssemblyName assemblyName;
					try
					{
						assemblyName = executingAssembly.GetName();
					}
					catch
					{
						assemblyName = new AssemblyName(executingAssembly.FullName);
					}
					byte[] array = assemblyName.GetPublicKeyToken();
					if (array != null && array.Length == 0)
					{
						array = null;
					}
					if (array != null)
					{
						list.AddRange(array);
					}
					list.AddRange(Encoding.Unicode.GetBytes(assemblyName.Name));
					int num2 = Class5.smethod_3(typeof(Class5));
					int num3 = Class5.Class10.smethod_0();
					list.Add((byte)(num2 >> 16));
					list.Add((byte)(num3 >> 8));
					list.Add((byte)(num2 >> 8));
					list.Add((byte)(num3 >> 24));
					list.Add((byte)num2);
					list.Add((byte)(num3 >> 16));
					list.Add((byte)(num2 >> 24));
					list.Add((byte)num3);
					int count = list.Count;
					ulong num4 = 0UL;
					for (int num5 = 0; num5 != count; num5++)
					{
						num4 += (ulong)list[num5];
						num4 += num4 << 20;
						num4 ^= num4 >> 12;
						list[num5] = 0;
					}
					num4 += num4 << 6;
					num4 ^= num4 >> 22;
					num4 += num4 << 30;
					num = (long)num4;
					num ^= -5672935062595371522L;
					Class5.class11_0.method_1(num);
				}
				result = num;
			}
			return result;
		}
		return 0L;
	}

	// Token: 0x06000061 RID: 97 RVA: 0x00002321 File Offset: 0x00000521
	private static bool smethod_1()
	{
		return Class5.smethod_2();
	}

	// Token: 0x06000062 RID: 98 RVA: 0x00003FB8 File Offset: 0x000021B8
	private static bool smethod_2()
	{
		StackTrace stackTrace = new StackTrace();
		StackFrame frame = stackTrace.GetFrame(3);
		MethodBase methodBase = (frame == null) ? null : frame.GetMethod();
		Type type = (methodBase == null) ? null : methodBase.DeclaringType;
		return type != typeof(RuntimeMethodHandle) && type != null && type.Assembly == typeof(Class5).Assembly;
	}

	// Token: 0x06000063 RID: 99 RVA: 0x0000232D File Offset: 0x0000052D
	private static int smethod_3(Type type_0)
	{
		return type_0.MetadataToken;
	}

	// Token: 0x04000024 RID: 36
	private static Class5.Class11 class11_0 = new Class5.Class11();

	// Token: 0x02000013 RID: 19
	private static class Class6
	{
		// Token: 0x06000064 RID: 100 RVA: 0x00002335 File Offset: 0x00000535
		internal static int smethod_0(int int_0, int int_1)
		{
			return int_0 ^ int_1 - 1292900551;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002340 File Offset: 0x00000540
		internal static int smethod_1(int int_0, int int_1)
		{
			return int_0 - -1401859965 ^ int_1 + -1267710582;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002351 File Offset: 0x00000551
		internal static int smethod_2(int int_0, int int_1)
		{
			return int_0 ^ (int_1 - 1968157956 ^ int_0 - int_1);
		}
	}

	// Token: 0x02000014 RID: 20
	private sealed class Class7
	{
		// Token: 0x06000068 RID: 104 RVA: 0x0000401C File Offset: 0x0000221C
		internal static int smethod_0()
		{
			return Class5.Class6.smethod_2(Class5.Class6.smethod_0(Class5.Class9.smethod_0() ^ 527758446, Class5.smethod_3(typeof(Class5.Class8))), Class5.Class6.smethod_1(Class5.smethod_3(typeof(Class5.Class10)) ^ Class5.smethod_3(typeof(Class5.Class13)), -2116799818));
		}
	}

	// Token: 0x02000015 RID: 21
	private sealed class Class8
	{
		// Token: 0x0600006A RID: 106 RVA: 0x00004078 File Offset: 0x00002278
		internal static int smethod_0()
		{
			return Class5.Class6.smethod_2(Class5.smethod_3(typeof(Class5.Class8)), Class5.Class6.smethod_0(Class5.smethod_3(typeof(Class5.Class10)), Class5.Class6.smethod_1(Class5.smethod_3(typeof(Class5.Class9)), Class5.Class6.smethod_2(Class5.smethod_3(typeof(Class5.Class7)), Class5.Class6.smethod_0(Class5.smethod_3(typeof(Class5.Class12)), Class5.smethod_3(typeof(Class5.Class13)))))));
		}
	}

	// Token: 0x02000016 RID: 22
	private sealed class Class9
	{
		// Token: 0x0600006C RID: 108 RVA: 0x000040F8 File Offset: 0x000022F8
		internal static int smethod_0()
		{
			return Class5.Class6.smethod_0(Class5.smethod_3(typeof(Class5.Class7)), Class5.smethod_3(typeof(Class5.Class8)) ^ Class5.Class6.smethod_1(Class5.smethod_3(typeof(Class5.Class9)), Class5.Class6.smethod_2(Class5.smethod_3(typeof(Class5.Class13)), Class5.Class8.smethod_0())));
		}
	}

	// Token: 0x02000017 RID: 23
	private sealed class Class10
	{
		// Token: 0x0600006E RID: 110 RVA: 0x00004158 File Offset: 0x00002358
		internal static int smethod_0()
		{
			return Class5.Class6.smethod_2(Class5.Class6.smethod_1(Class5.smethod_3(typeof(Class5.Class9)), Class5.Class6.smethod_2(Class5.smethod_3(typeof(Class5.Class10)), Class5.smethod_3(typeof(Class5.Class12)))), Class5.Class13.smethod_0());
		}
	}

	// Token: 0x02000018 RID: 24
	private sealed class Class11
	{
		// Token: 0x0600006F RID: 111 RVA: 0x00002360 File Offset: 0x00000560
		internal Class11()
		{
			this.method_1(0L);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000041A8 File Offset: 0x000023A8
		internal long method_0()
		{
			if (Assembly.GetCallingAssembly() != typeof(Class5.Class11).Assembly)
			{
				return 2918384L;
			}
			if (!Class5.smethod_1())
			{
				return 2918384L;
			}
			int[] array = new int[]
			{
				0,
				0,
				0,
				1889906931
			};
			array[1] = -1374233562;
			array[2] = -184908254;
			array[0] = 23649612;
			int num = this.int_0;
			int num2 = this.int_1;
			int num3 = -1640531527;
			int num4 = -957401312;
			for (int num5 = 0; num5 != 32; num5++)
			{
				num2 -= ((num << 4 ^ num >> 5) + num ^ num4 + array[num4 >> 11 & 3]);
				num4 -= num3;
				num -= ((num2 << 4 ^ num2 >> 5) + num2 ^ num4 + array[num4 & 3]);
			}
			for (int num6 = 0; num6 != 4; num6++)
			{
				array[num6] = 0;
			}
			ulong num7 = (ulong)((ulong)((long)num2) << 32);
			return (long)(num7 | (ulong)num);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00004290 File Offset: 0x00002490
		internal void method_1(long long_0)
		{
			if (Assembly.GetCallingAssembly() != typeof(Class5.Class11).Assembly)
			{
				return;
			}
			if (!Class5.smethod_1())
			{
				return;
			}
			int[] array = new int[4];
			array[1] = -1374233562;
			array[0] = 23649612;
			array[2] = -184908254;
			array[3] = 1889906931;
			int num = -1640531527;
			int num2 = (int)long_0;
			int num3 = (int)(long_0 >> 32);
			int num4 = 0;
			for (int num5 = 0; num5 != 32; num5++)
			{
				num2 += ((num3 << 4 ^ num3 >> 5) + num3 ^ num4 + array[num4 & 3]);
				num4 += num;
				num3 += ((num2 << 4 ^ num2 >> 5) + num2 ^ num4 + array[num4 >> 11 & 3]);
			}
			for (int num6 = 0; num6 != 4; num6++)
			{
				array[num6] = 0;
			}
			this.int_0 = num2;
			this.int_1 = num3;
		}

		// Token: 0x04000025 RID: 37
		private int int_0;

		// Token: 0x04000026 RID: 38
		private int int_1;
	}

	// Token: 0x02000019 RID: 25
	private sealed class Class12
	{
		// Token: 0x06000073 RID: 115 RVA: 0x00002377 File Offset: 0x00000577
		internal static int smethod_0()
		{
			return Class5.Class6.smethod_1(Class5.Class6.smethod_1(Class5.Class7.smethod_0(), Class5.Class6.smethod_0(Class5.smethod_3(typeof(Class5.Class12)), Class5.Class9.smethod_0())), Class5.smethod_3(typeof(Class5.Class13)));
		}
	}

	// Token: 0x0200001A RID: 26
	private sealed class Class13
	{
		// Token: 0x06000075 RID: 117 RVA: 0x0000435C File Offset: 0x0000255C
		internal static int smethod_0()
		{
			return Class5.Class6.smethod_0(Class5.smethod_3(typeof(Class5.Class13)), Class5.Class6.smethod_2(Class5.Class6.smethod_1(Class5.smethod_3(typeof(Class5.Class12)), Class5.smethod_3(typeof(Class5.Class10))), Class5.Class6.smethod_2(Class5.smethod_3(typeof(Class5.Class7)) ^ 478204594, Class5.Class12.smethod_0())));
		}
	}
}
