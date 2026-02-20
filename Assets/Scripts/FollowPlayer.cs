using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    void Start()
    {
        Debug.Log("What would you do if when you okay so he said yes would go? (FollowPlayer script activated)");
    }
    void Update()
    {
        transform.position = player.position + offset;
    }
}
