using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLights : MonoBehaviour
{
    float radius = 10;
    float noOfLights = 10;
    public List<GameObject> elements = new List<GameObject>();


    void Awake()
    {
        float theta = Mathf.PI * 2.0f / noOfLights;
        for (int i = 0; i < noOfLights; i++)
        {
            Vector3 p = new Vector3(Mathf.Sin(theta * i) * radius, 0, Mathf.Cos(theta * i) * radius);
            p = transform.TransformPoint(p);
            Quaternion q = Quaternion.AngleAxis(theta * i * Mathf.Rad2Deg, Vector3.up);
            q = transform.rotation * q;

            GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
            cylinder.transform.SetPositionAndRotation(p, q);
            cylinder.transform.parent = this.transform;
            cylinder.GetComponent<Renderer>().material.color = Color.yellow;
            cylinder.AddComponent<Light>();
            elements.Add(cylinder);
        }
    }


}
