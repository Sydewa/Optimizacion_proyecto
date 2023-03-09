using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.position = Vector3.forward * speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("enemy"))
        {
            Destroy(other.gameObject);

        }
        Destroy(this.gameObject);
    }
}