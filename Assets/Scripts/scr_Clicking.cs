using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//TMP is used to substitute normal text (provides more customisation)
//This code is a very simple way of allowing the user to click the flower and increase flower amount.
public class scr_Clicking : MonoBehaviour
{
    public TMP_Text counter;
    public float counterNumber;
    public float amountPerClick = 1.0f;

    // Update is called once per frame
    void Update()
    {
        counter.text = counterNumber + " ";
    }

    public void Clicked ()
    {
        counterNumber += amountPerClick;
    }
}