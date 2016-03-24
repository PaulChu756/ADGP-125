﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ScoreManager : MonoBehaviour
{
    public static int score;
    public int scoreSmallEnemy = 5;
    public int scoreMediumEnemy = 10;
    public int scoreLargeEnemy = 15;
    public int scoreBoss = 20;
    public Text scoreText;
   
    void Awake()
    {
        GUIManager.instance.TurnOn(scoreText.gameObject);
        score = 0;
    }

    void Update()
    {
        scoreText.text = "Score: " + score;

        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    GUIManager.instance.TurnOn(scoreText.gameObject);
        //    Debug.Log(gameObject + "On");
        //}

        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    GUIManager.instance.TurnOff(scoreText.gameObject);
        //    Debug.Log(gameObject + "Off");
        //}
    }
}