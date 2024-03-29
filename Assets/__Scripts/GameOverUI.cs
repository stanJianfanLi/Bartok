﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverUI : MonoBehaviour {
    private Text txt;

	// Use this for initialization
	void Awake () {
        txt = GetComponent<Text>();
        txt.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		if (Bartok.S.phase != TurnPhase.gameOver)
        {
            txt.text = "";
            return;
        }
        if (Bartok.CURRENT_PLAYER == null)
        {
            return;
        }
        if (Bartok.CURRENT_PLAYER.type == PlayerType.human)
        {
            txt.text = "You won!";
        }
        else
        {
            txt.text = "Game Over";
        }
        
	}
}
