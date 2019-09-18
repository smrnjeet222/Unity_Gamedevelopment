using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frogovement : MonoBehaviour{

    private float horizontalmovement;
    private float verticalmovement;
    
    private Vector3 desireddirection;

    private Animator FrogAnimator;

    private Rigidbody frogRigidbody;

    [SerializeField]
    private float frogRotationSpeed = 12f ;

    [SerializeField]
    private RandomSound playerFootSteps;

   
    void Start(){
        
        FrogAnimator = GetComponent<Animator>();
        frogRigidbody = GetComponent<Rigidbody>();
        FrogAnimator.SetBool("IsIdle" , true );
    }
    
    void Update(){
        horizontalmovement = Input.GetAxisRaw("Horizontal");
        verticalmovement = Input.GetAxisRaw("Vertical");

        desireddirection = new Vector3(horizontalmovement , 0 , verticalmovement);

    }

    void FixedUpdate(){

         if (desireddirection == Vector3.zero){
            FrogAnimator.SetBool("IsIdle" , true );
            playerFootSteps.enabled = false;
        }
        else {

            Quaternion targetRotation = Quaternion.LookRotation(desireddirection , Vector3.up);
            Quaternion newRotation = Quaternion.Lerp(frogRigidbody.rotation , targetRotation , frogRotationSpeed*Time.fixedDeltaTime );

            frogRigidbody.MoveRotation(newRotation);

            FrogAnimator.SetBool("IsIdle" , false );
            playerFootSteps.enabled = true;

        }
        
    }
}
