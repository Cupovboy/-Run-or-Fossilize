using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject myPrefab;
    private GameObject spawn;



    private void OnTriggerEnter(Collider other)
    {
    
        spawn = GameObject.FindGameObjectsWithTag("Spawn")[0];
        Vector3 newVector = spawn.transform.position;
        Instantiate(myPrefab, newVector, Quaternion.identity);
        Destroy(spawn);
        Destroy(this.gameObject);
    }
}
