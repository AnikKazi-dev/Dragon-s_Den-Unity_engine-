using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    int score = 0;
    Text scoreText;
    void Start()
    {
        scoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Scored()
    {
        score++;
        //Debug.Log("in score script");
        scoreText.text = score.ToString();
    }
}
