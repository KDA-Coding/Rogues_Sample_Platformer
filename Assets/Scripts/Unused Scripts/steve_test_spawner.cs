using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class steve_test_spawner : MonoBehaviour
{
    [SerializeField] GameObject objectToSpawn;
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(objectToSpawn, transform.position, transform.rotation);
        }
        
    }
}
