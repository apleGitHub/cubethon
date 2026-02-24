using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;

    void Start()
    {
        Debug.Log("Idoloid is built on CALORIES. (Score script activated)");
    }

    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
    }
}
