using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameOver : MonoBehaviour
{
    
    public int score = GameManager.score;

    public TMP_Text scoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       score = GameManager.score;
       scoreText.text = "Final Score: " + score.ToString(); 
    }
}
