using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;

public class Advertising : MonoBehaviour {

    bool watched = false;

	// Use this for initialization
	void Start () {
		//if (Advertisement.IsReady())
  //      {
            Debug.Log("Hi");
            Advertisement.Show("rewardedVideo", new ShowOptions() {resultCallback = HandleAdResult});
        //}
	}

    void FixedUpdate()
    {
        if (watched)
        {
            SceneManager.LoadScene("SaltBae_Game");
        }
    }

    private void HandleAdResult(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                watched = true;
                break;
            case ShowResult.Skipped:
                watched = true;
                break;
            case ShowResult.Failed:
                watched = true;
                break;
        }
    }
}
