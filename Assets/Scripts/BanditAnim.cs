using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanditAnim : MonoBehaviour
{
    public GameObject bandit;
    public void Start()
    {
        
    }

    public void Update()
    {

        bandit.GetComponent<Animator>().SetTrigger("Walk");
    }
}
