using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextLevel_Maze : MonoBehaviour
{
    public Animator SceneTransition;

    void OnCollisionEnter2D(Collision2D other)
    {
     if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine("LoadLevel");
        }
    }

    IEnumerator LoadLevel()
    {
        SceneTransition.SetTrigger("Start");
        yield return new WaitForSeconds(1);
        // Change this string value for your scene name
        SceneManager.LoadScene("Level 2");
    }
}
