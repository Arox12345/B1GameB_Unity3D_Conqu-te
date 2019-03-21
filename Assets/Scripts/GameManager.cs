using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class GameManager : MonoBehaviour
{
    public GameObject PD;
    public GameObject PA;
    public GameObject Player;
    public GameObject Dolly;


    private Vector3 doll;
    private Vector3 doll2;
    private Vector3 refWorld = new Vector3(0,0,0);



    Vector3 PA1 = new Vector3(266, 14, 387);
    Vector3 PA2 = new Vector3(8, 14, 78);
    Vector3 PA3 = new Vector3(141, 10, 80.5f);
    Vector3 PA4 = new Vector3(65, 10, -52);

    Vector3 PD1 = new Vector3(284, 21, -84);
    Vector3 PD2 = new Vector3(272, 19, 85);
    Vector3 PD3 = new Vector3(192, 14, -28);
    Vector3 PD4 = new Vector3(132, 19, 230);

    // Use this for initialization
    void Start()
    {
        Instantiate(PD);
        Instantiate(Player);
        RandomPD();

        Instantiate(PA);
        RandomPA();




        Dolly.transform.GetComponent<CinemachineSmoothPath>().m_Waypoints[0].position = doll;
        Dolly.transform.GetComponent<CinemachineSmoothPath>().m_Waypoints[2].position = doll2;

       
       // if(doll2 )
        Dolly.transform.GetComponent<CinemachineSmoothPath>().m_Waypoints[1].position.x = doll2.y - doll.y;
        Dolly.transform.GetComponent<CinemachineSmoothPath>().m_Waypoints[1].position.y = 100;
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
                Player.transform.position = PD1;
                doll2 = PD1;

                Debug.Log("positionpointPD " + PD.transform.position);
                Debug.Log("Player " + PD.transform.position);
                Debug.Log("Positionpété x:" + doll2.x + " y: " + doll2.y + " z:" + doll2.z);
                break;
            case 2:
                PD.transform.position = PD2;
                Player.transform.position = PD2;
                doll2 = PD2;

                Debug.Log("positionpointPD " + PD.transform.position);
                Debug.Log("Player " + PD.transform.position);
                Debug.Log("Positionpété x:" + doll2.x + " y: " + doll2.y + " z:" + doll2.z);
                break;
            case 3:
                PD.transform.position = PD3;
                Player.transform.position = PD3;
                doll2 = PD3;

                Debug.Log("positionpointPD " + PD.transform.position);
                Debug.Log("Player " + PD.transform.position);
                Debug.Log("Positionpété x:" + doll2.x + " y: " + doll2.y + " z:" + doll2.z);
                break;
            case 4:
                PD.transform.position = PD4;
                Player.transform.position = PD4;
                doll2 = PD4;

                Debug.Log("positionpointPD " + PD.transform.position);
                Debug.Log("Player " + PD.transform.position);
                Debug.Log("Positionpété x:" + doll2.x + " y: " + doll2.y + " z:" + doll2.z);
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
                doll = PA1;

                Debug.Log("positionpointPA " + PA.transform.position);
                Debug.Log("Positionpété x:" + doll.x + " y: " + doll.y + " z: " + doll.z);
                break;
            case 2:
                PA.transform.position = PA2;
                doll = PA2;

                Debug.Log("positionpointPA " + PA.transform.position);
                Debug.Log("Positionpété x:" + doll.x + " y: " + doll.y + " z: " + doll.z);
                break;
            case 3:
                PA.transform.position = PA3;
                doll = PA3;

                Debug.Log("positionpointPA " + PA.transform.position);
                Debug.Log("Positionpété x:" + doll.x + " y: " + doll.y + " z: " + doll.z);
                break;
            case 4:
                PA.transform.position = PA4;
                doll = PA4;

                Debug.Log("positionpointPA " + PA.transform.position);
                Debug.Log("Positionpété x:" + doll.x + " y: " + doll.y + " z: " + doll.z);
                break;
        }
    }

  
}
