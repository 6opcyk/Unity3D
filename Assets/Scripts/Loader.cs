using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Loader : MonoBehaviour {
	public string sceneName;
	void Awake() {
		DontDestroyOnLoad(transform.gameObject);
	}
	public void loadScene(string n){
		sceneName = n;
		SceneManager.LoadScene ("Loader");
		StartCoroutine(loading());
	}
	IEnumerator loading(){
		AsyncOperation asyncLoading = SceneManager.LoadSceneAsync(sceneName);
		while (!asyncLoading.isDone)
		{
			yield return null;
		}
	}
}
