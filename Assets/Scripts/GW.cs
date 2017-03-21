using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GW : MonoBehaviour
{
    public float time = 5.0f;
    void Update()
    {
        time -= Time.deltaTime;
        if (time <= 0.0f)
        {
            SceneManager.LoadScene("SaltBae_Game");
        }
    }
}