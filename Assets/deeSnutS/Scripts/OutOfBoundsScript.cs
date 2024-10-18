using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBoundsScript : MonoBehaviour
{
    public XR_Stopwatch stopwatch;

    Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("OutOfBounds"))
        {
            transform.position = startPosition;
            if (stopwatch != null) stopwatch.StopTimer();
        }
    }
}
