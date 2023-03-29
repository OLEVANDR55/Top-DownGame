using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    private float timeBtwShots;
    public float stratTimeBtwShots;
    public Transform player;

    public GameObject bullet; 

    void Start() {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        timeBtwShots = stratTimeBtwShots;
    }
    private void Update() {
        if(player == null) {

        }
        else {
            if(timeBtwShots <= 0) {
                Instantiate(bullet, transform.position, Quaternion.identity);
                timeBtwShots = stratTimeBtwShots;
            }
            else {
                timeBtwShots -= Time.deltaTime;
            }    
        }
    }
}
