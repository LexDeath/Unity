using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : MonoBehaviour
{

    public bool IsRotation;

    void Update()
    {
       
        if (IsRotation)
        {
            transform.Rotate (new Vector3(-5,0,0) * Time.deltaTime);
        }
    }
}

