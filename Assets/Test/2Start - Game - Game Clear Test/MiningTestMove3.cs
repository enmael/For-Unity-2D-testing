/*
    생성일자 : 2025.10.03
    파일이름 : MiningTestMove3.cs
    생성자:
    내용: 이코드를 보고 알게된것은 중앙에서 변수를 관리하는게 얼마나 중요한지 알게됨 나중에 그렇게 수정할거다
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiningTestMove3 : MonoBehaviour
{
    [SerializeField] float posX = 1f;
    [SerializeField] float posY = 1f;

    private List<Collider2D> objectsInTrigger = new List<Collider2D>();

    [SerializeField] public int number = 0;

    [SerializeField] public bool gameClear = false;
    
    public int Number
    {
        get { return number; }
        set { value = number; }

    }

    public bool GameClear
    {
        get { return gameClear; }
        set { value = gameClear; }
    }
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
            number = number + 1;
            objectsInTrigger[0].gameObject.SetActive(false);
            objectsInTrigger.RemoveAt(0);
        }
            Debug.Log("number:"+number);
        if (number == 2)
        {
            gameClear = true;
            number = 0;
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
