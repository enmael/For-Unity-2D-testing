/*
    생성일자 : 2025.10.03
    파일이름 : MiningTestMove2.cs
    생성자:
    내용: 방향키를 누를때마다 이동하고 x키를 누르면 오브젝트를 비활성화 하는 코드이다.
    -오브젝트를 연속적으로 비활성화 하기 위해 리스트에 넣고 제거하는 과정을 추가됨 
*/
#region 이전 코드
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class MiningTestMove2 : MonoBehaviour
// {

//     [SerializeField] float posX = 1f;
//     [SerializeField] float posY = 1f;
//     void Update()
//     {
//         Vector3 pos = transform.position;

//         if (Input.GetKeyDown(KeyCode.UpArrow))
//             pos.y += posY;
//         if (Input.GetKeyDown(KeyCode.DownArrow))
//             pos.y -= posY;
//         if (Input.GetKeyDown(KeyCode.RightArrow))
//             pos.x += posX;
//         if (Input.GetKeyDown(KeyCode.LeftArrow))
//             pos.x -= posX;

//         transform.position = pos;
//     }


//     private void OnTriggerStay2D(Collider2D collision)
//     {
//     if (collision.CompareTag("Test") && Input.GetKeyDown(KeyCode.X))
//     {
//         collision.gameObject.SetActive(false);
//     }
//     }

// } 
#endregion
using System.Collections.Generic;
using UnityEngine;

public class MiningTestMove2 : MonoBehaviour
{
    [SerializeField] float posX = 1f;
    [SerializeField] float posY = 1f;

    private List<Collider2D> objectsInTrigger = new List<Collider2D>();

    void Start()
    {
        objectsInTrigger.Capacity = 20;
    }
    void Update()
    {
        Vector3 pos = transform.position;

        // 방향키 한 칸씩 이동
        if (Input.GetKeyDown(KeyCode.UpArrow)) { pos.y += posY; }
        if (Input.GetKeyDown(KeyCode.DownArrow)) { pos.y -= posY; }
        if (Input.GetKeyDown(KeyCode.RightArrow)) { pos.x += posX; }
        if (Input.GetKeyDown(KeyCode.LeftArrow)) { pos.x -= posX; }

        transform.position = pos;

        // X키를 누르면 트리거 안 오브젝트 순서대로 비활성화
        if (Input.GetKeyDown(KeyCode.X) && objectsInTrigger.Count > 0)
        {
            objectsInTrigger[0].gameObject.SetActive(false);
            objectsInTrigger.RemoveAt(0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Test") && !objectsInTrigger.Contains(collision))
        {
            objectsInTrigger.Add(collision);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Test"))
        {
            objectsInTrigger.Remove(collision);
        }
    }
}