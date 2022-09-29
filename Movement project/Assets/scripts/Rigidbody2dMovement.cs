using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rigidbody2dMovement : MonoBehaviour
{
    public float moveSpeed = 5;
    public float jumpHeight = 10;

    private Rigidbody2D _myRb;
    private Collider2D _myCollider;

 public bool isOnGround;
    // Start is called before the first frame update
    void Start()
    {
        _myRb = GetComponent<Rigidbody2D>();
        _myCollider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        
        _myRb.velocity = new Vector2(horizontalInput * moveSpeed, _myRb.velocity.y);

        if(Input.GetButtonDown("Jump"))
        {
            _myRb.velocity = new Vector2(_myRb.velocity.x, jumpHeight);
        }
    }
}