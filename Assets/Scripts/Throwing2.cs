using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Throwing2 : MonoBehaviour
{
    // Variables
    [SerializeField] private GameObject knife;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private float speed;
    [SerializeField] Text m_ToggleShootingText;
    public AudioSource sound;
    bool launched;
    public Text toggleShootingText
    {
        get { return m_ToggleShootingText; }
        set { m_ToggleShootingText = value; }
    }
    private void Start()
    {
        
        GetComponent<Throwing2>().enabled = false;
        sound = GetComponent<AudioSource>();
    }
    public void ThrowKnife() 
    {
        GameObject knifeInstance = Instantiate(knife, spawnPoint.position, knife.transform.rotation);
        knifeInstance.transform.rotation = Quaternion.LookRotation(spawnPoint.forward);
        Rigidbody knifeRig = knifeInstance.GetComponent<Rigidbody>();
        knifeRig.AddForce(spawnPoint.forward * speed, ForceMode.VelocityChange);
        sound.Play();
        launched = false;

    }
}
