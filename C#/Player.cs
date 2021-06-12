using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float xAx, zAx, yAx;
    //mass/speed/jumpForce - /1/500/400
    //mass/speed/jumpForce - /2/500/850
    private Vector3 Movement ;
    [SerializeField] float playerSpeed = 7;
    [SerializeField] float jumpForce = 450f;

    Rigidbody rb;

    private bool jumpIsPresd = false;
    public bool GameOn = false;
    //bool jump = false;

    public static Player instance;

    // Start is called before the first frame update
    void Start()
    {
        GameOn = true;
    }
    private void Awake()
    {
        if (instance == null) { instance = this; }
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameOn == false) { return; }

        if (Input.GetKeyDown(KeyCode.Space)) { jumpIsPresd = true; }

        PlayerMovementXZ();


        // add double jump but not triple jump
    }
    private void FixedUpdate()
    {
        if (!GameOn) { return; }

        if (jumpIsPresd) { rb.AddForce(0,jumpForce,0);  jumpIsPresd = !jumpIsPresd; }

        RbMovement();

        Debug.Log("JumpIsPresd" + jumpIsPresd);
    }



    
    private void PlayerMovementXZ()
    {
        xAx = Input.GetAxis("Horizontal");

        Movement = new Vector3(xAx * playerSpeed, rb.velocity.y, 0);        
    }

    private void RbMovement()
    {

        rb.velocity = Movement;


    }
}
