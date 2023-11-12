using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Damage : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            string currentScene = SceneManager.GetActiveScene ().name; 
			Debug.Log (currentScene); 
			//Here we are asking the SceneManager to load the desired scene. In this instance we're providing it our variable 'currentScene'
			SceneManager.LoadScene(currentScene);
        }
    }
}