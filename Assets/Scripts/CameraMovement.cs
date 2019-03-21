using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    private Vector3 popo = new Vector3(0,0,0);
    private Quaternion rotrot = new Quaternion(0, 0, 0, 0);

    GameObject playerPrefabs;
	// Use this for initialization
	void Start ()
    {
        playerPrefabs = GameObject.Find("Player(Clone)");
	}
	
	// Update is called once per frame
	void Update ()
    {

        playerPrefabs = GameObject.Find("Player(Clone)");

      
        Vector3 popo = playerPrefabs.transform.position;
       
         rotrot.x += 10;
         popo.z -= 5;

        transform.position = popo;

    }
}
