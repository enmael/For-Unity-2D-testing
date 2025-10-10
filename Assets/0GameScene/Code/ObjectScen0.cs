/*
    생성일자 : 2025.10.10
    파일이름 : ObjectScen0.cs
    생성자: 
    내용: 지정한 속도로 이동하면서 지정한태그를 가진 오브젝트를 스캔하여 GameManager의 scaneObjcet의 배열에 저장하는 코드 
*/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScen : MonoBehaviour
{

    public GameManager0 gameManager0;
    [SerializeField] int number = 0;
    public float speed = 1f; 
    
    void Update()
    {
        if (transform.position.y > -5)
        {
            transform.position -= new Vector3(0f, speed * Time.deltaTime, 0f);
        }

        if(gameManager0.arrayNumber  == number)
        {
            gameManager0.scenCompete = true;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (number < gameManager0.ScaneObjcet.Length)
        {
            if (collision.CompareTag("Test") || collision.CompareTag("MainBox"))
            {
                gameManager0.ScaneObjcet[number] = collision.gameObject;
                gameManager0.TestObjectPos[number]= collision.gameObject.transform.position;
                number++;

            }
        }
    }
    

}
