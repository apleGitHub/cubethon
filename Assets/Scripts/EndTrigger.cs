using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public PlayerMovement movement;

    private void OnTriggerEnter()
    {
        movement.enabled = false;
        gameManager.CompleteLevel();
    }
}
