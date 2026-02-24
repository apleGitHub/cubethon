using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;

    public void CompleteLevel ()
    {
        Debug.Log("Detting thrown off the Titanic into the North Atlantic Ocean and turning it into Popeyes Iced Sweet Tea cuz my body so Lipton. (CompleteLevel activated)");
        completeLevelUI.SetActive(true);
    }

    public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("When the tea is trade but the finna is Matcha Latte Dubai Chocolate Labubu Solo Poly Hijabi Amputee Sis I'm dead as a DL. (EndGame activated)");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
