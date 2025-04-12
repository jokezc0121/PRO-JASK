using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private int score2 = 0;
    private int score1 = 0;
    private int score = 0;
   
    public int Score { get => score; set => score = value; }
    public int Score1 { get => score1; set => score1 = value; }

    public int Score2 { get => score2; set => score2 = value; }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); //Persistencia de la instancia del GameManager
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SumValues(int count)
    {
        score += count;
      
    }

    public void SumValuestar(int count)
    {
     
        score1 += count;
    }
    public void ResetValue()
    {
        score = 0;
        
    }
    public void ResetValuestar()
    {
       
        score1 = 0;
    }

    public void SumValues2(int count)
    {

        score2 += count;
    }

    public void ResetValue2()
    {
        score2 = 0;

    }



}
