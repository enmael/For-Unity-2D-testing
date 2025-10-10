using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fabricate6 : MonoBehaviour
{
    [SerializeField] float posX = 1f;
    [SerializeField] float posY = 1f;

    void Update()
    {
        Vector3 pos = transform.position;
        
        // 방향키 한 칸씩 이동
        if (Input.GetKeyDown(KeyCode.UpArrow)) { pos.y += posY; }
        if (Input.GetKeyDown(KeyCode.DownArrow)) { pos.y -= posY; }
        if (Input.GetKeyDown(KeyCode.RightArrow)) { pos.x += posX; }
        if (Input.GetKeyDown(KeyCode.LeftArrow)) { pos.x -= posX; }

        if (pos.x <= 2 && pos.x>=-2 && pos.y <= 4 && pos.y>=-4 )
        {
                    transform.position = pos;
        }
        //transform.position = pos;

    }
}
