using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class PistolBullet : MonoBehaviour
{
    private void Start() {
        Destroy(this.gameObject, 20);
    }

    private void OnTriggerEnter2D(Collider2D coll) {
        if(!coll.isTrigger) {
            switch(coll.tag) {
                case "Enemy":
                    break;
                case "Obstacle":
                    Destroy(gameObject);
                    break;
            }
            Destroy(gameObject);
        }
    }
}
