using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
    public float speed;
    public Transform player;
    private Vector2 target;

    private void Start() {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y);
    }

    private void Update() {
        transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
    
        if(transform.position.x == target.x && transform.position.y == target.y) {
            DestroyBullet();
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")) {
            DestroyBullet();
        }
    }

    void DestroyBullet() {
        Destroy(gameObject);
    }
}