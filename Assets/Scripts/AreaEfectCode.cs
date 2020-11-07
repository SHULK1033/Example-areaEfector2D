using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEfectCode : MonoBehaviour {
    public AreaEffector2D example;
    private Event lol;

    private void Start () {
        lol = GameObject.Find ("Cube").GetComponent<Event> ();
        example = GetComponent<AreaEffector2D> ();
    }

    private void Update () {
        if (lol.lol1) {
            example.angularDrag = 0f;
            example.drag = 0f;
            example.forceAngle = 90f;
            example.forceMagnitude = 50f;
            example.forceVariation = 0f;
            example.useGlobalAngle = true;
        } else {
            example.angularDrag = 0f;
            example.drag = 0f;
            example.forceAngle = 0f;
            example.forceMagnitude = -10f;
            example.forceVariation = 0f;
            example.useGlobalAngle = true;
        }

    }
}