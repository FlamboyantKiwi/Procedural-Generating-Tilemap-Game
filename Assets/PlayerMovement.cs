using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    public Rigidbody2D rb;

    Vector2 movement;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    { 
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        //get imputs
        PlayerMove();       
    }
    private void PlayerMove()
    {
        rb.MovePosition(rb.position + movementSpeed * Time.fixedDeltaTime * movement);
    }
}
