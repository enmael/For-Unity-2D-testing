/*
    생성일자 : 2025.10.03
    파일이름 : ScanGameObject.cs
    생성자:
    내용: 특정 태그를 가진 오브젝트를 스캔해서 배열에 저장하는 코드.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScanGameObject : MonoBehaviour
{
    [SerializeField] GameObject[] scaneTest = new GameObject[20];
    [SerializeField] int number = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (number < scaneTest.Length)
        {
             if (collision.CompareTag("Test"))
            {
                scaneTest[number] = collision.gameObject;
                number++;
            }     
        }
    }
}


