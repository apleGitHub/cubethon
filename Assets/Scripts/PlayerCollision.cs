using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    void Start()
    {
        Debug.Log("Someone said I look like Marilyn Monroe if she ate Lizzo. (PlayerCollision script activated)");
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            Debug.Log("OH MY GOD WE HIT THE SECOND BLOCK");
        }
    }
}
