using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_AppSettings_TestSettings : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ReloadAll(IntPtr l) {
		try {
			AppSettings.TestSettings self=(AppSettings.TestSettings)checkSelf(l);
			self.ReloadAll();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ReloadAllWithString(IntPtr l) {
		try {
			AppSettings.TestSettings self=(AppSettings.TestSettings)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			self.ReloadAllWithString(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetInstance_s(IntPtr l) {
		try {
			var ret=AppSettings.TestSettings.GetInstance();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetAll_s(IntPtr l) {
		try {
			var ret=AppSettings.TestSettings.GetAll();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Get_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=AppSettings.TestSettings.Get(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_TabFilePaths(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,AppSettings.TestSettings.TabFilePaths);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_OnReload(IntPtr l) {
		try {
			System.Action v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) AppSettings.TestSettings.OnReload=v;
			else if(op==1) AppSettings.TestSettings.OnReload+=v;
			else if(op==2) AppSettings.TestSettings.OnReload-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_ReloadCount(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,AppSettings.TestSettings.ReloadCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_Count(IntPtr l) {
		try {
			AppSettings.TestSettings self=(AppSettings.TestSettings)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.Count);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"AppSettings.TestSettings");
		addMember(l,ReloadAll);
		addMember(l,ReloadAllWithString);
		addMember(l,GetInstance_s);
		addMember(l,GetAll_s);
		addMember(l,Get_s);
		addMember(l,"TabFilePaths",get_TabFilePaths,null,false);
		addMember(l,"OnReload",null,set_OnReload,false);
		addMember(l,"ReloadCount",get_ReloadCount,null,false);
		addMember(l,"Count",get_Count,null,true);
		createTypeMetatable(l,null, typeof(AppSettings.TestSettings));
	}
}
