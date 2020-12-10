using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("Ball")]
  public GameObject ball;
    [Header("P1")]
  public GameObject p1;
  public GameObject p1goal;
    [Header("P2")]
  public GameObject p2;
  public GameObject p2goal;
    [Header("SCORE")]
  public GameObject p1Score;
  public GameObject p2Score;

  public GameObject Winner;

  public int player1Score;
  public int player2Score;
    // Start is called before the first frame update
    void Start(){
      Time.timeScale = 1;
    }
    void Update(){
      endgame();
    }
    public void Player1Scored(){
      player1Score++;
      p1Score.GetComponent<TextMeshProUGUI>().text = player1Score.ToString();
      ResetPosition();

      if(player1Score == 10){
        Debug.Log("Player 1 wins!");
        Winner.GetComponent<TextMeshProUGUI>().text = "Player 1 Wins!";
      }
    }
      public void Player2Scored(){
      player2Score++;
      p2Score.GetComponent<TextMeshProUGUI>().text = player2Score.ToString();
      ResetPosition();

       if(player2Score == 10){
        Debug.Log("Player 2 Wins!");
        Winner.GetComponent<TextMeshProUGUI>().text = "Player 2 Wins!";
      }
    }

    public void ResetPosition(){
      ball.GetComponent<Ball>().Reset();
      p1.GetComponent<Paddle>().Reset();
      p2.GetComponent<Paddle>().Reset();
    }

    public void endgame(){
    if(player1Score == 10 || player2Score == 10){
      Time.timeScale = 0;
    }
    }
}
