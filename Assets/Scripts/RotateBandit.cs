using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBandit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(new Vector3(0f, 1000f, 0f) * Time.deltaTime);
    }
}

    
