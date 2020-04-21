using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    List<GameObject> elements;
    Color[] colours = { Color.red, Color.yellow, Color.green };

    void Start()
    {
        elements = GetComponent<SpawnLights>().elements;
        RandomiseLightsAtStart();
    }

    void RandomiseLightsAtStart()
    {
        foreach (GameObject g in elements)
        {
            g.GetComponent<Renderer>().material.color = colours[Random.Range(0, 3)];
        }
    }

}
