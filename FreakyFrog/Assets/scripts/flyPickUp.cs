using UnityEngine;

public class flyPickUp : MonoBehaviour{

    [SerializeField]
    private GameObject particlePrefab;

    private ScoreCounter counter;

    private void Start(){

        counter = FindObjectOfType<ScoreCounter>();
        
    }

    void OnTriggerEnter(Collider other){

        if (other.CompareTag("Player")){

            Instantiate(particlePrefab, transform.position ,Quaternion.identity);
            flySpawner.totalFlies--;
           
            counter.UpdateScore(); 
            Destroy(gameObject);
        }
        
    }
  
}
