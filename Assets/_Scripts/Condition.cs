﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Condition : MonoBehaviour
{
    public virtual bool Test()
    {
        return false;
    }
}