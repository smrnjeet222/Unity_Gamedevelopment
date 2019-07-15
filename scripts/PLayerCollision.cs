using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class PLayerCollision : MonoBehaviour{

   public PLayer_movement movement ; 
   
   void OnCollisionEnter(Collision collisionInfo){
       
       if (collisionInfo.collider.tag == "Obstacle"){
            movement.enabled = false;
            FindObjectOfType<Manager>().Game_Over();

       }

   }
  
}
