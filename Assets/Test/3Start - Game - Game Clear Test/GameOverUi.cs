using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverUi : MonoBehaviour
{
    public GameManager gameManager;

    [SerializeField] private Button RestartButton;

    void Start()
    {
        RestartButton.onClick.AddListener(OnClickGameRestart);
        
    }

    public void OnClickGameRestart()
    {
        gameManager.GameOverUiObject.SetActive(false);
        gameManager.GameUiObject.SetActive(true);
        // gameManager.GameUiObject.SetActive(false);
        // gameManager.startUiObject.SetActive(true);
    }
}
