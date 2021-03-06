﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
    public static int minute;
    public static float seconds;
    private float oldSeconds;
    public Text timerText;

    void Start () {
		minute = 0;
		seconds = 0f;
		oldSeconds = 0f;
		timerText.text = minute.ToString("00") + ":" + ((int) seconds).ToString ("00");
	}

    // Update is called once per frame
    void Update () {
		seconds += Time.deltaTime;
		if(seconds >= 60f) {
			minute++;
			seconds = seconds - 60;
		}
		//　値が変わった時だけテキストUIを更新
		if((int)seconds != (int)oldSeconds) {
			timerText.text = minute.ToString("00") + ":" + ((int) seconds).ToString ("00");
		}
		oldSeconds = seconds;
	}
}
