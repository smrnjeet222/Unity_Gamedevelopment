using UnityEngine;

public class followCamera : MonoBehaviour{

    [SerializeField]
    private Transform target;

    [SerializeField]
    private Vector3 offset = new Vector3(0f , 11f , -7f); 
    
    [SerializeField]
    private float speed = 5f;

    void LateUpdate(){
        
        Vector3 newPosition = target.position + offset;
        transform.position = Vector3.Lerp(transform.position , newPosition , speed*Time.deltaTime);
    }
}
