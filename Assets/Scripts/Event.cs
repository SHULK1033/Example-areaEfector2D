using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event : MonoBehaviour {
    public bool lol1 = false;
    private void OnTriggerEnter2D (Collider2D other) {
        if (other.gameObject.tag == "Player") {
            lol1 = true;
        }

    }
    private void OnTriggerExit2D (Collider2D other) {
        if (other.gameObject.tag == "Player") {
            lol1 = false;
        }
    }
}