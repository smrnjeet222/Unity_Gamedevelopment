
using UnityEngine;

public class FollowPlayer : MonoBehaviour{

public Transform player; 
public float smoothspeed = 25f;
public Vector3 offset ;

    void FixedUpdate(){
        
        Vector3  desiredPosition = player.position + offset ;
        Vector3  smoothPosition = Vector3.Lerp(transform.position ,  desiredPosition , smoothspeed*Time.deltaTime );
        transform.position = smoothPosition;


    }


}
