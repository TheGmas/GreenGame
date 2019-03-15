using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResourceController : MonoBehaviour
{
    public AudioClip screamingClip;
    AudioSource screamingSource;

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
        temp.value = 500.0f; // Starter temperature value
        tempNumb = 0.5f;

        screamingSource = GetComponent<AudioSource>();
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
            if(intTime % 3 == 0)
            {
                currentEnergy += 10 * solarNumb; // Solar panel produce 10 energy every 3 seconds.
            }
            if(intTime % 5 == 0)
            {
                currentMoney += 10 * houseNumb; // House produce £10 every 5 seconds.
                currentEnergy += 25 * factoryNumb; // Factory produce 25 energy every 5 seconds.
                tempNumb += factoryNumb * 1; // Factory temperature increase value (BEFORE: "factoryNumb / 100")
                currentHappiness += smallStoreNumb / 2;
                tempNumb -= windNumb * 2; // Wind trubine temperature decreases value "(BEFORE: (windNumb / 1000) * 9")
            }
            if(intTime % 6 == 0)
            {
                currentEnergy += 75 * windNumb; // Wind turbine produce 75 energy every 6 seconds.
                tempNumb -= solarNumb * 1; // Solar panel temperature decreases value (BEFORE: "(solarNumb / 1000) * 3")
            }

            if(intTime % 10 == 0)
            {
                temp.value += houseNumb / 1000;
                temp.value += (smallStoreNumb / 1000) * 3;
                currentHappiness += 1 * bigStoreNumb;
                currentHappiness += 2 * apartmentNumb;
                tempNumb -= treeNumb * 1; // Trees temperature decrease value (BEFORE: "treeNumb / 1000")
            }
            if(intTime % 1 == 0)
            {
                currentHappiness += 1;
            }
            if(intTime % 7 == 0)
            {
                currentMoney += 60 * smallStoreNumb; // Local store produce £60 every 7 seconds.
                tempNumb += apartmentNumb * 4; // Apartment temperature increases value (BEFORE: "(apartmentNumb / 1000) * 8")
            }
            if(intTime % 8 == 0) 
            {
                tempNumb += bigStoreNumb * 3; // Super store temperature increases value (BEFORE: "(bigStoreNumb / 1000) * 6")
            }
            if(intTime % 11 == 0)
            {
                currentMoney += 125 * bigStoreNumb; // Super store produce £125 every 11 seconds.
            }
            if(intTime % 12 == 0)
            {
                currentMoney += 150 * apartmentNumb; // Apartment produce £150 every 12 seconds.
            }
            
            energyText.text = currentEnergy.ToString();            
            moneyText.text = currentMoney.ToString();
            happinessText.text = currentHappiness.ToString();
            temp.value += tempNumb; // CHECK HERE: If I remove the + and keep the =, it follows the 5 second delay code, however, it instantly goes back to 0.5 on the temperture bar.

            time = 0;
        }
    }

    void PlayScreaming()
    {
        if(temp.value >= 850f)
        {
            screamingSource.PlayOneShot(screamingClip, 0.0f);
        }
    }

    public void GameOver(string loadLevel)
    {
        if(temp.value >= 1000f)
        {
            SceneManager.LoadScene(loadLevel);
        }
    }
}
