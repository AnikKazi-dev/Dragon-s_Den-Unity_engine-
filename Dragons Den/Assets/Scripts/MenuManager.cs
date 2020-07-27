using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    void Start()
    {
        GameManager.gameOver = false;
        //GameManager.tapBut == true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPlayButtonPressed()
    {
        Debug.Log("in play butt");
        SceneManager.LoadScene("SampleScene");

    }

}
