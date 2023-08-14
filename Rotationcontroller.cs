using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotationcontroller : MonoBehaviour
{
    public Vector3 rotationVector;

    private void Update()
    {
        transform.Rotate(rotationVector * Time.deltaTime);
    }
    
}
