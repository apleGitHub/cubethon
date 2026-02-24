using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public void LoadNextLevel ()
    {
        Debug.Log("Ooooorrrugh.... Rubs my bellay. (LoadNextLevel activated)");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
