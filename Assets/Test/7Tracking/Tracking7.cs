/*
    생성일자 : 2025.10.14
    파일이름 : Tracking7.cs
    생성자:
    내용: 몬스터가 지정한 목표를 추적하는 코드이다.
*/
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;

public class Tracking7 : MonoBehaviour
{
    #region 태그 가지고 몬스터가 플레이어 추적하는 코드
    //[SerializeField] GameObject Monstor;
    // [SerializeField] float speed = 3.0f;


    // void Update()
    // {
    //     // "Player" 태그를 가진 오브젝트 찾기
    //     GameObject player = GameObject.FindGameObjectWithTag("Player");

    //     if (player != null)
    //     {
    //         Vector2 pos = player.transform.position;
    //         Debug.Log("플레이어 좌표: " + pos);
    //         Vector2 direction = (player.transform.position - transform.position).normalized;

    //         // 이동 (프레임 독립적으로)
    //         transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    //     }
    //     else
    //     {
    //         Debug.Log("플레이어를 찾지 못했습니다.");
    //     }
    // }
    #endregion

    #region 배열에 있는거 순서대로 찾아가는 코드(인덱스 오류 발생)
    // [SerializeField] GameObject[] bait = new GameObject[3];
    // [SerializeField] float speed = 3.0f;

    // [SerializeField] int number = 0;

    // [SerializeField] GameObject Momstor;

    // void Update()
    // {
    //     if (bait[number].transform.position == Momstor.transform.position)
    //     {

    //         if (number < bait.Length)
    //         {
    //             number++;
    //         }

    //     }
    //     else
    //     {
    //         Vector2 pos = bait[number].transform.position;
    //         Vector2 direction = (bait[number].transform.position - transform.position).normalized;
    //         transform.position = Vector2.MoveTowards(transform.position, bait[number].transform.position, speed * Time.deltaTime);
    //     }

    // }
    #endregion

    #region 배열 코드 오류 나서 쳇지피티 한태 수정 시킨거
    //     [SerializeField] GameObject[] bait = new GameObject[3];
    // [SerializeField] float speed = 3.0f;

    // [SerializeField] int number = 0;
    // [SerializeField] float reachThreshold = 0.1f; // 도달 거리 기준

    // void Update()
    // {
    //     // 배열 범위 체크
    //     if (number >= bait.Length)
    //         return; // 모든 먹이를 다 쫓았으면 종료

    //     GameObject targetBait = bait[number];
    //     if (targetBait == null)
    //         return;

    //     // 몬스터와 먹이 사이 거리 계산
    //     float distance = Vector2.Distance(transform.position, targetBait.transform.position);

    //     if (distance < reachThreshold)
    //     {
    //         // 먹이에 도달하면 다음 먹이로
    //         number++;
    //     }
    //     else
    //     {
    //         // 이동
    //         transform.position = Vector2.MoveTowards(transform.position, targetBait.transform.position, speed * Time.deltaTime);
    //     }
    // }

    #endregion
    [SerializeField] GameObject[] bait = new GameObject[3];
    [SerializeField] float speed = 3.0f;

    [SerializeField] int number = 0;

    [SerializeField] GameObject Momstor;
    [SerializeField] bool arriveBool = true;
    void Update()
    {
        if (number == bait.Length - 1)
        {
            arriveBool = false;
        }
        
        if (bait[number].transform.position == Momstor.transform.position && arriveBool ==true)
        {
            number++;
           
        }
        else
        {
            Vector2 pos = bait[number].transform.position;
            Vector2 direction = (bait[number].transform.position - transform.position).normalized;
            transform.position = Vector2.MoveTowards(transform.position, bait[number].transform.position, speed * Time.deltaTime);
        }
        
    }

}
