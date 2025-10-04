using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public GameObject startUiObject;
    [SerializeField] public GameObject gameUiObject;

    [SerializeField] public GameObject gameOverUiObject;

    [SerializeField] public GameObject clearUiObject;
    // [SerializeField] public GameObject[] objectBlock = new GameObject[20];

    // public GameObject[] ObjectBlock
    // {
    //     get { return objectBlock; }
    //     set { value = objectBlock; }
    // }

    public GameObject StartUiObject
    {
        get { return startUiObject; }
        set { value = startUiObject; }
    }

    public GameObject ClearUiObject
    {
        get { return clearUiObject; }
        set { value = clearUiObject; }
    }

    public GameObject GameUiObject
    {
        get { return gameUiObject; }
        set { value = gameUiObject; }
    }


    public GameObject GameOverUiObject
    {
        get { return gameOverUiObject; }
        set { value = gameOverUiObject; }
    }

}
