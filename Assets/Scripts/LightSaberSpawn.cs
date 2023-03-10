using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSaberSpawn : MonoBehaviour
{
    [SerializeField] private GameObject ArmAndSaber;
    [SerializeField] private Transform spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        SpawnSaber();
    }

    // Update is called once per frame
    public void Update()
    {
        
    }


    public void SpawnSaber()
    {
        GameObject SaberInstance = Instantiate(ArmAndSaber, spawnPoint.position, ArmAndSaber.transform.rotation);
        SaberInstance.transform.rotation = Quaternion.LookRotation(spawnPoint.forward);
    }
}
