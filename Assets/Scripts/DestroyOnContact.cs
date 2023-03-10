using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DestroyOnContact : MonoBehaviour
{
    private void Start()
    {
        tickSource = GetComponent<AudioSource>();
    }
    public AudioSource tickSource;
    private void OnCollisionEnter(Collision collision)
    {
        if ( collision.gameObject.tag == "Enemies")
        {
         
            tickSource.Play();
            Destroy(collision.gameObject);
        }
    }

}
