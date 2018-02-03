using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour {
	public Settings settings;
	public Slider tries;
	public Slider word;
	public Text triesText;
	public Text wordText;
	public void setTries(){
		settings.triesСount = (int)tries.value;
		triesText.text = settings.triesСount.ToString();
	}
	public void setWordLength(){
		settings.minWordLength = (int)word.value;
		wordText.text = settings.minWordLength.ToString();
	}
	void Start(){
		setTries ();
		setWordLength ();
	}
}
