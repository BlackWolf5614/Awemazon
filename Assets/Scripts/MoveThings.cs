using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveThings : MonoBehaviour
{
    public Transform targetPoint;
    public static float timeToHalfwaypoint = 75f;
    float timer;
    float percent;
    Vector3 difference;
    Vector3 startPoint;

    public float startDelay = 3f;
    bool reachedTarget = false;
    bool run = false;


    private void Start()
    {
        startPoint = transform.position;
        difference = targetPoint.position - startPoint;
        Invoke("StartDelay", startDelay);
    }

    private void Update()
    {
        if (run)
        {
            if (timer <= timeToHalfwaypoint && reachedTarget == false)
            {
                timer += Time.deltaTime;
                percent = timer / timeToHalfwaypoint;
                transform.position = startPoint + difference * percent;
                
            }
            else
            {
                if (reachedTarget == false)
                {
                    reachedTarget = true;
                }
                timer -= Time.deltaTime;
                percent = timer / timeToHalfwaypoint;
                transform.position = startPoint + difference * percent;
                if (percent <= 0)
                {
                    run = false;
                }
            }
        }
    }

    void StartDelay()
    {
        run = true;
    }
}
