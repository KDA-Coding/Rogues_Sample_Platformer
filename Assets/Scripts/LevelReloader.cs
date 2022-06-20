using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelReloader : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D collision)
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentLevel);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Missile"))
        {
            int currentLevel = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentLevel);
        }
        else { return; }
    }

}
