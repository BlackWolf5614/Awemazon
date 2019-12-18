using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public Animator fadeImage;

    public float endGameTime = 10f;
    public float fadeTime = 2f;
    public GameObject[] environment;
    float timer;
    bool turnOff = false;

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= endGameTime)
        {
            EndGame(fadeTime);
        }

        if (turnOff == false && timer >= 45 && timer <= 50)
        {
            turnOff = true;
            foreach (GameObject thing in environment)
            {
                thing.SetActive(false);
            }
            print("turned off environment");
        }
        else if(turnOff == true && timer >= 145 && timer <= 150)
        {
            turnOff = false;
            foreach (GameObject thing in environment)
            {
                thing.SetActive(true);
            }
            print("turned on environment");
        }

    }

    public void EndGame(float fade)
    {
        fadeImage.SetTrigger("Activated");
    }
}
