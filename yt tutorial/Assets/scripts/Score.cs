using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text ScoreText;
    public Transform player ;
     

    void FixedUpdate()
    {   
        if (player.position.y > -0.1f){
        ScoreText.text = ((player.position.z) - 15).ToString("0");
        }
    }

}
