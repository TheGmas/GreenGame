using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceController : MonoBehaviour {

    public Text moneyText, energyText, happinessText; // Creates a public text gameObject
    public int factoryNumb, currentEnergy, houseNumb, currentMoney, smallStoreNumb, bigStoreNumb, apartmentNumb, windNumb, solarNumb, treeNumb;
    float time, tempNumb, intTime = 0, currentHappiness;
    public Slider temp;

	// Use this for initialization
	void Start ()
    {
       
        // Set as Default
        moneyText.text = "200";
        energyText.text = "100";
        temp.value = 0.5f;
        tempNumb = 0.5f;
    }
	
	// Update is called once per frame
	void Update ()
    {
        factoryNumb = GameObject.FindGameObjectsWithTag("Factory").Length;
        houseNumb = GameObject.FindGameObjectsWithTag("House").Length;
        smallStoreNumb = GameObject.FindGameObjectsWithTag("Small Store").Length;
        bigStoreNumb = GameObject.FindGameObjectsWithTag("Big Store").Length;
        apartmentNumb = GameObject.FindGameObjectsWithTag("Apartment").Length;
        windNumb = GameObject.FindGameObjectsWithTag("Wind Turbine").Length;
        solarNumb = GameObject.FindGameObjectsWithTag("Solar Panel").Length;
        treeNumb = GameObject.FindGameObjectsWithTag("Tree").Length;
        time += Time.deltaTime;
        currentEnergy = int.Parse(energyText.text);
        currentMoney = int.Parse(moneyText.text);




        if (time > 1)
        {
            intTime += 1;
            if(intTime% 3 == 0)
            {
                currentEnergy += 35 * solarNumb;
            }
            if(intTime% 5 == 0)
            {
                currentMoney += 25 * houseNumb;
                currentEnergy += 75 * factoryNumb;
                tempNumb += factoryNumb / 100;
                currentHappiness += smallStoreNumb/2;
                tempNumb -= (windNumb / 1000) * 9;
            }
            if(intTime % 6 == 0)
            {
                currentEnergy += 150 * windNumb;
                tempNumb -= (solarNumb / 1000) * 3;
            }

            if(intTime%10 == 0)
            {
                temp.value += houseNumb / 1000;
                temp.value += (smallStoreNumb / 1000) * 3;
                currentHappiness += 1 * bigStoreNumb;
                currentHappiness += 2 * apartmentNumb;
                tempNumb -= treeNumb / 1000;
            }
            if(intTime%1 == 0)
            {
                currentHappiness += 1;
            }
            if(intTime%7 == 0)
            {
                currentMoney += 150 * smallStoreNumb;
                tempNumb += (apartmentNumb / 1000) * 8;
            }
            if(intTime%8 == 0)
            {
                tempNumb += (bigStoreNumb / 1000) * 6;
            }
            if(intTime%11 == 0)
            {
                currentMoney += 325 * bigStoreNumb;
            }
            if(intTime % 12 == 0)
            {
                currentMoney += 350 * apartmentNumb;
            }
            
            energyText.text = currentEnergy.ToString();            
            moneyText.text = currentMoney.ToString();
            happinessText.text = currentHappiness.ToString();
            temp.value += tempNumb;

            time = 0;
        }
    }
}
