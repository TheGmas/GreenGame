using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceController : MonoBehaviour {

    public Text moneytext, energyText; // Creates a public text gameObject
    public int coalNumb, coalEnergy, houseNumb, houseMoney;
    float time;

	// Use this for initialization
	void Start ()
    {
        // Set as Default
        moneytext.text = "100";
        energyText.text = "5";
    }
	
	// Update is called once per frame
	void Update ()
    {
        coalNumb = GameObject.FindGameObjectsWithTag("CoalFact").Length;
        time += Time.deltaTime;
        coalEnergy = int.Parse(energyText.text);
        houseMoney = int.Parse(moneytext.text);
        

        houseNumb = GameObject.FindGameObjectsWithTag("House").Length;
        
        if(time > 1)
        {
            coalEnergy += coalNumb * 1;
            energyText.text = coalEnergy.ToString();

            houseMoney += houseNumb * 2;
            moneytext.text = houseMoney.ToString();

            time = 0;
            
        }
    }
}
