using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartUi : MonoBehaviour
{
    public GameManager gameManager;

    [SerializeField] private Button StartButton;

    void Start()
    {
        StartButton.onClick.AddListener(OnClickStartGame);
    }



    public void OnClickStartGame()
    {

        gameManager.StartUiObject.SetActive(false);
        gameManager.GameUiObject.SetActive(true);
        // for (int i = 0; i < gameManager.ObjectBlock.Length; i++)
        // {
        //     gameManager.ObjectBlock[i].SetActive(true);
        // }
    }
}
