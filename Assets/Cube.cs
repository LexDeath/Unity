using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public bool IsTranslate;
    

    void Update()
    {
        if (IsTranslate)
        {
            transform.position = transform.position + new Vector3(0, 0, 2) * Time.deltaTime;

        }
      
    }
}
