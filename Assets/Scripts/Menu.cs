using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGame ()
    {
        Debug.Log("HELP HELP ME OH MY GOD HELP ME PLEASE FREE ME FROM THIS TORTUROUS PLACE HELP ME PLEASE (StartGame activated)");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
