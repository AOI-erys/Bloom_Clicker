using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scr_Buy_First_Upgrade : MonoBehaviour
{
//These are variables allowing me to change units from the unity editor

    public scr_Clicking click;
    public TMP_Text upgradeInfo;
    public float currentPrice, clickPower;
    private float powerOf;
    public string upgradeName;
    private float basePrice;


//Allows the user to purchase the upgrade if the have enough Flowers
//Incrementaly increases the price of the upgrade
    public void PurchaseUpgrade()
    {
        if (click.counterNumber >= currentPrice)
        {
            click.counterNumber -= currentPrice;
            powerOf++;
            click.amountPerClick += clickPower;

            //currentPrice = Mathf.Round(currentPrice * 2.75f);

            currentPrice = Mathf.Round(basePrice * Mathf.Pow(1.05f, powerOf));
            clickPower += 1;

            UpdateText();
        }
    }

//From here on the code enables the Upgrade Info to be hidden when the mouse
//is not scrolled over the UI button
//When the mouse is scrolled over the Upgrade Info is presented
    private void Start()
    {
        upgradeInfo.text = " ";
        basePrice =  currentPrice;

    }

    public void onMouseEnter()
    {
        UpdateText();
    }

    public void onMouseExit()
    {
        upgradeInfo.text = " ";
    }

    void UpdateText()
    {
        upgradeInfo.text = upgradeName + "\n" + "\n" + currentPrice + " Flowers" + "\n" + "\n" + "Upgrade to add " + clickPower + " Flowers per click";
    }
}