using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Web.Script.Serialization;
using System.Windows.Forms;

// Token: 0x02000020 RID: 32
public class GClass3
{
	// Token: 0x0600008C RID: 140 RVA: 0x000024E0 File Offset: 0x000006E0
	public static GClass7 smethod_0()
	{
		return GClass3.gclass7_0;
	}

	// Token: 0x0600008D RID: 141 RVA: 0x000024E7 File Offset: 0x000006E7
	public static bool smethod_1()
	{
		return GClass3.bool_0;
	}

	// Token: 0x0600008E RID: 142 RVA: 0x000024EE File Offset: 0x000006EE
	public static void smethod_2(bool bool_9)
	{
		GClass3.bool_0 = bool_9;
	}

	// Token: 0x0600008F RID: 143 RVA: 0x000024F6 File Offset: 0x000006F6
	public static bool smethod_3()
	{
		return GClass3.bool_1;
	}

	// Token: 0x06000090 RID: 144 RVA: 0x000024FD File Offset: 0x000006FD
	public static void smethod_4(bool bool_9)
	{
		GClass3.bool_1 = bool_9;
	}

	// Token: 0x06000091 RID: 145 RVA: 0x00002505 File Offset: 0x00000705
	public static bool smethod_5()
	{
		return GClass3.bool_2;
	}

	// Token: 0x06000092 RID: 146 RVA: 0x0000250C File Offset: 0x0000070C
	public static void smethod_6(bool bool_9)
	{
		GClass3.bool_2 = bool_9;
	}

	// Token: 0x06000093 RID: 147 RVA: 0x00002514 File Offset: 0x00000714
	public static string smethod_7()
	{
		return GClass3.string_0;
	}

	// Token: 0x06000094 RID: 148 RVA: 0x0000251B File Offset: 0x0000071B
	public static void smethod_8(string string_5)
	{
		GClass3.string_0 = string_5;
	}

	// Token: 0x06000095 RID: 149 RVA: 0x00002523 File Offset: 0x00000723
	public static string smethod_9()
	{
		return GClass3.string_1;
	}

	// Token: 0x06000096 RID: 150 RVA: 0x0000252A File Offset: 0x0000072A
	public static void smethod_10(string string_5)
	{
		GClass3.string_1 = string_5;
	}

	// Token: 0x06000097 RID: 151 RVA: 0x00002532 File Offset: 0x00000732
	public static bool smethod_11()
	{
		return GClass3.bool_3;
	}

	// Token: 0x06000098 RID: 152 RVA: 0x00002539 File Offset: 0x00000739
	public static void smethod_12(bool bool_9)
	{
		GClass3.bool_3 = bool_9;
	}

	// Token: 0x06000099 RID: 153 RVA: 0x00002541 File Offset: 0x00000741
	public static string smethod_13()
	{
		return GClass3.string_2;
	}

	// Token: 0x0600009A RID: 154 RVA: 0x00002548 File Offset: 0x00000748
	public static void smethod_14(string string_5)
	{
		GClass3.string_2 = string_5;
	}

	// Token: 0x0600009B RID: 155 RVA: 0x00002550 File Offset: 0x00000750
	public static string smethod_15()
	{
		return GClass3.string_3;
	}

	// Token: 0x0600009C RID: 156 RVA: 0x00002557 File Offset: 0x00000757
	public static void smethod_16(string string_5)
	{
		GClass3.string_3 = string_5;
	}

	// Token: 0x0600009D RID: 157 RVA: 0x0000255F File Offset: 0x0000075F
	public static string smethod_17()
	{
		return GClass3.string_4;
	}

	// Token: 0x0600009E RID: 158 RVA: 0x00002566 File Offset: 0x00000766
	public static void smethod_18(string string_5)
	{
		GClass3.string_4 = string_5;
	}

	// Token: 0x0600009F RID: 159 RVA: 0x0000256E File Offset: 0x0000076E
	public static bool smethod_19()
	{
		return GClass3.bool_4;
	}

