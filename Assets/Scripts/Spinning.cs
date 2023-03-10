using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinning : MonoBehaviour
{
  

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(10f, 10000f, 100f) * Time.deltaTime);
    }
}
