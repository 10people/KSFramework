using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_KSFramework_Cookie : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			KSFramework.Cookie o;
			o=new KSFramework.Cookie();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Define_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			KSFramework.Cookie.CookieGetter a2;
			LuaDelegation.checkDelegate(l,2,out a2);
			KSFramework.Cookie.CookieSetter a3;
			LuaDelegation.checkDelegate(l,3,out a3);
			KSFramework.Cookie.Define(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Set_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Object a2;
			checkType(l,2,out a2);
			KSFramework.Cookie.Set(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Get_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				System.String a1;
				checkType(l,1,out a1);
				var ret=KSFramework.Cookie.Get(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				System.String a1;
				checkType(l,1,out a1);
				KSFramework.Cookie.IfNullGetter a2;
				LuaDelegation.checkDelegate(l,2,out a2);
				var ret=KSFramework.Cookie.Get(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
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
	static public int AddSetListener_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			KSFramework.Cookie.CookieSetListener a2;
			LuaDelegation.checkDelegate(l,2,out a2);
			KSFramework.Cookie.AddSetListener(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RemoveSetListner_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			KSFramework.Cookie.CookieSetListener a2;
			LuaDelegation.checkDelegate(l,2,out a2);
			KSFramework.Cookie.RemoveSetListner(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"Cookie");
		addMember(l,Define_s);
		addMember(l,Set_s);
		addMember(l,Get_s);
		addMember(l,AddSetListener_s);
		addMember(l,RemoveSetListner_s);
		createTypeMetatable(l,constructor, typeof(KSFramework.Cookie));
	}
}
