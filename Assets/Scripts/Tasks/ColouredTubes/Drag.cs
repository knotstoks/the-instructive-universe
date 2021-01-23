using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour {

    public GameObject slot1;
    public GameObject slot2;
    public GameObject slot3;
    public GameObject slot4;
    public GameObject slot5;

    private bool moving;


    void Start() {

    }

    void Update() {
            if (moving) {
                Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
                transform.Translate(mousePosition);
            }
    }

    private void OnMouseDown() {
        moving = true;
    }

    private void OnMouseUp() {
        moving = false;
    }


}
