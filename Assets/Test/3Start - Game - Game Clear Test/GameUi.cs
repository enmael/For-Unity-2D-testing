using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUi : MonoBehaviour
{

    public GameManager gameManager;
    [SerializeField] private Button ClearButton;
    [SerializeField] private Button OverButton;


    void Start()
    {
        ClearButton.onClick.AddListener(OnClickGameClear);
        OverButton.onClick.AddListener(OnClickGameOVer);
    }

    public void OnClickGameClear()
    {
        gameManager.GameUiObject.SetActive(false);
        gameManager.ClearUiObject.SetActive(true);
    }

    public void OnClickGameOVer()
    {
        gameManager.GameUiObject.SetActive(false);
        gameManager.GameOverUiObject.SetActive(true);

    }
}
