using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_Auto_Flower : MonoBehaviour
{
    public bool addingFlowers = false;
    public int increaseAmount = 1;
    public scr_Clicking click;

    // Update is called once per frame
    //Allows flowers to be automatically added and the timer to increase
    //everytime the upgrade is purchased
    void Update()
    {
        if (addingFlowers == false)
        {
            addingFlowers = true;
            StartCoroutine(MakeFlowers());
        }
    }

    IEnumerator MakeFlowers()
    {
        click.counterNumber += increaseAmount;
        yield return new WaitForSeconds(1);
        addingFlowers = false;
    }
}