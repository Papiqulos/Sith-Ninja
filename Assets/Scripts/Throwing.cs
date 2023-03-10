using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwing : MonoBehaviour
{
    [SerializeField] private GameObject shurikenPrefab;
    [SerializeField] private float delayBetweenShurikens;
    [SerializeField] private float shurikenLauchForce;
    [SerializeField] private List<Transform> projectileSpawnTransforms = new List<Transform>();

    private void Update()
    {
        if (Input.touchCount == 1)
        {
            StartCoroutine(TouchAttack());
        }

         IEnumerator TouchAttack()
        {
            int shurikensFired = 0;

            while(shurikensFired < 3)
            {
                shurikensFired++;
                GameObject projectileInstance = Instantiate(shurikenPrefab, projectileSpawnTransforms[1].position, Quaternion.identity);
                projectileInstance.transform.rotation = Quaternion.LookRotation(projectileSpawnTransforms[1].forward);
                projectileInstance.GetComponent<Rigidbody>().AddForce(projectileInstance.transform.forward * shurikenLauchForce, ForceMode.VelocityChange);
                yield return new WaitForSeconds(delayBetweenShurikens);
            }

            yield return null;
        }
        
    }
}
