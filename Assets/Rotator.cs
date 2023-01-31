using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float yawDegreesPerSecond = 45;
    // Update is called once per frame
    void Update()
    {
        Transform t = GetComponent<Transform>();
        t.Rotate(new Vector3(0f, yawDegreesPerSecond * Time.deltaTime, 0));
    }
}
