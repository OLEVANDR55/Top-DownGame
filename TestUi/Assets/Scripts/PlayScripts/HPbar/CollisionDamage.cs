using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDamage : MonoBehaviour
{
    public int collisionDamage = 10;
    public string collisionTag;
    

    void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == collisionTag) {
            Health health = other.gameObject.GetComponent<Health>();
            health.TakeHit(collisionDamage);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == collisionTag) {
            Health health = other.gameObject.GetComponent<Health>();
            health.TakeHit(collisionDamage);
        }
    }
}
