﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicReaction : MonoBehaviour
{
    public float playerMagic;
    //public Signal magicSignal;
    

    public void Use(int amountToIncrease)
    {
        playerMagic/*.RuntimeValue*/ += amountToIncrease;
        //magicSignal.Raise();
    }
}
