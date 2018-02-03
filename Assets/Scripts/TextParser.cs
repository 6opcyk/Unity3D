using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class TextParser : MonoBehaviour {
	public Settings settings;
	public void updateWords () {
		settings.words = new List<string> ();
		string text = File.ReadAllText ("Assets/alice30.txt").ToUpper();
		string a = "ABCDEFGHIJKLMNOPQRSTUVWYXZ";
		string word = "";
		foreach (char c in text) {
			string letter = c.ToString ();
			if (a.Contains (letter)) {
				word += letter;
				continue;
			} else if (word.Length >= settings.minWordLength && letter == " " && !settings.words.Contains(word)) 
				settings.words.Add (word);
			word = "";
		}
	}
}
