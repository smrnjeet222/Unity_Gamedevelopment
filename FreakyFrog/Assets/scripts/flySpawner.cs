using UnityEngine;

public class flySpawner : MonoBehaviour{

    [SerializeField]
    private GameObject flyPrefab;
    [SerializeField]
    private int minfly = 12 ;

    private float SpawnArea = 24f;

    public static int totalFlies;


    void Start(){

        totalFlies = 0;

    }

    void Update(){

        while(totalFlies < minfly){
            
            totalFlies++;

            float positionx = Random.Range(-SpawnArea , SpawnArea);
            float positionz = Random.Range(-SpawnArea , SpawnArea);

            Vector3 flyposition = new Vector3(positionx, 1.5f , positionz);

            Instantiate(flyPrefab , flyposition , Quaternion.identity);

        }
        
    }
}
