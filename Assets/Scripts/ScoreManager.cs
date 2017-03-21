using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public Text score;
	public float scoreCount;

	public Text highScore;
	public float highScoreCount;

	public int scorePerSecond;

	public bool isScoring;

	// Use this for initialization
	void Start () {
        highScoreCount = PlayerPrefs.GetFloat("High Score");
	}

	// Update is called once per frame
	void Update () {
		if (isScoring) {
			scoreCount += scorePerSecond * Time.deltaTime;
		}
		if (scoreCount > highScoreCount) {
			highScoreCount = Mathf.Round(scoreCount);
			PlayerPrefs.SetFloat("High Score", highScoreCount);
			highScore.text = Mathf.Round(highScoreCount).ToString();
		}
		score.text = Mathf.Round(scoreCount).ToString();
	}

	public float GetHighScore() {
		return highScoreCount;
	}

	public void SetHighScore(float hScore) {
		highScoreCount = hScore;
	}

	public float GetScore() {
		return scoreCount;
	}

	public void SetScore(float scoreC) {
		scoreCount = scoreC;
	}
}
