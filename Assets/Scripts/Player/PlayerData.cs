using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerData : MonoBehaviour
{
    public Rigidbody2D rb;
    public float playerSpeed;
    public float diagSlowDown;
    Vector2 movement;
    private int strikes = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (strikes == 3) {
            
        }
    }

    void FixedUpdate() 
    {
        if (movement.x != 0 & movement.y != 0) {
            rb.MovePosition(rb.position + movement * playerSpeed * Time.fixedDeltaTime * diagSlowDown);
        } else {
            rb.MovePosition(rb.position + movement * playerSpeed * Time.fixedDeltaTime);
        }
    }

    public void lostScreen() {

    }
}