	// Token: 0x060000A0 RID: 160 RVA: 0x00002575 File Offset: 0x00000775
	public static void smethod_20(bool bool_9)
	{
		GClass3.bool_4 = bool_9;
	}

	// Token: 0x060000A1 RID: 161 RVA: 0x0000257D File Offset: 0x0000077D
	public static bool smethod_21()
	{
		return GClass3.bool_5;
	}

	// Token: 0x060000A2 RID: 162 RVA: 0x00002584 File Offset: 0x00000784
	public static void smethod_22(bool bool_9)
	{
		GClass3.bool_5 = bool_9;
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x0000258C File Offset: 0x0000078C
	public static bool smethod_23()
	{
		return GClass3.bool_6;
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x00002593 File Offset: 0x00000793
	public static void smethod_24(bool bool_9)
	{
		GClass3.bool_6 = bool_9;
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x0000259B File Offset: 0x0000079B
	public static bool smethod_25()
	{
		return GClass3.bool_7;
	}

	// Token: 0x060000A6 RID: 166 RVA: 0x000025A2 File Offset: 0x000007A2
	public static void smethod_26(bool bool_9)
	{
		GClass3.bool_7 = bool_9;
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x000025AA File Offset: 0x000007AA
	public static bool smethod_27()
	{
		return GClass3.bool_8;
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x000025B1 File Offset: 0x000007B1
	public static void smethod_28(bool bool_9)
	{
		GClass3.bool_8 = bool_9;
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x000025B9 File Offset: 0x000007B9
	public void method_0()
	{
		GClass3.gclass4_0.method_9();
		ServicePointManager.Expect100Continue = true;
		ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		this.method_1();
		GClass3.gclass4_0.method_10();
		this.method_2();
	}

	// Token: 0x060000AA RID: 170 RVA: 0x00004DF4 File Offset: 0x00002FF4
	private void method_1()
	{
		this.class1_0.method_2();
		string text = GClass3.class23_0.method_0(Class14.string_1, "session_key=" + Class21.smethod_0(this.class15_0.method_0(this.class1_0.method_0())) + "&session_iv=" + Class21.smethod_0(this.class15_0.method_0(this.class1_0.method_1())));
		GClass3.smethod_4(this.class1_0.method_4(text) == "AES OK");
	}

	// Token: 0x060000AB RID: 171 RVA: 0x00004E7C File Offset: 0x0000307C
	private void method_2()
	{
		if (!GClass3.smethod_3())
		{
			MessageBox.Show("The connection is not totally secure and encrypted!", GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
			Environment.Exit(0);
			return;
		}
		JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
		Class1 @class = this.class1_0;
		Class23 class2 = GClass3.class23_0;
		string text = Class14.string_1 + "?initialize";
		string str = "data=";
		Class1 class3 = this.class1_0;
		JavaScriptSerializer javaScriptSerializer2 = new JavaScriptSerializer();
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary["application_key"] = GClass3.smethod_13();
		dictionary["application_id"] = GClass3.smethod_17();
		Dictionary<string, object> dictionary2 = javaScriptSerializer.DeserializeObject(@class.method_4(class2.method_0(text, str + class3.method_3(javaScriptSerializer2.Serialize(dictionary))))) as Dictionary<string, object>;
		string a = GClass3.gclass5_0.method_3((string)dictionary2["status"]);
		if (a == "260CA9DD8A4577FC00B7BD5810298076")
		{
			GClass2.smethod_0(dictionary2);
			if (!GClass2.smethod_5())
			{
				MessageBox.Show("Program disabled by the administrator.", GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Environment.Exit(0);
			}
			if (GClass2.smethod_15() && GClass2.smethod_1() != GClass2.smethod_1())
			{
				Console.ForegroundColor = ConsoleColor.Cyan;
				MessageBox.Show("There is a new update found! | [" + GClass2.smethod_1() + "]", GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				Console.ResetColor();
				Process.Start((!GClass2.smethod_17().Contains("http") || !GClass2.smethod_17().Contains("://")) ? ("https://" + GClass2.smethod_17()) : GClass2.smethod_17());
				Environment.Exit(0);
			}
			if (GClass2.smethod_7())
			{
				if (string.IsNullOrEmpty(GClass2.smethod_9()))
				{
					MessageBox.Show("No hashes found to check application integrity!", GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Environment.Exit(0);
				}
				else if (GClass3.gclass5_0.method_2(Assembly.GetEntryAssembly().Location) != GClass2.smethod_9() && !GClass2.smethod_11())
				{
					MessageBox.Show("The hash of this application does not match the hash uploaded to the server!, if you think this is a mistake, contact your developer.", GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Environment.Exit(0);
				}
				else if (GClass3.gclass5_0.method_2(Assembly.GetEntryAssembly().Location) != GClass2.smethod_9() && GClass2.smethod_11())
				{
					File.AppendAllText("integrity.txt", GClass3.gclass5_0.method_2(Assembly.GetEntryAssembly().Location) + Environment.NewLine);
					MessageBox.Show("The hash of this application was saved in the text : hash.txt !", GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			if (GClass2.smethod_3())
			{
				MessageBox.Show("Free mode activated!", GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			GClass3.smethod_6(true);
			return;
		}
		if (!(a == "CB5E100E5A9A3E7F6D1FD97512215282"))
		{
			return;
		}
		MessageBox.Show((string)dictionary2["info"], GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
		Environment.Exit(0);
	}

	// Token: 0x060000AC RID: 172 RVA: 0x0000512C File Offset: 0x0000332C
	internal bool method_3(string string_5, string string_6)
	{
		if (GClass3.smethod_3())
		{
			JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
			Class1 @class = this.class1_0;
			Class23 class2 = GClass3.class23_0;
			string text = Class14.string_1 + "?login";
			string str = "data=";
			Class1 class3 = this.class1_0;
			JavaScriptSerializer javaScriptSerializer2 = new JavaScriptSerializer();
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary["username"] = string_5;
			dictionary["password"] = string_6;
			dictionary["hwid"] = GClass3.gclass5_0.method_1();
			dictionary["date"] = DateTime.Now.ToString();
			dictionary["application_key"] = GClass3.smethod_13();
			dictionary["application_id"] = GClass3.smethod_17();
			Dictionary<string, object> dictionary2 = javaScriptSerializer.DeserializeObject(@class.method_4(class2.method_0(text, str + class3.method_3(javaScriptSerializer2.Serialize(dictionary))))) as Dictionary<string, object>;
			string a = (string)dictionary2["status"];
			if (!(a == "incorrect_hwid"))
			{
				if (!(a == "hwid_reseted"))
				{
					if (!(a == "incorrect_details"))
					{
						if (!(a == "expired_time"))
						{
							if (!(a == "banned_user"))
							{
								if (a == "success")
								{
									GClass0.smethod_1((string)dictionary2["username"]);
									GClass0.smethod_11((string)dictionary2["hwid"]);
									GClass0.smethod_3((string)dictionary2["license"]);
									GClass0.smethod_5((string)dictionary2["level"]);
									GClass0.smethod_9(GClass3.gclass5_0.method_0());
									GClass0.smethod_7((string)dictionary2["expires"]);
									if (!(GClass0.smethod_10() != GClass3.gclass5_0.method_1()) || !GClass2.smethod_13())
									{
										GClass3.smethod_20(true);
										return true;
									}
									MessageBox.Show("Your HWID does not match!", GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
									Environment.Exit(0);
								}
							}
							else
							{
								MessageBox.Show("Your account is banned from this application!", GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
								Environment.Exit(0);
							}
						}
						else
						{
							MessageBox.Show("Your subscription time has expired!", GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
							Environment.Exit(0);
						}
					}
					else
					{
						MessageBox.Show("Invalid name or password!", GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
						Environment.Exit(0);
					}
				}
				else
				{
					MessageBox.Show("Your HWID has been reset!, please login again.", GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					Environment.Exit(0);
				}
			}
			else
			{
				MessageBox.Show("The HWID is incorrect!", GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Environment.Exit(0);
			}
		}
		else
		{
			MessageBox.Show("The connection is not totally secure and encrypted!", GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
			Environment.Exit(0);
		}
		return false;
	}

	// Token: 0x060000AD RID: 173 RVA: 0x000053D0 File Offset: 0x000035D0
	internal bool method_4(string string_5, string string_6, string string_7)
	{
		if (GClass3.smethod_3())
		{
			JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
			Class1 @class = this.class1_0;
			Class23 class2 = GClass3.class23_0;
			string text = Class14.string_1 + "?register";
			string str = "data=";
			Class1 class3 = this.class1_0;
			JavaScriptSerializer javaScriptSerializer2 = new JavaScriptSerializer();
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary["username"] = string_5;
			dictionary["password"] = string_6;
			dictionary["license"] = string_7;
			dictionary["ip"] = GClass3.gclass5_0.method_0();
			dictionary["hwid"] = GClass3.gclass5_0.method_1();
			dictionary["application_key"] = GClass3.smethod_13();
			dictionary["application_id"] = GClass3.smethod_17();
			Dictionary<string, object> dictionary2 = javaScriptSerializer.DeserializeObject(@class.method_4(class2.method_0(text, str + class3.method_3(javaScriptSerializer2.Serialize(dictionary))))) as Dictionary<string, object>;
			string a = (string)dictionary2["status"];
			if (!(a == "username_used"))
			{
				if (!(a == "invalid_license"))
				{
					if (!(a == "error"))
					{
						if (a == "success")
						{
							return true;
						}
					}
					else
					{
						MessageBox.Show((string)dictionary2["info"], GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
						Environment.Exit(0);
					}
				}
				else
				{
					MessageBox.Show("Your license is invalid!", GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Environment.Exit(0);
				}
			}
			else
			{
				MessageBox.Show("That username is already in use!", GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Environment.Exit(0);
			}
		}
		else
		{
			MessageBox.Show("The connection is not totally secure and encrypted!", GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
			Environment.Exit(0);
		}
		return false;
	}

	// Token: 0x060000AE RID: 174 RVA: 0x0000556C File Offset: 0x0000376C
	internal bool method_5(string string_5, string string_6, string string_7)
	{
		if (GClass3.smethod_3())
		{
			JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
			Class1 @class = this.class1_0;
			Class23 class2 = GClass3.class23_0;
			string text = Class14.string_1 + "?extend";
			string str = "data=";
			Class1 class3 = this.class1_0;
			JavaScriptSerializer javaScriptSerializer2 = new JavaScriptSerializer();
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary["username"] = string_5;
			dictionary["password"] = string_6;
			dictionary["license"] = string_7;
			dictionary["hwid"] = GClass3.gclass5_0.method_1();
			dictionary["application_key"] = GClass3.smethod_13();
			dictionary["application_id"] = GClass3.smethod_17();
			Dictionary<string, object> dictionary2 = javaScriptSerializer.DeserializeObject(@class.method_4(class2.method_0(text, str + class3.method_3(javaScriptSerializer2.Serialize(dictionary))))) as Dictionary<string, object>;
			string a = (string)dictionary2["status"];
			if (!(a == "incorrect_details"))
			{
				if (!(a == "banned_user"))
				{
					if (!(a == "incorrect_hwid"))
					{
						if (!(a == "incorrect_license"))
						{
							if (!(a == "error"))
							{
								if (a == "success")
								{
									return true;
								}
							}
							else
							{
								MessageBox.Show((string)dictionary2["info"], GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
								Environment.Exit(0);
							}
						}
						else
						{
							MessageBox.Show("The license entered does not exist!", GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
							Environment.Exit(0);
						}
					}
					else
					{
						MessageBox.Show("The HWID is incorrect!", GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
						Environment.Exit(0);
					}
				}
				else
				{
					MessageBox.Show("Your account is banned from this application!", GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Environment.Exit(0);
				}
			}
			else
			{
				MessageBox.Show("Invalid name or password!", GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Environment.Exit(0);
			}
		}
		else
		{
			MessageBox.Show("The connection is not totally secure and encrypted!", GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
			Environment.Exit(0);
		}
		return false;
	}

	// Token: 0x060000AF RID: 175 RVA: 0x00005750 File Offset: 0x00003950
	internal bool method_6(string string_5)
	{
		if (GClass3.smethod_3())
		{
			JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
			Class1 @class = this.class1_0;
			Class23 class2 = GClass3.class23_0;
			string text = Class14.string_1 + "?license";
			string str = "data=";
			Class1 class3 = this.class1_0;
			JavaScriptSerializer javaScriptSerializer2 = new JavaScriptSerializer();
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary["license"] = string_5;
			dictionary["hwid"] = GClass3.gclass5_0.method_1();
			dictionary["ip"] = GClass3.gclass5_0.method_0();
			dictionary["date"] = DateTime.Now.ToString();
			dictionary["application_key"] = GClass3.smethod_13();
			dictionary["application_id"] = GClass3.smethod_17();
			Dictionary<string, object> dictionary2 = javaScriptSerializer.DeserializeObject(@class.method_4(class2.method_0(text, str + class3.method_3(javaScriptSerializer2.Serialize(dictionary))))) as Dictionary<string, object>;
			string a = (string)dictionary2["status"];
			if (!(a == "expired_time"))
			{
				if (!(a == "incorrect_hwid"))
				{
					if (!(a == "banned_user"))
					{
						if (!(a == "incorrect_details"))
						{
							if (!(a == "error"))
							{
								if (a == "success")
								{
									GClass0.smethod_1((string)dictionary2["license"]);
									GClass0.smethod_11((string)dictionary2["hwid"]);
									GClass0.smethod_3((string)dictionary2["license"]);
									GClass0.smethod_5((string)dictionary2["level"]);
									GClass0.smethod_9((string)dictionary2["ip"]);
									GClass0.smethod_7((string)dictionary2["expires"]);
									if (!(GClass0.smethod_10() != GClass3.gclass5_0.method_1()) || !GClass2.smethod_13())
									{
										GClass3.smethod_20(true);
										return true;
									}
									MessageBox.Show("Your HWID does not match!", GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
									Environment.Exit(0);
								}
							}
							else
							{
								MessageBox.Show((string)dictionary2["info"], GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
								Environment.Exit(0);
							}
						}
						else
						{
							MessageBox.Show("Invalid license key!", GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
							Environment.Exit(0);
						}
					}
					else
					{
						MessageBox.Show("Your account is banned from this application!", GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
						Environment.Exit(0);
					}
				}
				else
				{
					MessageBox.Show("The HWID is incorrect!", GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Environment.Exit(0);
				}
			}
			else
			{
				MessageBox.Show("Your subscription time has expired!", GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Environment.Exit(0);
			}
		}
		else
		{
			MessageBox.Show("The connection is not totally secure and encrypted!", GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
			Environment.Exit(0);
		}
		return false;
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x00005A10 File Offset: 0x00003C10
	internal string method_7(string string_5)
	{
		if (!GClass3.smethod_19())
		{
			MessageBox.Show("You must be logged in to capture variables!", GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
			Environment.Exit(0);
		}
		else if (GClass3.smethod_3())
		{
			JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
			Class1 @class = this.class1_0;
			Class23 class2 = GClass3.class23_0;
			string text = Class14.string_1 + "?variable";
			string str = "data=";
			Class1 class3 = this.class1_0;
			JavaScriptSerializer javaScriptSerializer2 = new JavaScriptSerializer();
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary["action"] = "variable";
			dictionary["username"] = GClass0.smethod_0();
			dictionary["password"] = GClass7.dictionary_0["password"];
			dictionary["hwid"] = GClass3.gclass5_0.method_1();
			dictionary["variable_code"] = string_5;
			dictionary["application_key"] = GClass3.smethod_13();
			dictionary["application_id"] = GClass3.smethod_17();
			Dictionary<string, object> dictionary2 = javaScriptSerializer.DeserializeObject(@class.method_4(class2.method_0(text, str + class3.method_3(javaScriptSerializer2.Serialize(dictionary))))) as Dictionary<string, object>;
			string a = (string)dictionary2["status"];
			if (!(a == "incorrect_details"))
			{
				if (!(a == "error"))
				{
					if (a == "success")
					{
						if (!GClass7.dictionary_1.ContainsKey((string)dictionary2["code"]))
						{
							GClass7.dictionary_1.Add((string)dictionary2["code"], (string)dictionary2["var_value"]);
						}
						if (!GClass7.dictionary_1.ContainsKey(string_5))
						{
							return "N/A";
						}
						return GClass7.dictionary_1[string_5];
					}
				}
				else
				{
					MessageBox.Show((string)dictionary2["info"], GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Environment.Exit(0);
				}
			}
			else
			{
				MessageBox.Show("Invalid name or password!", GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Environment.Exit(0);
			}
		}
		else
		{
			MessageBox.Show("The connection is not totally secure and encrypted!", GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
			Environment.Exit(0);
		}
		return "N/A";
	}

	// Token: 0x060000B1 RID: 177 RVA: 0x00005C24 File Offset: 0x00003E24
	internal bool method_8(string string_5)
	{
		if (GClass3.smethod_3())
		{
			JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
			Class1 @class = this.class1_0;
			Class23 class2 = GClass3.class23_0;
			string text = Class14.string_1 + "?log";
			string str = "data=";
			Class1 class3 = this.class1_0;
			JavaScriptSerializer javaScriptSerializer2 = new JavaScriptSerializer();
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary["username"] = GClass0.smethod_0();
			dictionary["hwid"] = GClass3.gclass5_0.method_1();
			dictionary["message"] = string_5;
			dictionary["ip"] = GClass3.gclass5_0.method_0();
			dictionary["date"] = DateTime.Now.ToString();
			dictionary["application_key"] = GClass3.smethod_13();
			dictionary["application_id"] = GClass3.smethod_17();
			Dictionary<string, object> dictionary2 = javaScriptSerializer.DeserializeObject(@class.method_4(class2.method_0(text, str + class3.method_3(javaScriptSerializer2.Serialize(dictionary))))) as Dictionary<string, object>;
			string a = (string)dictionary2["status"];
			if (!(a == "error"))
			{
				if (a == "success")
				{
					return true;
				}
			}
			else
			{
				MessageBox.Show((string)dictionary2["info"], GClass3.smethod_7(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Environment.Exit(0);
			}
		}
		return false;
	}

	// Token: 0x04000035 RID: 53
	private static readonly GClass7 gclass7_0;

	// Token: 0x04000036 RID: 54
	public static GClass4 gclass4_0 = new GClass4();

	// Token: 0x04000037 RID: 55
	public static GClass5 gclass5_0 = new GClass5();

	// Token: 0x04000038 RID: 56
	private static Class23 class23_0 = new Class23();

	// Token: 0x04000039 RID: 57
	private readonly Class15 class15_0 = new Class15();

	// Token: 0x0400003A RID: 58
	private readonly Class1 class1_0 = new Class1();

	// Token: 0x0400003B RID: 59
	private static bool bool_0;

	// Token: 0x0400003C RID: 60
	private static bool bool_1;

	// Token: 0x0400003D RID: 61
	private static bool bool_2;

	// Token: 0x0400003E RID: 62
	private static string string_0;

	// Token: 0x0400003F RID: 63
	private static string string_1;

	// Token: 0x04000040 RID: 64
	private static bool bool_3;

	// Token: 0x04000041 RID: 65
	private static string string_2;

	// Token: 0x04000042 RID: 66
	private static string string_3;

	// Token: 0x04000043 RID: 67
	private static string string_4;

	// Token: 0x04000044 RID: 68
	private static bool bool_4 = false;

	// Token: 0x04000045 RID: 69
	private static bool bool_5 = false;

	// Token: 0x04000046 RID: 70
	private static bool bool_6 = false;

	// Token: 0x04000047 RID: 71
	private static bool bool_7;

	// Token: 0x04000048 RID: 72
	private static bool bool_8 = false;
}
