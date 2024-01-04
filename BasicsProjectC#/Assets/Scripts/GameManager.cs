using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int balloonsInScene;
    public int poppedBalloons = 0;

    void Start()
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
    }

    public void BaloonPopped()
    {
        poppedBalloons++;
        if (poppedBalloons >= balloonsInScene)
        {
            WinGame();
        }
    }

    private void WinGame()
    {

    }
}
