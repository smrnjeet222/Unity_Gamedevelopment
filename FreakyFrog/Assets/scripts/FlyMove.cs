using UnityEngine;

public class FlyMove : MonoBehaviour
{
    [SerializeField]
    private Transform center;

    private float FlySpeed;
    void Start(){

        FlySpeed = Random.Range(300f ,700f );

    }

    void Update(){

        transform.RotateAround( center.position , Vector3.up , FlySpeed*Time.deltaTime);
    }
    
}
