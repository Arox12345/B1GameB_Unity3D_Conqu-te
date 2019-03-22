using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapMenuCtrl : MonoBehaviour {

    public Canvas EscapeMenu;
    public Canvas MainMenu;
    public AudioSource Click1S;
    public AudioSource Click2S;

    // Use this for initialization
    void Start () {

        
        EscapeMenu.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ContinueBtn()
    {
        Click1S.Play(0);
        EscapeMenu.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void ContinueBtnSelected()
    {
        Click2S.Play(0);
    }

    public void QuitBtnSelected()
    {
        Click2S.Play(0);
    }

    public void QuitBtn()
    {
        Click1S.Play(0);
        EscapeMenu.gameObject.SetActive(false);
        MainMenu.gameObject.SetActive(true);
        Time.timeScale = 1;
    }
}
