﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int valueScore;
    void Start()
    {
        valueScore = 0;
    }
    
    void Update()
    {
        GetComponent<Text>().text = valueScore.ToString();
    }
}
