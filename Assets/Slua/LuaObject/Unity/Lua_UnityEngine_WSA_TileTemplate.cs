﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_WSA_TileTemplate : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.WSA.TileTemplate");
		addMember(l,0,"TileSquare150x150Image");
		addMember(l,1,"TileSquare150x150Block");
		addMember(l,2,"TileSquare150x150Text01");
		addMember(l,3,"TileSquare150x150Text02");
		addMember(l,4,"TileSquare150x150Text03");
		addMember(l,5,"TileSquare150x150Text04");
		addMember(l,6,"TileSquare150x150PeekImageAndText01");
		addMember(l,7,"TileSquare150x150PeekImageAndText02");
		addMember(l,8,"TileSquare150x150PeekImageAndText03");
		addMember(l,9,"TileSquare150x150PeekImageAndText04");
		addMember(l,10,"TileWide310x150Image");
		addMember(l,11,"TileWide310x150ImageCollection");
		addMember(l,12,"TileWide310x150ImageAndText01");
		addMember(l,13,"TileWide310x150ImageAndText02");
		addMember(l,14,"TileWide310x150BlockAndText01");
		addMember(l,15,"TileWide310x150BlockAndText02");
		addMember(l,16,"TileWide310x150PeekImageCollection01");
		addMember(l,17,"TileWide310x150PeekImageCollection02");
		addMember(l,18,"TileWide310x150PeekImageCollection03");
		addMember(l,19,"TileWide310x150PeekImageCollection04");
		addMember(l,20,"TileWide310x150PeekImageCollection05");
		addMember(l,21,"TileWide310x150PeekImageCollection06");
		addMember(l,22,"TileWide310x150PeekImageAndText01");
		addMember(l,23,"TileWide310x150PeekImageAndText02");
		addMember(l,24,"TileWide310x150PeekImage01");
		addMember(l,25,"TileWide310x150PeekImage02");
		addMember(l,26,"TileWide310x150PeekImage03");
		addMember(l,27,"TileWide310x150PeekImage04");
		addMember(l,28,"TileWide310x150PeekImage05");
		addMember(l,29,"TileWide310x150PeekImage06");
		addMember(l,30,"TileWide310x150SmallImageAndText01");
		addMember(l,31,"TileWide310x150SmallImageAndText02");
		addMember(l,32,"TileWide310x150SmallImageAndText03");
		addMember(l,33,"TileWide310x150SmallImageAndText04");
		addMember(l,34,"TileWide310x150SmallImageAndText05");
		addMember(l,35,"TileWide310x150Text01");
		addMember(l,36,"TileWide310x150Text02");
		addMember(l,37,"TileWide310x150Text03");
		addMember(l,38,"TileWide310x150Text04");
		addMember(l,39,"TileWide310x150Text05");
		addMember(l,40,"TileWide310x150Text06");
		addMember(l,41,"TileWide310x150Text07");
		addMember(l,42,"TileWide310x150Text08");
		addMember(l,43,"TileWide310x150Text09");
		addMember(l,44,"TileWide310x150Text10");
		addMember(l,45,"TileWide310x150Text11");
		addMember(l,46,"TileSquare310x310BlockAndText01");
		addMember(l,47,"TileSquare310x310BlockAndText02");
		addMember(l,48,"TileSquare310x310Image");
		addMember(l,49,"TileSquare310x310ImageAndText01");
		addMember(l,50,"TileSquare310x310ImageAndText02");
		addMember(l,51,"TileSquare310x310ImageAndTextOverlay01");
		addMember(l,52,"TileSquare310x310ImageAndTextOverlay02");
		addMember(l,53,"TileSquare310x310ImageAndTextOverlay03");
		addMember(l,54,"TileSquare310x310ImageCollectionAndText01");
		addMember(l,55,"TileSquare310x310ImageCollectionAndText02");
		addMember(l,56,"TileSquare310x310ImageCollection");
		addMember(l,57,"TileSquare310x310SmallImagesAndTextList01");
		addMember(l,58,"TileSquare310x310SmallImagesAndTextList02");
		addMember(l,59,"TileSquare310x310SmallImagesAndTextList03");
		addMember(l,60,"TileSquare310x310SmallImagesAndTextList04");
		addMember(l,61,"TileSquare310x310Text01");
		addMember(l,62,"TileSquare310x310Text02");
		addMember(l,63,"TileSquare310x310Text03");
		addMember(l,64,"TileSquare310x310Text04");
		addMember(l,65,"TileSquare310x310Text05");
		addMember(l,66,"TileSquare310x310Text06");
		addMember(l,67,"TileSquare310x310Text07");
		addMember(l,68,"TileSquare310x310Text08");
		addMember(l,69,"TileSquare310x310TextList01");
		addMember(l,70,"TileSquare310x310TextList02");
		addMember(l,71,"TileSquare310x310TextList03");
		addMember(l,72,"TileSquare310x310SmallImageAndText01");
		addMember(l,73,"TileSquare310x310SmallImagesAndTextList05");
		addMember(l,74,"TileSquare310x310Text09");
		addMember(l,75,"TileSquare71x71IconWithBadge");
		addMember(l,76,"TileSquare150x150IconWithBadge");
		addMember(l,77,"TileWide310x150IconWithBadgeAndText");
		addMember(l,78,"TileSquare71x71Image");
		addMember(l,1000,"TileSquare99x99IconWithBadge");
		addMember(l,1001,"TileSquare210x210IconWithBadge");
		addMember(l,1002,"TileWide432x210IconWithBadgeAndText");
		LuaDLL.lua_pop(l, 1);
	}
}
