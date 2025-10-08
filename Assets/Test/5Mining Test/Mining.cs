/*
    생성일자 : 2025.10.03
    파일이름 : Mining.cs
    생성자:
    내용: x키를 누르면 지정한 오브젝트 비활성화  
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mining : MonoBehaviour
{
    [SerializeField] bool cont = false;

    void Update()
    {
        if (Input.GetKey(KeyCode.X))  // 키를 누르고 있는 동안
        {
            cont = true;
        }
        else
        {
            cont = false;
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (cont && collision.CompareTag("Test"))
        {
            collision.gameObject.SetActive(false);
        }
    }
}
