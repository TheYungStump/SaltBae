using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class Move : MonoBehaviour {

    public int fingerCount;
    public int maxFinger = 1;
    Vector3 worldPos;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
        fingerCount = 0;
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began && fingerCount < maxFinger)
            {
                worldPos = Camera.main.ScreenToWorldPoint(touch.position);
                worldPos.y = -3;
                worldPos.z = 0;
                transform.position = worldPos;
            }
        }
	}

	void OnCollisionEnter () {
        if (PlayerPrefs.GetInt("Ads") == 3)
        {
            PlayerPrefs.SetInt("Ads", 0);
            SceneManager.LoadScene("AdScene");
        } else
        {
            PlayerPrefs.SetInt("Ads", PlayerPrefs.GetInt("Ads")+1);
            SceneManager.LoadScene("SaltBae_Game");
        }
	}
}
