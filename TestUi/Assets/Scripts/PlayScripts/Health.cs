using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Health : MonoBehaviour
{ 
    public int health;
    public int maxHealth;
    public TMP_Text hpBar;

    private void Awake() {
        hpBar.text = "" + health;
    }

    public void TakeHit(int damage) {
        health -= damage;
        hpBar.text = "" +  health;

        if(health <= 0) {
            Destroy(gameObject);
        }
    }

    public void SetHealth(int bonusHealth) {
        health += bonusHealth;

        if (health > maxHealth) {
            health = maxHealth;
        }
        hpBar.text = "" +  health;
    }
}
