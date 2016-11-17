using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_AppSettings_SettingsManager : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			AppSettings.SettingsManager o;
			o=new AppSettings.SettingsManager();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AllSettingsReload_s(IntPtr l) {
		try {
			AppSettings.SettingsManager.AllSettingsReload();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_SettingsList(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,AppSettings.SettingsManager.SettingsList);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"AppSettings.SettingsManager");
		addMember(l,AllSettingsReload_s);
		addMember(l,"SettingsList",get_SettingsList,null,false);
		createTypeMetatable(l,constructor, typeof(AppSettings.SettingsManager));
	}
}
