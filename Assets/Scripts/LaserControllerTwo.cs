using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserControllerTwo : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy2")){
            GameObject explosion = Instantiate(Resources.Load("Flare", typeof(GameObject))) as GameObject;
            explosion.transform.position = transform.position;
            Destroy(other.gameObject);
            Destroy(explosion, 0.5f);
            Destroy(gameObject);
        }
    }
}
