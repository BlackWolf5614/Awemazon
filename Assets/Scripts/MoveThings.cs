using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveThings : MonoBehaviour
{
    public Transform targetPoint;


    public float lerpSpeed = 0.25f;
    public float startDelay = 3f;

    private void Start()
    {
        InvokeRepeating("MoveDaThing", startDelay, 0.01f);
    }


    void MoveDaThing()
    {
        //transform.position = Vector3.Lerp(transform.position, targetPoint.position, lerpSpeed);

        transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, lerpSpeed);
    }
}
