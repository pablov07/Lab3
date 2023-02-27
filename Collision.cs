using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    //Health can be changed on Unity
    public int health = 1;
    
   //Triggered when 2 Objects collide onto one another
    void OnTriggerEnter2D() {
        Debug.Log ("Trigger");

        health--;
    }

    //Update when collision happens, checks if health is 0 
    void Update() {
        if (health <= 0) {
            Die();
        }
    }

    //Destroys Object
    void Die() {
        Destroy(gameObject);
    }
}
