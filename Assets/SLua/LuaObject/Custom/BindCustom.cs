using System;
using System.Collections.Generic;
namespace SLua {
	[LuaBinder(3)]
	public class BindCustom {
		public static Action<IntPtr>[] GetBindList() {
			Action<IntPtr>[] list= {
				Lua_AppSettings_SettingsManager.reg,
				Lua_AppSettings_TestSettings.reg,
				Lua_AppSettings_TestSetting.reg,
				Lua_AppSettings_GameConfigSettings.reg,
				Lua_AppSettings_GameConfigSetting.reg,
				Lua_System_Collections_Generic_List_1_int.reg,
				Lua_System_Collections_Generic_Dictionary_2_int_string.reg,
				Lua_System_String.reg,
				Lua_KEngine_Log.reg,
				Lua_KBehaviour.reg,
				Lua_KEngine_UI_UIController.reg,
				Lua_KSFramework_LuaUIController.reg,
				Lua_KSFramework_I18NModule.reg,
				Lua_KSFramework_Cookie.reg,
			};
			return list;
		}
	}
}
