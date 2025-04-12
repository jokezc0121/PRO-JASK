using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameControllerScene1 : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI txtScore;

    void Start()
    {
       
    }

    void Update()
    {
        ShowScore();
    }

    public void ShowScore()
    {
        txtScore.text = "Score: " + GameManager.Instance.Score;
    }


   
}
