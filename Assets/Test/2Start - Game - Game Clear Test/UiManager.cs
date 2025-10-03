/*
    생성일자 : 2025.10.03
    파일이름 : UiManager.cs
    생성자:
    내용: 시작버튼 누르면 게임시작
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    [SerializeField] private GameObject UiGameObject;

    [SerializeField] private Button StartButton;

    [SerializeField] public GameObject[] testBlock = new GameObject[20];

      public GameObject[] TestBlock
    {
        get { return testBlock; }
        set {value = testBlock;}
    }
    private void Start()
    {
        // 버튼 클릭 시 OnClickStartGame 실행
        StartButton.onClick.AddListener(OnClickStartGame);
    }

    public void OnClickStartGame()
    {
       
       UiGameObject.SetActive(false);
        for (int i = 0; i < testBlock.Length; i++)
        {
            testBlock[i].SetActive(true);
        }
        // 게임 시작 로직 실행
        Debug.Log("게임 시작!");
    }

}
