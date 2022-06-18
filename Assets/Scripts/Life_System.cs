using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life_System : MonoBehaviour
{

    [SerializeField] float healthPoints = 100;
    [SerializeField] GameObject explosion;  

    bool isDead = false;


    private void Update()
    {
        if (isDead) { Die(); }
        
    }


    /// <summary>
    /// Every time the object collides with another object, subtract 100
    /// points from their health, if healthpoints are 0 or less, isDead bool
    /// becomes true 
    /// </summary>
    /// <param name="collision"></param>
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground")) { return; }

        healthPoints -= 100;
        if (healthPoints <= float.Epsilon) 
        {
            isDead = true;
        }
    }

    /// <summary>
    /// Instantiates an explosion object at the position of the object being
    /// destroyed, after instantation destroy the original object
    /// 
    /// NOTE: the behavior of the explosion itself is handled in Exploder script
    /// </summary>
    void Die()
    {
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(gameObject);
    }

}
