/*
    생성일자 : 2025.10.10
    파일이름 : BackgroundManager0.cs
    생성자:
    내용: 배경의 속, 이동바향 반복 등을 관리하는 코드이다 .
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundManager0 : MonoBehaviour
{
    // [SerializeField] List<GameObject> spaceBlockList;
    [SerializeField] GameObject[] spaceBlocArray = new GameObject[4];
    [SerializeField] public float speed = 1f;
    [SerializeField] public float moveX = 1f;
    [SerializeField] public float moveY = 1f;

    public float Speed
    {
        get { return speed; }
    }

    public float MoveX
    {
        get { return moveX; }
    }

    public float MoveY
    {
        get { return moveY; }
    }

    void Start()
    {
        //spaceBlockList.Capacity = 20;

        StartCoroutine(BackgroundReuse());
    }

    IEnumerator BackgroundReuse()
    {
        while (true)
        {
            for (int i = 0; i < spaceBlocArray.Length; i++)
            {
                Vector2 pos = spaceBlocArray[i].transform.position;

                if (pos.x >= 20) { pos.x = -20; }
                if (pos.y >= 20) { pos.y = -20; }
                spaceBlocArray[i].transform.position = pos;
            }
            yield return new WaitForSeconds(0.1f);
        }
    }
}
