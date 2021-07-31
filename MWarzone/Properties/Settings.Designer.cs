using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MWarzone.Properties
{
	// Token: 0x0200002E RID: 46
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x000029AD File Offset: 0x00000BAD
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x000029B4 File Offset: 0x00000BB4
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x000029C6 File Offset: 0x00000BC6
		[DefaultSettingValue("")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string userName
		{
			get
			{
				return (string)this["userName"];
			}
			set
			{
				this["userName"] = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x060000FA RID: 250 RVA: 0x000029D4 File Offset: 0x00000BD4
		// (set) Token: 0x060000FB RID: 251 RVA: 0x000029E6 File Offset: 0x00000BE6
		[UserScopedSetting]
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		public string Password
		{
			get
			{
				return (string)this["Password"];
			}
			set
			{
				this["Password"] = value;
			}
		}

		// Token: 0x04000073 RID: 115
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
