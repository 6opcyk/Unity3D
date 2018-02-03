using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letter : Button {
	public char letter;
	public Main main;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public override void onClick(){
		main.checkLetter (letter);
		gameObject.SetActive (false);
	}
}
