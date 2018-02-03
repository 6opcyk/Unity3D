using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Init : MonoBehaviour {

	void Start () {
		GameObject.FindGameObjectWithTag ("loader").GetComponent<Loader> ().loadScene ("MainMenu");
	}

}
