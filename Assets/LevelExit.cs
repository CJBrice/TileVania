using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelExit : MonoBehaviour {

    [SerializeField] float levelLoadDelay = 0.1f;
	
	void OnTriggerEnter2D (Collider2D other)
    {
        StartCoroutine(LoadLevel());
	}

    IEnumerator LoadLevel()
    {
        //Time.timeScale = 0.2f; or levelExitSlowMoFactor
        yield return new WaitForSeconds(levelLoadDelay);
        //Time.timeScale = 1f;
        var currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
	
}
