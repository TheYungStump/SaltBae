using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour {

	float currentTimeScale;
	public GameObject pauseMenu;

	// Use this for initialization
	void Start () {
		currentTimeScale = Time.timeScale;
		pauseMenu.SetActive(false);
	}

	// Update is called once per frame
	void Update () {
	}

	public void Pressed(){
		if (Time.timeScale == 0) {
			pauseMenu.SetActive(false);
			Time.timeScale = 1;
		} else {
			Time.timeScale = 0;
			pauseMenu.SetActive(true);
		}
	}
}
