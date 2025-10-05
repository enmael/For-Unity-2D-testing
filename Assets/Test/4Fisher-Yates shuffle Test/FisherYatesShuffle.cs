/*
    생성일자 : 2025.10.05
    파일이름 : FisherYatesShuffle.cs
    생성자:
    내용: 스페이스키를 누르면 피셔에이츠 셔플 알고리즘 동작하는 코드 완성 
*/
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class FisherYatesShuffle : MonoBehaviour
{
    [SerializeField] public int number = 0;
    [SerializeField] public GameObject[] testObject = new GameObject[10];
    [SerializeField] public Vector3[] testObjectPos;



    void Start()
    {
        number = testObject.Length;
        // testObject = new GameObject[number];
        testObjectPos = new Vector3[number];
        
        // Debug.Log("testObject.Length;: " +testObject.Length);
        // Debug.Log("number: " +number);

        for (int i = 0; i < number; i++)
        {
            testObjectPos[i] = testObject[i].transform.position;
        }

        //Shuffle();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // 스페이스바 눌렀을 때
        {
            Shuffle();
        }
    }

    public void Shuffle()
    {
        for (int j = number - 1; j > 0; j--)
        {
            int randomValue = Random.Range(0, j + 1);

            Vector3 tempPos = testObjectPos[j];

            testObjectPos[j] = testObjectPos[randomValue];
            testObjectPos[randomValue] = tempPos;
        }

        for (int v = 0; v < number; v++)
        {
            testObject[v].transform.position = testObjectPos[v];
        }
    }
}
