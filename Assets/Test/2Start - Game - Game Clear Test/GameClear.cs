/*
    생성일자 : 2025.10.03
    파일이름 : MiningTestMove3.cs
    생성자:
    내용: 중앙에서 변수를 관리하지 않으니 클리어버튼이 사라지지 않는 버그 발생 이문제는 나중에 해결 중요한걸 깨달음 
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameClear : MonoBehaviour
{

    public UiManager uiManager;
    public MiningTestMove3 miningTestMove3;


    [SerializeField] private GameObject UiClearGameObject;
    [SerializeField] private GameObject UiGameObject2;
    [SerializeField] private Button RestartButton;

    [SerializeField] public GameObject playerObject;
    private void Start()
    {
        // 버튼 클릭 시 OnClickStartGame 실행
        RestartButton.onClick.AddListener(OnClickRestart);
    }

    void Update()
    {
        if (miningTestMove3.GameClear == true)
        {
            UiClearGameObject.SetActive(true);
            //playerObject.SetActive(false);
            //miningTestMove3.Number = 0;
           
        }
        //Debug.Log("miningTestMove3.GameClear:"+ miningTestMove3.GameClear);
    }

    public void OnClickRestart()
    {
        miningTestMove3.GameClear = false;
        UiGameObject2.SetActive(true);
        UiClearGameObject.SetActive(false);


         Debug.Log("게임 재시작");
    }

}
