using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLoader : Button {
	public string sceneName;
	GameObject loader;
	void Start(){
		loader = GameObject.FindGameObjectWithTag ("loader");
	}
	public override void onClick(){
		loader.GetComponent<Loader> ().loadScene (sceneName);
	}
}
