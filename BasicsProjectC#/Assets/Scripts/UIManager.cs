using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    public TextMeshProUGUI baloonsPoppedUI;

    // Start is called before the first frame update
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

        GameManager.BalloonPopped += UpdateUI;

        UpdateUI();
    }

    public void UpdateUI()
    {
        baloonsPoppedUI.text = GameManager.Instance.poppedBalloons + "/" + GameManager.Instance.balloonsInScene;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
