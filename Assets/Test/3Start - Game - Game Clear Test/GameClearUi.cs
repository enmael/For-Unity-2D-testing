using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameClearUi : MonoBehaviour
{
    public GameManager gameManager;
    [SerializeField] private Button firstButton;

    void Start()
    {
        firstButton.onClick.AddListener(OnClickGameClear1);
    }

    public void OnClickGameClear1()
    {
        gameManager.ClearUiObject.SetActive(false);
        gameManager.StartUiObject.SetActive(true);
    }
}
