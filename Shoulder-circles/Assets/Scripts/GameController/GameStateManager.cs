using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    public static GameStateManager Instance;
    public enum GameState
    {
        InitialState,
        Playing,
        Win,
        Lose
    }
    public GameState CurrentState;
    void Awake()
    {
        if (Instance == null)
        {
            Instance=this;
        }
        CurrentState=GameState.InitialState;
    }
    public void SetState(GameState newState)
    {
        CurrentState=newState;
    }
}
