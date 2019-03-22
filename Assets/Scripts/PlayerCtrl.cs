using System.Collections;
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

        if(speed <= 0)
        {
            speed = 0;
        }
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
        
        life.GetComponent<HUDCtrl>().Life -= 4;

        if (collision.gameObject.tag == "Eau")
        {
            speed = 12f;
            score += 100;
        }

        if (collision.gameObject.tag == "Carton" || collision.gameObject.tag == "Coutchouc" || collision.gameObject.tag == "Papier" || collision.gameObject.tag == "Paille" || collision.gameObject.tag == "Fumée" || collision.gameObject.tag == "Verre" || collision.gameObject.tag == "Plastique")
        {
            speed = 13f;
            score += 50;
        }

        if (collision.gameObject.tag == "Terre")
        {
            speed = 14.5f;
            score += 20;
        }

        if (collision.gameObject.tag == "Béton")
        {
            speed = 15f;
            score += 10;
        }

        if (collision.gameObject.tag == "Bitume")
        {
            speed = 15f;
            score += 10;
        }

        if (collision.gameObject.tag == "Plante")
        {
            speed = 15.5f;
            score += 100;
        }

        if (collision.gameObject.tag == "Bois")
        {
            speed = 15.5f;
            score += 30;
        }

        if (collision.gameObject.tag == "Métal")
        {
            speed = 18f;
            score += 20;
        }

        if (collision.gameObject.tag == "Roche")
        {
            speed = 19f;
            score += 100;
        }

        if (collision.gameObject.tag == "Sable")
        {
            speed = 5f;
            score += 10;
        }

        if (collision.gameObject.tag == "Neige")
        {
            speed = 9f;
            score += 100;
        }

        if (collision.gameObject.tag == "Diamant")
        {
            speed = 20f;
            score += 1000;
        }
    }

    public void RotationMove()
    {

        this.transform.Translate(Input.GetAxis("Horizontal")*2, 0, 0);

    }

    public void cGravity()
    {
        rb.AddForce(transform.up * -Physics.gravity.y, ForceMode.Acceleration);
    }
}
