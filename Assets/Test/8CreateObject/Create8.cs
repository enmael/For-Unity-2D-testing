using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create8 : MonoBehaviour
{
    [SerializeField] float posX = 1f;
    [SerializeField] float posY = 1f;
    [SerializeField] bool cont = false;

    [SerializeField] Vector3 pos;
    [SerializeField] GameObject createdObject;

    private bool hasSpawned = false; // 한 번 생성 여부 체크

    void Update()
    {
        pos = transform.position;

        // 방향키 한 칸씩 이동
        if (Input.GetKeyDown(KeyCode.UpArrow)) { pos.y += posY; }
        if (Input.GetKeyDown(KeyCode.DownArrow)) { pos.y -= posY; }
        if (Input.GetKeyDown(KeyCode.RightArrow)) { pos.x += posX; }
        if (Input.GetKeyDown(KeyCode.LeftArrow)) { pos.x -= posX; }

        transform.position = pos;

        // X키 입력 처리
        if (Input.GetKey(KeyCode.X))
        {
            if (hasSpawned == false)
            {
                SpawnObject();
                cont = true;
                hasSpawned = true; // 한 번 생성 후 다시 생성 막음
            }
        }
        else
        {
            cont = false;
            hasSpawned = false; // 키를 떼면 다시 생성 가능
        }
    }

    void SpawnObject()
    {
        Vector3 spawnPos = pos;
        Instantiate(createdObject, spawnPos, Quaternion.identity);
    }
}
