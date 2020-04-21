using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindGreenLights : MonoBehaviour
{
    public List<GameObject> TouchingObjects;
    void Start()
    {
        TouchingObjects = new List<GameObject>();

        Debug.Log(222222);
    }

    void OnTriggerEnter(Collider collision)
    {
        Debug.Log(234222222);
        if (!TouchingObjects.Contains(collision.gameObject))
            TouchingObjects.Add(collision.gameObject);
    }

    void OnTriggerExit(Collider collision)
    {
        if (TouchingObjects.Contains(collision.gameObject))
            TouchingObjects.Remove(collision.gameObject);
    }



}
