using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] BlockController blockController;
    
    public enum PlayerType {None, PlayerA, PlayerB}
    private PlayerType[,] _board;
    
    public enum TurnType {PlayerA, PlayerB};

    private void Start()
    {
        //게임 초기화
        InitGame();

    }

    public void startGame()
    {
        SetTurn(TurnType.PlayerA);
    }

    private void EndGame()
    {
        
    }
    
    
    /// <summary>
    /// 게임 초기화 함수
    /// </summary>
    public void InitGame()
    {
        //_board 초기화
        _board = new PlayerType[3, 3];
        
        //block 초기화
        blockController.InitBlocks();
        
    }
    

    void SetTurn(TurnType turnType)
    {
        switch (turnType)
        {
            case TurnType.PlayerA:
                break;
            case TurnType.PlayerB:
                break;
        }
    }
}
