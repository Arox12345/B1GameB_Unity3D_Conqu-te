using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDCtrl : MonoBehaviour {

    public Image HUDHealth;
    public Text HUDHealthText;
    public float Life = 100f;
    float LifeToHUD;

    public float TimeLeft;
    public Image TimeLeftImgLeft;
    public Image TimeLeftImgRight;

    public GameObject pl;

    float timermax;

    public int timer = 30;
    int timer1s = 0;


    // Use this for initialization
    void Start () {
        LifeToHUD = Life / 100f;
        timermax = timer;
    }
	
	// Update is called once per frame
	void Update () {

        LifeToHUD = Life / 100f;
        HUDHealth.fillAmount = LifeToHUD;
        HUDHealthText.text = Life + " %";

        TimeLeftImgLeft.fillAmount = (timer / timermax) * 1;
        TimeLeftImgRight.fillAmount = (timer / timermax) * 1;

        timer1s += 1;
        if (timer1s >= 60)
        {
            timer -= 1;
            timer1s = 0;
        }

        if(Life <= 0)
        {
            Life = 0;

            pl.SetActive(false);
        }


        // YANN, BG QUE TU ES, REMPLACE CETTE VARIABLE PAR LA VARIABLE DE LA VIE DU JOUEUR -- LIFE --
        // ON AS AUSSI LE TEMPS RESTANT -- TIMELEFT --

        if (LifeToHUD >= 50 / 100f)
        {
            HUDHealth.GetComponent<Image>().color = new Color32(0, 153, 0, 100);
        }

        if (LifeToHUD < 50 / 100f && LifeToHUD >= 30 / 100f)
        {
            HUDHealth.GetComponent<Image>().color = new Color32(255, 128, 0, 100);
        }

        if (LifeToHUD < 30 / 100f)
        {
            HUDHealth.GetComponent<Image>().color = new Color32(204, 51, 0, 100);
        }


        switch (timer)
        {
            case 1:
                TimeLeftImgLeft.enabled = true;
                TimeLeftImgRight.enabled = true;
                break;
            case 2:
                TimeLeftImgLeft.enabled = false;
                TimeLeftImgRight.enabled = false;
                break;
            case 3:
                TimeLeftImgLeft.enabled = true;
                TimeLeftImgRight.enabled = true;
                break;
            case 4:
                TimeLeftImgLeft.enabled = false;
                TimeLeftImgRight.enabled = false;
                break;
            case 5:
                TimeLeftImgLeft.enabled = true;
                TimeLeftImgRight.enabled = true;
                break;
            case 6:
                TimeLeftImgLeft.enabled = false;
                TimeLeftImgRight.enabled = false;
                break;
            case 7:
                TimeLeftImgLeft.enabled = true;
                TimeLeftImgRight.enabled = true;
                break;
            case 8:
                TimeLeftImgLeft.enabled = false;
                TimeLeftImgRight.enabled = false;
                break;
        }
    }
}
