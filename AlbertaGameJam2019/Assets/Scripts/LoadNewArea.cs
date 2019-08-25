using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewArea : MonoBehaviour
{
    public string levelToLoad;
    

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("entered");
        if (other.gameObject.name == "Player")
        {
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
