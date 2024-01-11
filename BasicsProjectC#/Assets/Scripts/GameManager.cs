using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public static Action BalloonPopped;

    public int balloonsInScene;
    public int poppedBalloons = 0;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
        balloonsInScene = GameObject.FindGameObjectsWithTag("Balloon").Length;

        BalloonPopped += OnBaloonPopped;
    }

    private void OnDestroy()
    {
        BalloonPopped -= OnBaloonPopped;
    }

    public void OnBaloonPopped()
    {
        poppedBalloons++;
        if (poppedBalloons >= balloonsInScene)
        {
            WinGame();
        }
    }

    private void WinGame()
    {
        Debug.Log("You win");

        StartCoroutine(UIManager.Instance.ShowWinPanel());
    }
}
