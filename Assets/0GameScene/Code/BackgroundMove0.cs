/*
    생성일자 : 2025.10.10
    파일이름 : BackgroundMove0.cs
    생성자:
    내용: BackgroundManager0 애서 이동좌표와 속도 값을 받아서 이동하는 코드이다.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove0 : MonoBehaviour
{
 public BackgroundManager0 backgroundManager0;
    void Start()
    {
        StartCoroutine(MoveBackround());
    }

    IEnumerator MoveBackround()
    {
        while (true)
        {
            transform.position = new Vector2(transform.position.x + backgroundManager0.MoveX, transform.position.y + backgroundManager0.MoveY);
            yield return new WaitForSeconds(backgroundManager0.Speed);
        }
    }
}
