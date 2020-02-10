using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float RotationSpeed = 5;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Input.GetKeyDown(KeyCode.LeftShift))
        {
            transform.rotation = Quaternion.Euler(0, 0, 180);
           
        }
    }
}
