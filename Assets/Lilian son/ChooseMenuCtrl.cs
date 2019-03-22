using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseMenuCtrl : MonoBehaviour {

    public Image ImageSelected01;
    public Image ImageSelected02;
    public Image ImageSelected03;
    public Image ImageSelected04;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    public void ImageSelectedFunction01()
    {
        //ImageSelected01.enabled = false;
        ImageSelected01.CrossFadeAlpha(0, 0.5f, false);
    }

    public void ImageNotSelectedFunction01()
    {
        //ImageSelected01.enabled = true;
        ImageSelected01.CrossFadeAlpha(1, 0.5f, false);
    }

    public void ButtonClick01()
    {
        Debug.Log("Lancement 01");
    }

    public void ButtonClick02()
    {
        Debug.Log("Lancement 02");
    }

    public void ButtonClick03()
    {
        Debug.Log("Lancement 03");
    }

    public void ButtonClick04()
    {
        Debug.Log("Lancement 04");
    }
}
