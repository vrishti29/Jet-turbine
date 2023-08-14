using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hover : MonoBehaviour
{
    private void Update() {
      Vector3 p = transform.position;
      p.y = Mathf.Cos(Time.time);
      transform.position = p;
    }
}
