using UnityEngine;
using UnityEditor;

public class SettingsAsset
{
	[MenuItem("Assets/Create/Settings")]
	public static void CreateAsset ()
	{
		ScriptableObjectUtility.CreateAsset<Settings> ();
	}
}