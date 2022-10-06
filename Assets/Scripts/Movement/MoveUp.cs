using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{
    private bool pressed = false;
    [SerializeField]
    

    public void onDown() {
        pressed = true;
    }

    public void onUp() {
        pressed = false;
    }

    private void Update() {
        if (pressed) {

        }
    }
}
