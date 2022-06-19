using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile_Mover : MonoBehaviour
{

    // missileSpeed to alter how fast missile moves
    [SerializeField] float missileSpeed = 1f;
    Rigidbody2D rb2d;

    //Animation for Missile Explosion
    [SerializeField] private Animation anim;

    void Start()
    {

        anim = gameObject.GetComponent<Animation>();

        MoveForward();
    }


    /// <summary>
    /// moves missile forward, will be called in start method so the effect is
    /// achieved right when the missile is instantiated by the shooter object
    /// </summary>
    void MoveForward()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = transform.right * missileSpeed;
    }


    /// <summary>
    /// When missile collides into object, destroys the missile
    /// </summary>

    // Testing Missile Animation on Missile Destroyed

    void OnCollisionEnter2D(Collision2D collision)
    {

        anim.Play("Explosion");

        Destroy(gameObject); 
    }


}
