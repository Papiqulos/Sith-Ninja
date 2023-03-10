using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class LightSaberKill : MonoBehaviour
{
    public AudioSource tick;
    private void Start()
    {
        tick = GetComponent<AudioSource>();
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemies")
        {

            tick.Play();
            Destroy(collision.gameObject);
        }
    }
}
