using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGame : MonoBehaviour {
	public Settings settings;
	public void startGame(){
		GameObject.Find ("Parser").GetComponent<TextParser> ().updateWords ();
		settings.score = 0;
	}
}
