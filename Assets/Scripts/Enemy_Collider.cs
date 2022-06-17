using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Collider : MonoBehaviour
{
    /// <summary>
    /// when object is collided into, destroys the object
    /// (More functionality TBD when goals are clear)
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

}
