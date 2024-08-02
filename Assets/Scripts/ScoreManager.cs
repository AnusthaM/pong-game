using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{ 
    public int scoreToReach;

    private int Player1Score=0;
    private int Player2Score=0;

    public Text player1ScoreText;
    public Text player2ScoreText; 

    public void Player1Goal(){
        Player1Score++;
        player1ScoreText.text=Player1Score.ToString();
        CheckScore();
    }
    
    public void Player2Goal(){
        Player2Score++;
        player2ScoreText.text=Player2Score.ToString();
        CheckScore();
    }

    private void CheckScore(){
        if(Player1Score == scoreToReach || Player2Score == scoreToReach){
            SceneManager.LoadScene(2);
        }
    }

}
