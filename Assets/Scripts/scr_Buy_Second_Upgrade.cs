using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scr_Buy_Second_Upgrade : MonoBehaviour
{
//These are variables allowing me to change units from the unity editor
    public scr_Clicking click;
    public scr_Auto_Flower auto;
    public TMP_Text upgradeInfo;
    public float currentPrice, multiplier;
    private float powerOf,basePrice;
    public string upgradeName;
    public int nextFlowersPerSec;


    // Start is called before the first frame update
    void Start()
    {
        nextFlowersPerSec = 1;
        basePrice = currentPrice;
        upgradeInfo.text = " ";
    }

//Allows the user to purchase the upgrade if the have enough Flowers
//Incrementaly increases the price of the upgrade
    public void PurchaseUpgrade()
    {
        if (click.counterNumber >= currentPrice)
        {
            click.counterNumber -= currentPrice;
            powerOf++;
            auto.increaseAmount = nextFlowersPerSec;

            //currentPrice = Mathf.Round(currentPrice * 1.15f);

            currentPrice = Mathf.Round(basePrice * Mathf.Pow(multiplier, powerOf));
            nextFlowersPerSec += 1;

            UpdateText();
        }
    }
//From here on the code enables the Upgrade Info to be hidden when the mouse
//is not scrolled over the UI button
//When the mouse is scrolled over the Upgrade Info is presented
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
        upgradeInfo.text = upgradeName + "\n" + "\n" + currentPrice + " Flowers" + "\n" + "\n" + "Upgrade to auto generate " + nextFlowersPerSec + " Flower per second";
    }
}