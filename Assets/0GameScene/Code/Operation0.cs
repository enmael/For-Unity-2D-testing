/*
    생성일자 : 2025.10.10
    파일이름 : Operation0.cs
    생성자:
    내용: 조작용 코드 
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operation0 : MonoBehaviour
{
    [SerializeField] float posX = 1f;
    [SerializeField] float posY = 1f;
    [SerializeField] bool cont = false;

    void Update()
    {
        Vector3 pos = transform.position;

        // 방향키 한 칸씩 이동
        if (Input.GetKeyDown(KeyCode.UpArrow)) { pos.y += posY; }
        if (Input.GetKeyDown(KeyCode.DownArrow)) { pos.y -= posY; }
        if (Input.GetKeyDown(KeyCode.RightArrow)) { pos.x += posX; }
        if (Input.GetKeyDown(KeyCode.LeftArrow)) { pos.x -= posX; }

        transform.position = pos;

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
