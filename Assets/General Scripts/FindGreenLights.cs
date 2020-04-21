using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindGreenLights : MonoBehaviour
{
    public List<GameObject> TouchingObjects;
    public Seek seekScript;

    float distanceToTarget;

    void Start()
    {
        TouchingObjects = new List<GameObject>();
        seekScript = GetComponent<Seek>();
        
    }

    void OnTriggerStay(Collider collision)
    {
       
        if (!TouchingObjects.Contains(collision.gameObject))
            TouchingObjects.Add(collision.gameObject);
    }

    void OnTriggerExit(Collider collision)
    {
        if (TouchingObjects.Contains(collision.gameObject))
            TouchingObjects.Remove(collision.gameObject);
    }


    private void Update()
    {
        if(seekScript.targetGameObject== null || seekScript.targetGameObject.layer == 0)
        {
            if(TouchingObjects.Count == 0)
            {
                return; //dont throw an error, just wait for one to turn up
            }

            seekScript.targetGameObject = TouchingObjects[Random.Range(0,TouchingObjects.Count - 1)];
        }

        distanceToTarget = Vector3.Distance(transform.position, seekScript.targetGameObject.transform.position);

        if(distanceToTarget < 0.5f)
        {
            TouchingObjects.Remove(seekScript.targetGameObject);
            seekScript.targetGameObject = TouchingObjects[Random.Range(0, TouchingObjects.Count- 1)];
        }
    }
}
