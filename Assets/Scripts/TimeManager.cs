﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager
{
    public static void Pause()
    {
        Time.timeScale = 0;
    }

    public static void Resume()
    {
        Time.timeScale = 1;
    }
}
