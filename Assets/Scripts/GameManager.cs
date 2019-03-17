using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject PD;
    public GameObject PA;

    Vector3 PA1 = new Vector3(87, 9, -80);
    Vector3 PA2 = new Vector3(275, 9, -80);
    Vector3 PA3 = new Vector3(18, -1, 78);
    Vector3 PA4 = new Vector3(112, -1, 46);

    Vector3 PD1 = new Vector3(122, 9, 4);
    Vector3 PD2 = new Vector3(-58, -1, 26);
    Vector3 PD3 = new Vector3(72, -1, 26);
    Vector3 PD4 = new Vector3(166, -1, -25);

    // Use this for initialization
    void Start()
    {
        Instantiate(PD);
        RandomPD();

        Instantiate(PA);
        RandomPA();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void RandomPD()
    {
        int PDvar = Random.Range(1, 5);
        switch (PDvar)
        {
            case 1:
                PD.transform.position = PD1;
                break;
            case 2:
                PD.transform.position = PD2;
                break;
            case 3:
                PD.transform.position = PD3;
                break;
            case 4:
                PD.transform.position = PD4;
                break;
        }
    }

    void RandomPA()
    {
        int PAvar = Random.Range(1, 5);
        switch (PAvar)
        {
            case 1:
                PA.transform.position = PA1;
                break;
            case 2:
                PA.transform.position = PA2;
                break;
            case 3:
                PA.transform.position = PA3;
                break;
            case 4:
                PA.transform.position = PA4;
                break;
        }
    }
}
