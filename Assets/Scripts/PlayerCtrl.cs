﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public float speed = 0.2f;
    public float vSpeedD = 0.2f;
    public float vSpeedUp = 0.2f;
    public float deceleration = 0.001f;
    Vector3 m_angleVelocity;
    private Rigidbody rb;
    int score = 0;
    public GameObject life;

    // Use this for initialization
    void Start ()
    {
        m_angleVelocity = new Vector3(0, 100, 0);
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update ()
    {
        cGravity();
        BasicMove();
        VerticalMove();
        RotationMove();
        speed -= deceleration;
    }

    public void BasicMove()
    {
        rb.AddForce(transform.forward * speed, ForceMode.Force);
    }

    public void VerticalMove()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            rb.AddForce(-transform.up * vSpeedUp, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(transform.up * vSpeedUp, ForceMode.Force);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        score += 100;
        life.GetComponent<HUDCtrl>().Life -= 4;

        if (collision.gameObject.tag == "Eau")
        {
            speed = 10f;
        }

        if (collision.gameObject.tag == "Béton")
        {
            speed = 15f;
        }

        if (collision.gameObject.tag == "Bitume")
        {
            speed = 20f;
        }

        if (collision.gameObject.tag == "Plante")
        {
            speed = 25f;
        }

        if (collision.gameObject.tag == "Métal")
        {
            speed = 30f;
        }
    }

    public void RotationMove()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            Quaternion deltaRotation = Quaternion.Euler(-m_angleVelocity * Time.deltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Quaternion deltaRotation = Quaternion.Euler(m_angleVelocity * Time.deltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);
        }
    }

    public void cGravity()
    {
        rb.AddForce(transform.up * -Physics.gravity.y, ForceMode.Acceleration);
    }
}
