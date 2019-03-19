/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blinking_Light : MonoBehaviour {

    public float BlinkingInterval;
    float BlinkingIntervalActual;
    bool CheckTorF;

    // Use this for initialization
    void Start () {
        BlinkingIntervalActual = BlinkingInterval;
    }
	
	// Update is called once per frame
	void Update () {
        BlinkingIntervalActual = BlinkingIntervalActual - 1;

        if (BlinkingIntervalActual > 0)
        {
            Debug.Log("Ohla");
        }

        if (BlinkingIntervalActual <= 0 )
        {
            Debug.Log("Ohla");
            CheckTorF = gameObject.activeSelf;
            gameObject.SetActive(!CheckTorF);
            BlinkingIntervalActual = BlinkingInterval;
        }
    }
}*/
