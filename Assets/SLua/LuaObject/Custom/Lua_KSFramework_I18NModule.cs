using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_KSFramework_I18NModule : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Init_s(IntPtr l) {
		try {
			KSFramework.I18NModule.Init();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetLang_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			KSFramework.I18NModule.SetLang(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Str_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				System.String a1;
				checkType(l,1,out a1);
				var ret=KSFramework.I18NModule.Str(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				System.String a1;
				checkType(l,1,out a1);
				System.Boolean a2;
				var ret=KSFramework.I18NModule.Str(a1,out a2);
				pushValue(l,true);
				pushValue(l,ret);
				pushValue(l,a2);
				return 3;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_CurLang(IntPtr l) {
		try {
			KSFramework.I18NModule self=(KSFramework.I18NModule)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.CurLang);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"I18N");
		addMember(l,Init_s);
		addMember(l,SetLang_s);
		addMember(l,Str_s);
		addMember(l,"CurLang",get_CurLang,null,true);
		createTypeMetatable(l,null, typeof(KSFramework.I18NModule));
	}
}
