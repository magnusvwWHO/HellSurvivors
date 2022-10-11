using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePistol : MonoBehaviour
{
    [SerializeField]
    private float bulletSpeed;
    public float BulletSpeed {
        get {
            return bulletSpeed;
        }
        set {
            bulletSpeed = value;
        }
    }
    [SerializeField]
    private float fireRate;
    public float FireRate {
        get {
            return fireRate;
        }
        set {
            fireRate = value;
        }
    }
    [SerializeField]
    private Rigidbody2D playerRigitBody;
    public Rigidbody2D Bullet;
    public Transform GunPoint;
    public Transform zRotate;

    private float curTimeout;

    private void SetRotation() {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.transform.position.z;
        Vector3 lookPos = Camera.main.ScreenToWorldPoint(mousePos);
        lookPos = lookPos - transform.position;
        float angle = Mathf.Atan2(lookPos.y,lookPos.x) * Mathf.Rad2Deg;
        zRotate.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    private void Fire() {
         curTimeout += Time.deltaTime;
        if (curTimeout > fireRate) {
            curTimeout = 0;
            Rigidbody2D clone = Instantiate(Bullet, GunPoint.position, Quaternion.identity) as Rigidbody2D;
            clone.velocity = transform.TransformDirection(GunPoint.right * BulletSpeed) + (Vector3)playerRigitBody.velocity;
            clone.transform.right = GunPoint.right;
            //clone.rotation = GunPoint.rotation.z;
        }
    }

    private void Update() {
       Fire();
       if(zRotate) SetRotation();
    }
}
