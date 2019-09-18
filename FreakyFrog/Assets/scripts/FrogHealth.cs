using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FrogHealth : MonoBehaviour
{
    public bool Alive;

    [SerializeField]
    private GameObject pickupPrefab;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy") && Alive == true){
            
            Alive = false;

            Instantiate(pickupPrefab , transform.position , Quaternion.identity);
        }
    }

    void Start()
    {
        Alive = true;
    }
}