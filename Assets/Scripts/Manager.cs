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
    public GameObject[] environment2;
    public GameObject[] environment3;
    float timer;
    bool turnOff1 = false;
    bool turnOff2 = false;
    bool turnOff3 = false;

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= endGameTime)
        {
            EndGame(fadeTime);
        }

        if (turnOff1 == false && timer >= 45 && timer <= 50)
        {
            turnOff1 = true;
            turnOff2 = true;
            turnOff3 = true;
            foreach (GameObject thing in environment)
            {
                thing.SetActive(false);
            }
            foreach (GameObject thing in environment2)
            {
                thing.SetActive(false);
            }
            foreach (GameObject thing in environment3)
            {
                thing.SetActive(false);
            }
            print("turned off environment");
        }
        else if(turnOff1 == true && timer >= 145)
        {
            turnOff1 = false;
            foreach (GameObject thing in environment)
            {
                thing.SetActive(true);
            }
            print("turned on environment");
        }
        else if (turnOff2 == true && timer >= 146)
        {
            turnOff2 = false;
            foreach (GameObject thing in environment2)
            {
                thing.SetActive(true);
            }
            print("turned on environment");
        }
        else if (turnOff3 == true && timer >= 147)
        {
            turnOff3 = false;
            foreach (GameObject thing in environment3)
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
