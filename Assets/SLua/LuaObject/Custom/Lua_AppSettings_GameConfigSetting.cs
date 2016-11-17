using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_AppSettings_GameConfigSetting : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ParsePrimaryKey_s(IntPtr l) {
		try {
			KEngine.Table.TableRow a1;
			checkType(l,1,out a1);
			var ret=AppSettings.GameConfigSetting.ParsePrimaryKey(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_Id(IntPtr l) {
		try {
			AppSettings.GameConfigSetting self=(AppSettings.GameConfigSetting)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.Id);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_Value(IntPtr l) {
		try {
			AppSettings.GameConfigSetting self=(AppSettings.GameConfigSetting)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.Value);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"AppSettings.GameConfigSetting");
		addMember(l,ParsePrimaryKey_s);
		addMember(l,"Id",get_Id,null,true);
		addMember(l,"Value",get_Value,null,true);
		createTypeMetatable(l,null, typeof(AppSettings.GameConfigSetting),typeof(KEngine.Table.TableRowParser));
	}
}
