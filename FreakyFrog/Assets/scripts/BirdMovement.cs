using UnityEngine;
using UnityEngine.AI;

public class BirdMovement : MonoBehaviour
{
    [SerializeField]
    private Transform FrogTransform;

    private NavMeshAgent birdAgent;

    private Animator BirdAnimator;

    [SerializeField]
    private RandomSound birdFootSteps;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")){

            BirdAnimator.SetBool("ATTACKING" , true);
            birdFootSteps.enabled = false;
        }
    }

    void Start(){

        birdAgent = GetComponent<NavMeshAgent>();
        BirdAnimator = GetComponent<Animator>();

        BirdAnimator.SetBool("WALKING" , true);
        birdFootSteps.enabled = true;
    }

    // Update is called once per frame
    void Update(){

        birdAgent.SetDestination(FrogTransform.position);
        // if(birdAgent.velocity.magnitude>0){
        //     birdFootSteps.enabled = true;
        // }
        // else{
        //     birdFootSteps.enabled = false;
        // }

    }
}


