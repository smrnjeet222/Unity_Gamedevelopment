using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public int Score ;

    private Text Counter ; 

    public void UpdateScore(){

        Score++ ;
        Counter.text = Score.ToString() + " Flies";

    }

    void Start(){

        Score = 0;
        Counter = GetComponent<Text>();
        
    }
}
