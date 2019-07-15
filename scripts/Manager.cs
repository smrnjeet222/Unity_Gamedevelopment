using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{   
    public Text GameEnd;

    bool gameisended = false;
    public float RestartDelay = 3f ;

    public GameObject CompleteLevelUI;

    public void CompleteLevel(){

        gameisended = true ;
        CompleteLevelUI.SetActive(true);
        Debug.Log("LEVEL WON!");

        

    }

    
    public void Game_Over(){
        if (gameisended == false){
            gameisended = true ;
            
            Invoke("gameover" , 1f);
            Invoke("Restart" , RestartDelay);

        }
    }

    void gameover(){
        Debug.Log("GAME OVER");
        GameEnd.text = "GAME \nOVER\n:-(";
    }

    void Restart(){
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
     
}
