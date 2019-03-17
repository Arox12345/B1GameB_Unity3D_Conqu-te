using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour
{
    public int timer = 60;
    int timer1s = 0;
    Text myText;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GestionTexte();
        timer1s += 1;
        if (timer1s >= 60)
        {
            timer -= 1;
            timer1s = 0;
        }
    }

    public void GestionTexte()
    {
        myText = GameObject.Find("TextTimer").GetComponent<Text>();
        string example = timer.ToString();
        myText.text = example;
        myText.color = Color.black;
    }
}

