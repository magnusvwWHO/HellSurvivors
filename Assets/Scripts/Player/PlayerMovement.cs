using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 1;
    public float MoveSpeed {
        get { return moveSpeed; }
        set { moveSpeed = value; }
    }
    private Rigidbody2D playerRigitBody;

    public void Move(Vector2 direction) {
        playerRigitBody.velocity = direction * moveSpeed;
    }

    private void Start() {
        playerRigitBody = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        transform.Translate(JoystickController.Position * moveSpeed);
    }
}
