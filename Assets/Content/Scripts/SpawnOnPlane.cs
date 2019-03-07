using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnOnPlane : MonoBehaviour
{
    bool spawned = false;
    int buildingNumb, moneyInt, energyInt;
    public GameObject factory, factory1, house, house2, house3, windTurbine, tree1, tree2, solarPanel, apartment, smallStore, supermarket;
    public Material green, lightGreen;
    public Button factoryBtn, factory1Btn, houseBtn, houseBtn2, houseBtn3, windTurbineBtn, tree1Btn, tree2Btn, solarPanelBtn, apartmentBtn, smallStoreBtn, supermarketBtn, backBtn, demolishBtn;
    public Text moneyText, energyText;
    GameObject build;
    RaycastHit BuildCheck;
    public Transform buildCheck;

	// Use this for initialization
    void Start()
    {
        //add a listener for the desired button

        factoryBtn.onClick.AddListener(factoryButton);
        factory1Btn.onClick.AddListener(factory1Button);
        houseBtn.onClick.AddListener(houseButton);
        houseBtn2.onClick.AddListener(houseButton2);
        houseBtn3.onClick.AddListener(houseButton3);
        houseBtn3.onClick.AddListener(houseButton3);
        windTurbineBtn.onClick.AddListener(windTurbineButton);
        tree1Btn.onClick.AddListener(tree1Button);
        tree2Btn.onClick.AddListener(tree2Button);
        solarPanelBtn.onClick.AddListener(solarPanelButton);
        apartmentBtn.onClick.AddListener(apartmentButton);
        smallStoreBtn.onClick.AddListener(smallStoreButton);
        supermarketBtn.onClick.AddListener(supermarketButton);
        backBtn.onClick.AddListener(returnButton);
        demolishBtn.onClick.AddListener(destroyBuild);
    }

    // Update is called once per frame
    void Update ()
    {
        moneyInt = int.Parse(moneyText.text);
        energyInt = int.Parse(energyText.text);
	}

    void OnMouseDown()
    {
        if (!spawned)
        {
            //creating the if statement. 
            //the building numb here should be the same as the one desired - set below in a seperate function.
            //use and statement to check if player has required money/energy
            //instantiate the desired model on the same spot as the plane, adjust money/energy int
            //use moneyText.text = moneyInt.ToString(); and/or energyText.text = energyInt.ToString(); to update on screen
            //after that, button should work and place buildings.
            if (buildingNumb == 1 && moneyInt >= 25) //factory
            {
                build = Instantiate(factory, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.Euler(new Vector3(-90, 180, 0))) as GameObject;
                spawned = true;
                moneyInt -= 20;
                moneyText.text = moneyInt.ToString();
            }
            else if (buildingNumb == 2 && moneyInt >= 20 && energyInt >= 5) //house1
            {
                Instantiate(house, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.Euler(new Vector3(-90, 180, 0)));
                spawned = true;
                moneyInt -= 20;
                energyInt -= 5;
                moneyText.text = moneyInt.ToString();
                energyText.text = energyInt.ToString();
            }
            else if (buildingNumb == 4 && moneyInt >= 20 && energyInt >= 5) //house2
            {
                Instantiate(house2, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.Euler(new Vector3(-90, 180, 0)));
                spawned = true;
                moneyInt -= 20;
                energyInt -= 5;
                moneyText.text = moneyInt.ToString();
                energyText.text = energyInt.ToString();
            }
            else if (buildingNumb == 5 && moneyInt >= 25) //factory1
            {
                Instantiate(factory1, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.Euler(new Vector3(-90, 180, 0)));
                spawned = true;
                moneyInt -= 20;
                moneyText.text = moneyInt.ToString();
            }
            else if (buildingNumb == 6 && moneyInt >= 20 && energyInt >= 5) //house3
            {
                Instantiate(house3, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.Euler(new Vector3(-90, 180, 0)));
                spawned = true;
                moneyInt -= 20;
                energyInt -= 5;
                moneyText.text = moneyInt.ToString();
                energyText.text = energyInt.ToString();
            }
            else if (buildingNumb == 7 && moneyInt >= 25) //windturbine
            {
                Instantiate(windTurbine, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.Euler(new Vector3(-90, 180, 0)));
                spawned = true;
                moneyInt -= 20;
                moneyText.text = moneyInt.ToString();
            }
            else if (buildingNumb == 8 && moneyInt >= 25) //tree1
            {
                Instantiate(tree1, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.Euler(new Vector3(-90, 180, 0)));
                spawned = true;
                moneyInt -= 20;
                moneyText.text = moneyInt.ToString();
            }
            else if (buildingNumb == 9 && moneyInt >= 25) //tree2
            {
                Instantiate(tree2, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.Euler(new Vector3(-90, 180, 0)));
                spawned = true;
                moneyInt -= 20;
                moneyText.text = moneyInt.ToString();
            }
            else if (buildingNumb == 10 && moneyInt >= 25) //solarPanel
            {
                Instantiate(solarPanel, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.Euler(new Vector3(-90, 180, 0)));
                spawned = true;
                moneyInt -= 20;
                moneyText.text = moneyInt.ToString();
            }
            else if (buildingNumb == 11 && moneyInt >= 20 && energyInt >= 5) //apartment
            {
                Instantiate(apartment, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.Euler(new Vector3(-90, 180, 0)));
                spawned = true;
                moneyInt -= 20;
                energyInt -= 5;
                moneyText.text = moneyInt.ToString();
                energyText.text = energyInt.ToString();
            }
            else if (buildingNumb == 12 && moneyInt >= 20 && energyInt >= 5) //smallstore
            {
                Instantiate(smallStore, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.Euler(new Vector3(-90, 180, 0)));
                spawned = true;
                moneyInt -= 20;
                energyInt -= 5;
                moneyText.text = moneyInt.ToString();
                energyText.text = energyInt.ToString();
            }
            else if (buildingNumb == 13 && moneyInt >= 20 && energyInt >= 5) //supermarket
            {
                Instantiate(supermarket, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.Euler(new Vector3(-90, 180, 0)));
                spawned = true;
                moneyInt -= 20;
                energyInt -= 5;
                moneyText.text = moneyInt.ToString();
                energyText.text = energyInt.ToString();
            }
        }
        else if (buildingNumb == 3)
        {

            Collider[] built = Physics.OverlapSphere(gameObject.transform.position, 1f);
            foreach (Collider hit in built)
            {
                if(hit.tag == "House" || hit.tag == "Factory")
                {
                   
                    Destroy(hit.gameObject);
                    spawned = false;
                }
            }
        }
    }

    void OnMouseOver()
    {
        GetComponent<Renderer>().material = lightGreen;
    }

    void OnMouseExit()
    {
        GetComponent<Renderer>().material = green;
    }
    //create function with same name as listener to change building numb
    void factoryButton()
    {
        buildingNumb = 1;
    }
    void factory1Button()
    {
        buildingNumb = 5;
    }
    void houseButton()
    {
        buildingNumb = 2;
    }
    void houseButton2()
    {
        buildingNumb = 4;
    }
    void houseButton3()
    {
        buildingNumb = 6;
    }
    void windTurbineButton()
    {
        buildingNumb = 7;
    }
    void tree1Button()
    {
        buildingNumb = 8;
    }
    void tree2Button()
    {
        buildingNumb = 9;
    }
    void solarPanelButton()
    {
        buildingNumb = 10;
    }
    void apartmentButton()
    {
        buildingNumb = 11;
    }
    void smallStoreButton()
    {
        buildingNumb = 12;
    }
    void supermarketButton()
    {
        buildingNumb = 13;
    }
    void returnButton()
    {
        buildingNumb = 0;
    }
    void destroyBuild()
    {
        buildingNumb = 3;
    }
   
}
