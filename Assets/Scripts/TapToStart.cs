using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TapToStart : MonoBehaviour {

	public Text highScore;
	public Button startButton;
	public ScoreManager sMan;

	// Use this for initialization
	void Start () {
		Init();
	}

	public void Init() {
		Time.timeScale = 0;
		sMan.SetScore(0);
		highScore.text = "High Score: " + Mathf.Round(PlayerPrefs.GetFloat("High Score")).ToString();
		startButton.gameObject.SetActive(true);
	}

	public void Pressed() {
		startButton.gameObject.SetActive(false);
		Time.timeScale = 1;
	}
}
