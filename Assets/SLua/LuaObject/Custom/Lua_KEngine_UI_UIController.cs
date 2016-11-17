using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_KEngine_UI_UIController : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			KEngine.UI.UIController o;
			o=new KEngine.UI.UIController();
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
			KEngine.UI.UIController self=(KEngine.UI.UIController)checkSelf(l);
			self.OnInit();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int BeforeOpen(IntPtr l) {
		try {
			KEngine.UI.UIController self=(KEngine.UI.UIController)checkSelf(l);
			System.Object[] a1;
			checkArray(l,2,out a1);
			System.Action a2;
			LuaDelegation.checkDelegate(l,3,out a2);
			self.BeforeOpen(a1,a2);
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
			KEngine.UI.UIController self=(KEngine.UI.UIController)checkSelf(l);
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
	static public int OnClose(IntPtr l) {
		try {
			KEngine.UI.UIController self=(KEngine.UI.UIController)checkSelf(l);
			self.OnClose();
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
			KEngine.UI.UIController self=(KEngine.UI.UIController)checkSelf(l);
			System.Type a1;
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
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FindGameObject(IntPtr l) {
		try {
			KEngine.UI.UIController self=(KEngine.UI.UIController)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.FindGameObject(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DFSFindObject(IntPtr l) {
		try {
			KEngine.UI.UIController self=(KEngine.UI.UIController)checkSelf(l);
			UnityEngine.Transform a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			var ret=self.DFSFindObject(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DestroyGameObjectChildren(IntPtr l) {
		try {
			KEngine.UI.UIController self=(KEngine.UI.UIController)checkSelf(l);
			UnityEngine.GameObject a1;
			checkType(l,2,out a1);
			self.DestroyGameObjectChildren(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_UITemplateName(IntPtr l) {
		try {
			KEngine.UI.UIController self=(KEngine.UI.UIController)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.UITemplateName);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_UITemplateName(IntPtr l) {
		try {
			KEngine.UI.UIController self=(KEngine.UI.UIController)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.UITemplateName=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_UIName(IntPtr l) {
		try {
			KEngine.UI.UIController self=(KEngine.UI.UIController)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.UIName);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_UIName(IntPtr l) {
		try {
			KEngine.UI.UIController self=(KEngine.UI.UIController)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.UIName=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIController");
		addMember(l,OnInit);
		addMember(l,BeforeOpen);
		addMember(l,OnOpen);
		addMember(l,OnClose);
		addMember(l,GetControl);
		addMember(l,FindGameObject);
		addMember(l,DFSFindObject);
		addMember(l,DestroyGameObjectChildren);
		addMember(l,"UITemplateName",get_UITemplateName,set_UITemplateName,true);
		addMember(l,"UIName",get_UIName,set_UIName,true);
		createTypeMetatable(l,constructor, typeof(KEngine.UI.UIController),typeof(KBehaviour));
	}
}
