/*
    생성일자 : 2025.10.10
    파일이름 : Shuffle0.cs
    생성자:
    내용: GameManager에서 저장된 배열의 위치값을 셔플 하여 랜덤하게 재배치하는 코드이다.
*/
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class Shuffle0 : MonoBehaviour
{
    public GameManager0 gameManager0;

    private System.Random rnd = new System.Random();

    [SerializeField] public bool shuffleGANEUNG = true;
    void Update()
    {
        if(shuffleGANEUNG ==true && gameManager0.scenCompete ==true)
        {
            Shuffle();
            shuffleGANEUNG = false;
            
        }
    }


    public void Shuffle()
    {
        for (int i = gameManager0.arrayNumber - 1; i > 0; i--)
        {
            int value = rnd.Next(0, i + 1);

            Vector3 tempPos = gameManager0.TestObjectPos[i];

            gameManager0.TestObjectPos[i] = gameManager0.TestObjectPos[value];
            gameManager0.TestObjectPos[value] = tempPos;

        }

        for (int v = 0; v < gameManager0.arrayNumber; v++)
        {
            gameManager0.ScaneObjcet[v].transform.position = gameManager0.TestObjectPos[v];

        }

    }
}
