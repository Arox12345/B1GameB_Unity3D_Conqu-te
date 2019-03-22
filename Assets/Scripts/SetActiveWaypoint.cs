using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveWaypoint : MonoBehaviour {



    public GameObject PLayerObject;
    public GameObject MainCamera;
    public GameObject Manager;

    public GameObject Dolly;

    public int timer = 13;
    int timer1s = 0;


    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if(timer == 0)
        {

            Destroy(gameObject);

        }

        timer1s += 1;
        if (timer1s >= 60)
        {
            timer -= 1;
            timer1s = 0;
        }

        
    }



    private void OnDestroy()
    {
        PLayerObject.SetActive(true);
        MainCamera.SetActive(true);
        Manager.SetActive(true);

    }
}
