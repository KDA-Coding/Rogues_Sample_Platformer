using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile_Spawner : MonoBehaviour
{

    [SerializeField] private GameObject spawnPoint;
    [SerializeField] private GameObject projectileObject;

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.E) )
        {
            Instantiate(projectileObject, spawnPoint.transform.position, spawnPoint.transform.rotation);
        }

    }
}
