using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_KBehaviour : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Delete(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				KBehaviour self=(KBehaviour)checkSelf(l);
				self.Delete();
				pushValue(l,true);
				return 1;
			}
			else if(argc==2){
				KBehaviour self=(KBehaviour)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				self.Delete(a1);
				pushValue(l,true);
				return 1;
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
	static public int DeleteSelf(IntPtr l) {
		try {
			KBehaviour self=(KBehaviour)checkSelf(l);
			self.DeleteSelf();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_ApplicationQuitEvent(IntPtr l) {
		try {
			System.Action v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) KBehaviour.ApplicationQuitEvent=v;
			else if(op==1) KBehaviour.ApplicationQuitEvent+=v;
			else if(op==2) KBehaviour.ApplicationQuitEvent-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_CachedTransform(IntPtr l) {
		try {
			KBehaviour self=(KBehaviour)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.CachedTransform);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_CachedGameObject(IntPtr l) {
		try {
			KBehaviour self=(KBehaviour)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.CachedGameObject);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_IsApplicationQuited(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,KBehaviour.IsApplicationQuited);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_TimeScale(IntPtr l) {
		try {
			KBehaviour self=(KBehaviour)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.TimeScale);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_TimeScale(IntPtr l) {
		try {
			KBehaviour self=(KBehaviour)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.TimeScale=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"KBehaviour");
		addMember(l,Delete);
		addMember(l,DeleteSelf);
		addMember(l,"ApplicationQuitEvent",null,set_ApplicationQuitEvent,false);
		addMember(l,"CachedTransform",get_CachedTransform,null,true);
		addMember(l,"CachedGameObject",get_CachedGameObject,null,true);
		addMember(l,"IsApplicationQuited",get_IsApplicationQuited,null,false);
		addMember(l,"TimeScale",get_TimeScale,set_TimeScale,true);
		createTypeMetatable(l,null, typeof(KBehaviour),typeof(UnityEngine.MonoBehaviour));
	}
}
