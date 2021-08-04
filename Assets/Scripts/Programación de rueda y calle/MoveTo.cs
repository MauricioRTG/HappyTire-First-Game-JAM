using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTo : MonoBehaviour
{
    public float constantSpeed;
    public float playerSpeed;
    public Rigidbody rb;
    public Joystick joystick;
    private MeshRenderer myRenderer;

    void Start()
    {
        myRenderer = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        float horizontal = joystick.Horizontal;

        myRenderer.material.SetFloat("Vector1_6051B38", horizontal);

        Vector3 motion = new Vector3(constantSpeed, 0, horizontal * playerSpeed);

        rb.MovePosition(transform.position + motion * Time.fixedDeltaTime);    
    }
}
