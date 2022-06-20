using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelExit : MonoBehaviour
{

    [SerializeField] float timeToDelay = 1f;
    ParticleSystem pSystem;

    // Start is called before the first frame update
    void Start()
    {
        pSystem = GetComponent<ParticleSystem>();   
    }


    /// <summary>
    /// loads new level when the objects collider is triggered
    /// NOTE: need to edit layers or create tag logic to avoid bullets triggering
    /// this 
    /// </summary>
    /// <param name="collision"></param>
    void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(LoadNextLevel());
    }


    /// <summary>
    /// if there is a next level to load, loads that level, otherwise loads the
    /// first level in the build 
    /// </summary>
    IEnumerator LoadNextLevel()
    {

        pSystem.Play();

        yield return new WaitForSecondsRealtime(timeToDelay);

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;

        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
    }

   
}
