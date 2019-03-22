using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class MainMenuCtrl : MonoBehaviour {

    public Image ImageSelectedMM;
    public Image ScndImageSelectedMM;

    public Image BackImageSelectedMM;
    public Image BackScndImageSelectedMM;
    public Image BackThirdImageSelectedMM;
    public Image BackFourImageSelectedMM;
    public Image BackFiveImageSelectedMM;

    public Text SureToQuitScreenTxt;
    public Image SureToQuitScreenImg1;
    public Image SureToQuitScreenImg2;
    public Button SureToQuitScreenBtn1;
    public Text SureToQuitScreenBtn1Txt;
    public Button SureToQuitScreenBtn2;
    public Text SureToQuitScreenBtn2Txt;

    public AudioSource Click1S;
    public AudioSource Click2S;
    public AudioSource OST;

    public Canvas TutoCanvas;

    public Canvas CreditCanvas;
    public RectTransform CreditRect;
    public Animator CreditAnim;
    bool CreditLaunched = false;

    // Use this for initialization
    void Start () {
        NoLeaveGame();
        OST.Play(1);
        CreditCanvas.gameObject.SetActive(false);
        TutoCanvas.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (CreditLaunched == true)
        {
            Debug.Log("1");
            if (CreditRect.anchoredPosition.y >= 936)
            {
                Debug.Log("2");
                StopCredit();
            }
        }
    }

    public void StopCredit()
    {
        CreditCanvas.gameObject.SetActive(false);
        CreditLaunched = false;
    }

    public void ImageMMSelectedFunction01()
    {
        //ImageSelected01.enabled = false;
        ImageSelectedMM.CrossFadeAlpha(0, 0.5f, false);
        BackImageSelectedMM.CrossFadeAlpha(1.8f, 0.5f, false);
        Click2S.Play(0);
    }

    public void ImageMMNotSelectedFunction01()
    {
        //ImageSelected01.enabled = true;
        ImageSelectedMM.CrossFadeAlpha(1, 0.5f, false);
        BackImageSelectedMM.CrossFadeAlpha(1f, 0.5f, false);
    }

    public void ScndImageMMSelectedFunction01()
    {
        //ImageSelected01.enabled = false;
        ScndImageSelectedMM.CrossFadeAlpha(0, 0.5f, false);
        BackScndImageSelectedMM.CrossFadeAlpha(1.8f, 0.5f, false);
        Click2S.Play(0);
    }

    public void ScndImageMMNotSelectedFunction01()
    {
        //ImageSelected01.enabled = true;
        ScndImageSelectedMM.CrossFadeAlpha(1, 0.5f, false);
        BackScndImageSelectedMM.CrossFadeAlpha(1f, 0.5f, false);
    }

    public void ThirdImageMMSelectedFunction01()
    {
        //ImageSelected01.enabled = false;
        BackThirdImageSelectedMM.CrossFadeAlpha(1.8f, 0.5f, false);
        Click2S.Play(0);
    }

    public void ThirdImageMMNotSelectedFunction01()
    {
        //ImageSelected01.enabled = true;
        BackThirdImageSelectedMM.CrossFadeAlpha(1f, 0.5f, false);
    }

    public void FourImageMMSelectedFunction01()
    {
        //ImageSelected01.enabled = false;
        BackFourImageSelectedMM.CrossFadeAlpha(1.8f, 0.5f, false);
        Click2S.Play(0);
    }

    public void FourImageMMNotSelectedFunction01()
    {
        //ImageSelected01.enabled = true;
        BackFourImageSelectedMM.CrossFadeAlpha(1f, 0.5f, false);
    }

    public void FiveImageMMSelectedFunction01()
    {
        //ImageSelected01.enabled = false;
        BackFiveImageSelectedMM.CrossFadeAlpha(1.8f, 0.5f, false);
        Click2S.Play(0);
    }

    public void FiveImageMMNotSelectedFunction01()
    {
        //ImageSelected01.enabled = true;
        BackFiveImageSelectedMM.CrossFadeAlpha(1f, 0.5f, false);
    }

    public void ButtonMMClick01()
    {
        Click1S.Play(0);
        gameObject.SetActive(false);
        //LANCEMENT DE LA SUITE ICI
    }

    public void ButtonMMClick02()
    {
        
    }

    public void ButtonMMClick03()
    {
        Click1S.Play(0);
        CreditCanvas.gameObject.SetActive(true);
        CreditAnim.Play("CreditsAnimation", -1, 0);
        CreditLaunched = true;
        Debug.Log("0");
    }

    public void ButtonMMClick04()
    {
        Click1S.Play(0);
        TutoCanvas.gameObject.SetActive(true);
    }

    public void ButtonMMClick05()
    {
        Click1S.Play(0);
        Debug.Log("Lancement 05");
    }

    public void ButtonExitTuto()
    {
        Click1S.Play(0);
        TutoCanvas.gameObject.SetActive(false);
    }

    public void ButtonExitSelectedTuto()
    {
        Click2S.Play(0);
    }

    public void LeaveGame()
    {
        Click1S.Play(0);

        SureToQuitScreenBtn1.GetComponent<Button>().enabled = true;
        SureToQuitScreenBtn1.GetComponent<Image>().enabled = true;
        SureToQuitScreenBtn1.GetComponent<Image>().CrossFadeAlpha(1, 0, false);
        SureToQuitScreenBtn2.GetComponent<Button>().enabled = true;
        SureToQuitScreenBtn2.GetComponent<Image>().enabled = true;
        SureToQuitScreenBtn1.GetComponent<Image>().CrossFadeAlpha(1, 0, false);

        SureToQuitScreenTxt.enabled = true;

        SureToQuitScreenBtn1Txt.enabled = true;
        SureToQuitScreenBtn2Txt.enabled = true;

        SureToQuitScreenImg1.enabled = true;
        SureToQuitScreenImg2.enabled = true;
    }

    public void NoLeaveGame()
    {
        Click1S.Play(0);

        SureToQuitScreenBtn1.GetComponent<Button>().enabled = false;
        SureToQuitScreenBtn1.GetComponent<Image>().enabled = false;
        SureToQuitScreenBtn1.GetComponent<Image>().CrossFadeAlpha(0, 0, false);
        SureToQuitScreenBtn2.GetComponent<Button>().enabled = false;
        SureToQuitScreenBtn2.GetComponent<Image>().enabled = false;
        SureToQuitScreenBtn2.GetComponent<Image>().CrossFadeAlpha(0, 0, false);

        SureToQuitScreenTxt.enabled = false;

        SureToQuitScreenBtn1Txt.enabled = false;
        SureToQuitScreenBtn2Txt.enabled = false;

        SureToQuitScreenImg1.enabled = false;
        SureToQuitScreenImg2.enabled = false;
    }

    public void YesLeaveGame()
    {
        Click1S.Play(0);
        Application.Quit();
    }
}
