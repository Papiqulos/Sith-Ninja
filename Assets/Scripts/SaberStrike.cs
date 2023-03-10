using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaberStrike : MonoBehaviour
{
    public GameObject saber;
    public AudioSource tickSource;
    public void Start()
    {
        tickSource = GetComponent<AudioSource>();
    }
    
    public void Strike()
    {
        
        tickSource.Play();
        saber.GetComponent<Animator>().SetTrigger("Sabertrigger");
    }
}
