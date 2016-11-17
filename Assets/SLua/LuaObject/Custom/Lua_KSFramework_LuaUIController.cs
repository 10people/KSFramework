using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_KSFramework_LuaUIController : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			KSFramework.LuaUIController o;
			o=new KSFramework.LuaUIController();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnInit(IntPtr l) {
		try {
			KSFramework.LuaUIController self=(KSFramework.LuaUIController)checkSelf(l);
			self.OnInit();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnOpen(IntPtr l) {
		try {
			KSFramework.LuaUIController self=(KSFramework.LuaUIController)checkSelf(l);
			System.Object[] a1;
			checkParams(l,2,out a1);
			self.OnOpen(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetControl(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				KSFramework.LuaUIController self=(KSFramework.LuaUIController)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.String a2;
				checkType(l,3,out a2);
				var ret=self.GetControl(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==4){
				KSFramework.LuaUIController self=(KSFramework.LuaUIController)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.String a2;
				checkType(l,3,out a2);
				UnityEngine.Transform a3;
				checkType(l,4,out a3);
				var ret=self.GetControl(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==5){
				KSFramework.LuaUIController self=(KSFramework.LuaUIController)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.String a2;
				checkType(l,3,out a2);
				UnityEngine.Transform a3;
				checkType(l,4,out a3);
				System.Boolean a4;
				checkType(l,5,out a4);
				var ret=self.GetControl(a1,a2,a3,a4);
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
	static public int ReloadLua(IntPtr l) {
		try {
			KSFramework.LuaUIController self=(KSFramework.LuaUIController)checkSelf(l);
			self.ReloadLua();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_CacheMode(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,KSFramework.LuaUIController.CacheMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_CacheMode(IntPtr l) {
		try {
			System.Boolean v;
			checkType(l,2,out v);
			KSFramework.LuaUIController.CacheMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_LastOnOpenArgs(IntPtr l) {
		try {
			KSFramework.LuaUIController self=(KSFramework.LuaUIController)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.LastOnOpenArgs);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"LuaUIController");
		addMember(l,OnInit);
		addMember(l,OnOpen);
		addMember(l,GetControl);
		addMember(l,ReloadLua);
		addMember(l,"CacheMode",get_CacheMode,set_CacheMode,false);
		addMember(l,"LastOnOpenArgs",get_LastOnOpenArgs,null,true);
		createTypeMetatable(l,constructor, typeof(KSFramework.LuaUIController),typeof(KEngine.UI.UIController));
	}
}
