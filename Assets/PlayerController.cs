using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    bool hasJump;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        hasJump = true;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
  {
    //Movimiento y rotación del jugador teclas W-S-D-A
        if (Input.GetKey(KeyCode.W))
        {
        transform.Translate(0, 0, 0.3f);
        }

        if (Input.GetKey(KeyCode.S))
        {
        transform.Translate(0, 0, -0.3f);
        }

        if (Input.GetKey(KeyCode.D))
        {
        transform.Rotate(0, 1f, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
        transform.Rotate(0, -1f, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space) && hasJump)
        {
            rb.AddForce(Vector3.up * 5 , ForceMode.Impulse);
            hasJump = false;
        }

        //Movimiento y rotación del jugador teclas Flechitas

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, 0.3f);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -0.3f);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 1f, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -1f, 0);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "ground")
        {
            hasJump = true;
        }
    }
}