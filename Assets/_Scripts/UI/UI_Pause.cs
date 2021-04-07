﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Pause : MonoBehaviour
{

  GameManager gm;

  private void OnEnable()
  {
      gm = GameManager.GetInstance();
  }
 
  public void Return()
  {
      gm.ChangeState(GameManager.GameState.GAME);
  }

  public void Begin()
  {
      gm.ChangeState(GameManager.GameState.MENU);
  }

}