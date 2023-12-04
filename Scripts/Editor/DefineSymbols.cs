// ©2023 JDSherbert. All rights reserved.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

#if UNITY_EDITOR
using UnityEditor;
#endif

#if UNITY_EDITOR
/// <summary>
/// Add symbols that will be added to the build settings define symbols list automatically.
/// </summary>
[InitializeOnLoad]
public class DefineSymbols
{
	/// <summary>
	/// Symbols to add to build settings.
	/// </summary>
	public static readonly string[] Symbols = new string[]
	{
		"SYMBOLS_TO_DEFINE"
	};

	/// <summary>
	/// Adds the specified define symbols to the build settings once compilation has finished.
	/// </summary>
	private static DefineSymbols()
	{
		List<string> defsList = GetScriptingDefineStringList();
		defsList.AddRange(Symbols.Except(defsList));
		PlayerSettings.SetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup, string.Join(";", defsList.ToArray()));
	}

	/// <summary>
	/// Grabs all currently defined symbols, splits them and returns as a string list.
	/// </summary>
	private static List<string> GetScriptingDefineStringList()
	{
		string defs = PlayerSettings.GetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup);
		return defs.Split(';').ToList();
	}
}
#endif
