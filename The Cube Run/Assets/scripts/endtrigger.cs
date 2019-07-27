using UnityEngine;

public class endtrigger : MonoBehaviour{
    
    public Manager gamemanager;
    
    
    void OnTriggerEnter (){
   
        gamemanager.CompleteLevel();
        
    }
    
}
