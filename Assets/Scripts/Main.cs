using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Main : MonoBehaviour {
	public Settings settings;
	string word;
	public int tries_count;
	public List<GameObject> letters = new List<GameObject>();
	List<GameObject> unguessed_letters = new List<GameObject>();
	public Text finalText;
	public Text tries;
	public Text words;
	public Text score;
	void Start () {
		score.text = "Score: "+settings.score.ToString ();
		words.text = "Words: " + (settings.words.Count -1).ToString ();
		tries.text = "Tries: " + settings.triesСount.ToString ();
		int j = Random.Range (0, settings.words.Count);
		word = settings.words [j];
		settings.words.RemoveAt (j);
		tries_count = settings.triesСount;
		int i = 0;
		foreach (char l in word) {
			letters [i].SetActive (true);
			unguessed_letters.Add (letters[i]);
			letters [i].transform.GetChild (0).GetComponent<Text> ().text = l.ToString();
			i += 1;
		}
		RectTransform rect = gameObject.GetComponent<RectTransform>();
		rect.anchoredPosition = new Vector2 (20*(13-word.Length), rect.anchoredPosition.y);
	}


	void Update () {
	}
	public void checkLetter(char letter) {
		bool isChecked = false;
		int i = 0;
		while(i<unguessed_letters.Count){
			if (unguessed_letters[i].transform.GetChild (0).GetComponent<Text> ().text == letter.ToString ()) {
				Debug.Log (unguessed_letters [i].transform.GetChild (0).GetComponent<Text> ().text == letter.ToString ());
				unguessed_letters[i].GetComponent<Animator> ().Play ("LetterOpen");
				isChecked = true;
				unguessed_letters.RemoveAt(i);
			} else {
				i += 1;
			}
		}
		if(!isChecked) {
			tries_count -= 1;
			tries.text = "Tries: " + tries_count.ToString ();
		}
		if (tries_count < 0) {
			StartCoroutine (stopGame ("You lose!", "MainMenu"));
		} else if (unguessed_letters.Count <= 0 && settings.words.Count > 0) {
			settings.score += tries_count;
			StartCoroutine (stopGame ("You win!", "GamePlay"));
		} else if (unguessed_letters.Count <= 0 && settings.words.Count <= 0){
			StartCoroutine (stopGame ("Game completed!", "MainMenu"));
		}
	}
	IEnumerator stopGame(string mesagge, string sceneName){
		finalText.gameObject.SetActive(true);
		finalText.text = mesagge;
		yield return new WaitForSeconds(5);
		GameObject.FindGameObjectWithTag ("loader").GetComponent<Loader> ().loadScene (sceneName);
	}
}
