/*
    생성일자 : 2025.10.10
    파일이름 : GameManager0.cs
    생성자:
    내용: GameScene의 변수들의 통합 관리하는 게임 매니저 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager0 : MonoBehaviour
{
    [SerializeField] public int arrayNumber = 126;
    [SerializeField] public GameObject[] scaneObjcet; //= new GameObject[126];
    [SerializeField] public Vector3[] testObjectPos; //= new Vector3[126];

    [SerializeField] public bool scenCompete = false;
    public int ArrayNumber
    {
        get { return arrayNumber; }
        set { value = arrayNumber; }
    }
    public GameObject[] ScaneObjcet
    {
        get { return scaneObjcet; }
        set { value = scaneObjcet; }
    }
    public Vector3[] TestObjectPos
    {
        get { return testObjectPos; }
        set { value = testObjectPos; }
    }

    public bool ScenCompete
    {
         get { return scenCompete; }
        set { value = scenCompete; }
    }

    private void Start()
    {
        scaneObjcet = new GameObject[arrayNumber];
        testObjectPos = new Vector3[arrayNumber];
    }

}
