using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {


    GameObject playerPrefabs;
	// Use this for initialization
	void Start ()
    {
        playerPrefabs = GameObject.Find("Player(Clone)");
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = playerPrefabs.transform.position;
	}
}
