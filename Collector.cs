using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Enemy"))
            Destroy(collision.gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("Player"))
            Destroy(collision.gameObject);
    }
}
