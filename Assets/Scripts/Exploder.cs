using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exploder : MonoBehaviour
{
    [SerializeField] float explosionLength = 1f; // how long explosion remains instantiated

    // Update is called once per frame
    void Update()
    {
        if (explosionLength <= float.Epsilon) {EndExplosion();}
        ContinueExplosion();
    }


    /// <summary>
    /// subtracts 1 from the explosionLength and moves the exlosion up slightly.
    /// runs as long as exlosioLength is not 0 or less
    /// </summary>
    void ContinueExplosion()
    {
        explosionLength--;
        gameObject.transform.Translate(transform.up * Time.deltaTime, Space.World);
    }


    /// <summary>
    /// Destroys the game explosion game object 
    /// </summary>
    void EndExplosion()
    {
        Destroy(gameObject);
    }
}
