using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endtrigger : MonoBehaviour{
    
    public Manager gamemanager;
    
    
    void OnTriggerEnter (){
   
        gamemanager.CompleteLevel();
        
    }
    
}
