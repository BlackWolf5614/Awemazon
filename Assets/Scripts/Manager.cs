using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public Animator fadeImage;

    public float endGameTime = 10f;
    public float fadeTime = 2f;

    float timer;

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= endGameTime)
        {
            EndGame(fadeTime);
        }


    }

    public void EndGame(float fade)
    {
        fadeImage.SetTrigger("Activated");
    }
}
