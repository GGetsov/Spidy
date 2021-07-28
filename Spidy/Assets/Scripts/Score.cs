using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] Text score;
    [SerializeField] GameObject WebController;
    int scorePoints;
    
    void ScoreCounter()
    {
            scorePoints++;
            score.text = scorePoints.ToString();
    } 
    
    void Start()
    {
        int scorePoints = 0;
        score.text = scorePoints.ToString();
        YAxisMover webController1 = WebController.GetComponent<YAxisMover>();
        webController1.OnCorrectMove += ScoreCounter;
    }
    
}
