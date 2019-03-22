using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrlALT : MonoBehaviour
{
    public float speed = 0.2f;
    public float deceleration = 0.001f;
    int score = 0;
    public GameObject life;
    private bool canJump = true;

    // Use this for initialization
    void Start ()
    {
        life = GameObject.Find("Health");
    }
	
	// Update is called once per frame
	void Update ()
    {
        VerticalMove();
        speed -= deceleration;

        if (speed <= 0)
        {
            speed = 0;
        }
    }

    public void VerticalMove()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space) && canJump == true)
        {
            Vector3 temp = transform.position;
            temp.y += speed/2;
            transform.position = temp;
            canJump = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        canJump = true;
        life.GetComponent<HUDCtrl>().Life -= 2;

        if (collision.gameObject.tag == "Eau")
        {
            speed = 22f;
            score += 100;
        }

        if (collision.gameObject.tag == "Carton" || collision.gameObject.tag == "Coutchouc" || collision.gameObject.tag == "Papier" || collision.gameObject.tag == "Paille" || collision.gameObject.tag == "Fumée" || collision.gameObject.tag == "Verre" || collision.gameObject.tag == "Plastique")
        {
            speed = 23f;
            score += 50;
        }

        if (collision.gameObject.tag == "Terre")
        {
            speed = 24f;
            score += 20;
        }

        if (collision.gameObject.tag == "Béton")
        {
            speed = 25f;
            score += 10;
        }

        if (collision.gameObject.tag == "Bitume")
        {
            speed = 25f;
            score += 10;
        }

        if (collision.gameObject.tag == "Plante")
        {
            speed = 26f;
            score += 100;
        }

        if (collision.gameObject.tag == "Bois")
        {
            speed = 26f;
            score += 30;
        }

        if (collision.gameObject.tag == "Métal")
        {
            speed = 31f;
            score += 20;
        }

        if (collision.gameObject.tag == "Roche")
        {
            speed = 33f;
            score += 100;
        }

        if (collision.gameObject.tag == "Sable")
        {
            speed = 10f;
            score += 10;
        }

        if (collision.gameObject.tag == "Neige")
        {
            speed = 15f;
            score += 100;
        }

        if (collision.gameObject.tag == "Diamant")
        {
            speed = 35f;
            score += 1000;
        }
    }
}
