using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour

{

    [SerializeField] float delayTime = 1f;
    AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    //Very simple script just listens to see if something touches it
    public void OnTriggerEnter2D(Collider2D collision)
    {
        //If it does touch something, print a message and destroy this coin
        audioSource.Play();
        StartCoroutine(PickupCoin());
    }

    IEnumerator PickupCoin()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
        yield return new WaitForSecondsRealtime(delayTime);
        Destroy(this.gameObject);

    }
}
