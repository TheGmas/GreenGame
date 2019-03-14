using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnOnPlane : MonoBehaviour
{
    bool spawned = false, transSpawn = false;
    int buildingNumb, moneyInt, energyInt;
    public GameObject rightClickPanel, factory, factory1, house, house2, house3, windTurbine, tree1, tree2, solarPanel, apartment, smallStore, supermarket, shopPanel, houseRoll, factoryRoll, demoRoll, aptRoll, superRoll, treeRoll, windRoll, solarRoll, house1HL, house2HL, house3HL, factory1HL, factory2HL, storeHL, superstoreHL, solarHL, tree01HL, tree02HL, windHL, apartmentHL;
    public Material green, lightGreen;
    public Button factoryBtn, factory1Btn, houseBtn, houseBtn2, houseBtn3, windTurbineBtn, tree1Btn, tree2Btn, solarPanelBtn, apartmentBtn, smallStoreBtn, supermarketBtn, backBtn, demolishBtn;
    public Text moneyText, energyText;
    
    
    GameObject build;
    RaycastHit BuildCheck;
    public Transform buildCheck;

	// Use this for initialization
    void Start()
    {
        // Add a listener for the desired button

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

        if(rightClickPanel.activeSelf == true && Input.GetMouseButton(1))
        {
            shopPanel.SetActive(true);
            rightClickPanel.SetActive(false);

            destroyTrans();
        }
	}

    void OnMouseDown()
    {
        if (!spawned && shopPanel.activeSelf == false)
        {
            // Creating the if statement. 
            // The building numb here should be the same as the one desired - set below in a seperate function.
            // Use and statement to check if player has required money/energy
            // instantiate the desired model on the same spot as the plane, adjust money/energy int
            // use moneyText.text = moneyInt.ToString(); and/or energyText.text = energyInt.ToString(); to update on screen
            // After that, button should work and place buildings.

            if (buildingNumb == 1 && moneyInt >= 25  && energyInt >= 50) //factory state
            {
                build = Instantiate(factory, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.Euler(new Vector3(-90, 180, 0))) as GameObject;
                spawned = true;
                moneyInt -= 25;
                energyInt -= 50;
                moneyText.text = moneyInt.ToString();
                energyText.text = energyInt.ToString();
                shopPanel.SetActive(true);
                rightClickPanel.SetActive(false);

                Collider[] built = Physics.OverlapSphere(gameObject.transform.position, 1f);
                foreach (Collider hit in built)
                {
                    if (hit.tag == "Highlight")
                    {
                        Destroy(hit.gameObject);
                    }
                }
            }
            else if (buildingNumb == 2 && moneyInt >= 20 && energyInt >= 20) //house1 state
            {
                Instantiate(house, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.Euler(new Vector3(-90, 180, 0)));
                spawned = true;
                moneyInt -= 20;
                energyInt -= 20;
                moneyText.text = moneyInt.ToString();
                energyText.text = energyInt.ToString();
                shopPanel.SetActive(true);
                rightClickPanel.SetActive(false);

                Collider[] built = Physics.OverlapSphere(gameObject.transform.position, 1f);
                foreach (Collider hit in built)
                {
                    if (hit.tag == "Highlight")
                    {
                        Destroy(hit.gameObject);
                    }
                }
            }
            else if (buildingNumb == 4 && moneyInt >= 20 && energyInt >= 20) //house2 state
            {
                Instantiate(house2, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.Euler(new Vector3(-90, 180, 0)));
                spawned = true;
                moneyInt -= 20;
                energyInt -= 20;
                moneyText.text = moneyInt.ToString();
                energyText.text = energyInt.ToString();
                shopPanel.SetActive(true);
                rightClickPanel.SetActive(false);

                Collider[] built = Physics.OverlapSphere(gameObject.transform.position, 1f);
                foreach (Collider hit in built)
                {
                    if (hit.tag == "Highlight")
                    {
                        Destroy(hit.gameObject);
                    }
                }
            }
            else if (buildingNumb == 5 && moneyInt >= 25 && energyInt >=50) // factory1 state
            {
                Instantiate(factory1, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.Euler(new Vector3(-90, 180, 0)));
                spawned = true;
                moneyInt -= 25;
                energyInt -= 50;
                moneyText.text = moneyInt.ToString();
                energyText.text = energyInt.ToString();
                shopPanel.SetActive(true);
                rightClickPanel.SetActive(false);
                print("yes");

                Collider[] built = Physics.OverlapSphere(gameObject.transform.position, 1f);
                foreach (Collider hit in built)
                {
                    if (hit.tag == "Highlight")
                    {
                        Destroy(hit.gameObject);
                    }
                }
            }
            else if (buildingNumb == 6 && moneyInt >= 20 && energyInt >= 20) // house3 state
            {
                Instantiate(house3, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.Euler(new Vector3(-90, 180, 0)));
                spawned = true;
                moneyInt -= 20;
                energyInt -= 20;
                moneyText.text = moneyInt.ToString();
                energyText.text = energyInt.ToString();
                shopPanel.SetActive(true);
                rightClickPanel.SetActive(false);

                Collider[] built = Physics.OverlapSphere(gameObject.transform.position, 1f);
                foreach (Collider hit in built)
                {
                    if (hit.tag == "Highlight")
                    {
                        Destroy(hit.gameObject);
                    }
                }
            }
            else if (buildingNumb == 7 && moneyInt >= 150) // windturbine state
            {
                Instantiate(windTurbine, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.Euler(new Vector3(-90, 180, 0)));
                spawned = true;
                moneyInt -= 150;
                moneyText.text = moneyInt.ToString();
                shopPanel.SetActive(true);
                rightClickPanel.SetActive(false);

                Collider[] built = Physics.OverlapSphere(gameObject.transform.position, 1f);
                foreach (Collider hit in built)
                {
                    if (hit.tag == "Highlight")
                    {
                        Destroy(hit.gameObject);
                    }
                }
            }
            else if (buildingNumb == 8 && moneyInt >= 10) // tree1 state
            {
                Instantiate(tree1, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.Euler(new Vector3(-90, 180, 0)));
                spawned = true;
                moneyInt -= 10;
                moneyText.text = moneyInt.ToString();
                shopPanel.SetActive(true);
                rightClickPanel.SetActive(false);

                Collider[] built = Physics.OverlapSphere(gameObject.transform.position, 1f);
                foreach (Collider hit in built)
                {
                    if (hit.tag == "Highlight")
                    {
                        Destroy(hit.gameObject);
                    }
                }
            }
            else if (buildingNumb == 9 && moneyInt >= 10) // tree2 state
            {
                Instantiate(tree2, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.Euler(new Vector3(-90, 180, 0)));
                spawned = true;
                moneyInt -= 10;
                moneyText.text = moneyInt.ToString();
                shopPanel.SetActive(true);
                rightClickPanel.SetActive(false);

                Collider[] built = Physics.OverlapSphere(gameObject.transform.position, 1f);
                foreach (Collider hit in built)
                {
                    if (hit.tag == "Highlight")
                    {
                        Destroy(hit.gameObject);
                    }
                }
            }
            else if (buildingNumb == 10 && moneyInt >= 35) // solarPanel state
            {
                Instantiate(solarPanel, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.Euler(new Vector3(-135, 180, 0)));
                spawned = true;
                moneyInt -= 35;
                moneyText.text = moneyInt.ToString();
                shopPanel.SetActive(true);
                rightClickPanel.SetActive(false);

                Collider[] built = Physics.OverlapSphere(gameObject.transform.position, 1f);
                foreach (Collider hit in built)
                {
                    if (hit.tag == "Highlight")
                    {
                        Destroy(hit.gameObject);
                    }
                }
            }
            else if (buildingNumb == 11 && moneyInt >= 275 && energyInt >= 80) // apartment state
            {
                Instantiate(apartment, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.Euler(new Vector3(-90, 180, 0)));
                spawned = true;
                moneyInt -= 275;
                energyInt -= 80;
                moneyText.text = moneyInt.ToString();
                energyText.text = energyInt.ToString();
                shopPanel.SetActive(true);
                rightClickPanel.SetActive(false);

                Collider[] built = Physics.OverlapSphere(gameObject.transform.position, 1f);
                foreach (Collider hit in built)
                {
                    if (hit.tag == "Highlight")
                    {
                        Destroy(hit.gameObject);
                    }
                }
            }
            else if (buildingNumb == 12 && moneyInt >= 125 && energyInt >= 25) // smallstore state
            {
                Instantiate(smallStore, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.Euler(new Vector3(-90, 180, 0)));
                spawned = true;
                moneyInt -= 125;
                energyInt -= 25;
                moneyText.text = moneyInt.ToString();
                energyText.text = energyInt.ToString();
                shopPanel.SetActive(true);
                rightClickPanel.SetActive(false);

                Collider[] built = Physics.OverlapSphere(gameObject.transform.position, 1f);
                foreach (Collider hit in built)
                {
                    if (hit.tag == "Highlight")
                    {
                        Destroy(hit.gameObject);
                    }
                }
            }
            else if (buildingNumb == 13 && moneyInt >= 250 && energyInt >= 80) // supermarket state
            {
                Instantiate(supermarket, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.Euler(new Vector3(-90, 180, 0)));
                spawned = true;
                moneyInt -= 250;
                energyInt -= 80;
                moneyText.text = moneyInt.ToString();
                energyText.text = energyInt.ToString();
                shopPanel.SetActive(true);
                rightClickPanel.SetActive(false);

                Collider[] built = Physics.OverlapSphere(gameObject.transform.position, 1f);
                foreach (Collider hit in built)
                {
                    if (hit.tag == "Highlight")
                    {
                        Destroy(hit.gameObject);
                    }
                }
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

        if(rightClickPanel.activeSelf == true && buildingNumb == 2 && !spawned && transSpawn == false)
        {
            Instantiate(house1HL, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.Euler(new Vector3(-90, 180, 0)));
            transSpawn = true;
        }
        if (rightClickPanel.activeSelf == true && buildingNumb == 4 && !spawned && transSpawn == false)
        {
            Instantiate(house2HL, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.Euler(new Vector3(-90, 180, 0)));
            transSpawn = true;
        }
        if (rightClickPanel.activeSelf == true && buildingNumb == 1 && !spawned && transSpawn == false)
        {
            Instantiate(factory2HL, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.Euler(new Vector3(-90, 180, 0)));
            transSpawn = true;
        }
        if (rightClickPanel.activeSelf == true && buildingNumb == 5 && !spawned && transSpawn == false)
        {
            Instantiate(factory1HL, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.Euler(new Vector3(-90, 180, 0)));
            transSpawn = true;
        }
        if (rightClickPanel.activeSelf == true && buildingNumb == 6 && !spawned && transSpawn == false)
        {
            Instantiate(house3HL, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.Euler(new Vector3(-90, 180, 0)));
            transSpawn = true;
        }
        if (rightClickPanel.activeSelf == true && buildingNumb == 7 && !spawned && transSpawn == false)
        {
            Instantiate(windHL, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.Euler(new Vector3(-90, 180, 0)));
            transSpawn = true;
        }
        if (rightClickPanel.activeSelf == true && buildingNumb == 8 && !spawned && transSpawn == false)
        {
            Instantiate(tree01HL, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.Euler(new Vector3(-90, 180, 0)));
            transSpawn = true;
        }
        if (rightClickPanel.activeSelf == true && buildingNumb == 9 && !spawned && transSpawn == false)
        {
            Instantiate(tree02HL, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.Euler(new Vector3(-90, 180, 0)));
            transSpawn = true;
        }
        if (rightClickPanel.activeSelf == true && buildingNumb == 10 && !spawned && transSpawn == false)
        {
            Instantiate(solarHL, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.Euler(new Vector3(-90, 180, 0)));
            transSpawn = true;
        }
        if (rightClickPanel.activeSelf == true && buildingNumb == 11 && !spawned && transSpawn == false)
        {
            Instantiate(apartmentHL, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.Euler(new Vector3(-90, 180, 0)));
            transSpawn = true;
        }
        if (rightClickPanel.activeSelf == true && buildingNumb == 12 && !spawned && transSpawn == false)
        {
            Instantiate(storeHL, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.Euler(new Vector3(-90, 180, 0)));
            transSpawn = true;
        }
        if (rightClickPanel.activeSelf == true && buildingNumb == 13 && !spawned && transSpawn == false)
        {
            Instantiate(superstoreHL, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.Euler(new Vector3(-90, 180, 0)));
            transSpawn = true;
        }
    }

    void OnMouseExit()
    {
        GetComponent<Renderer>().material = green;
        transSpawn = false;


         Collider[] built = Physics.OverlapSphere(gameObject.transform.position, 8f);
         foreach (Collider hit in built)
         {
             if (hit.tag == "Highlight")
             {
                print("hit highlight");
                 Destroy(hit.gameObject);
             }
         }
    }
    // Create function with same name as listener to change building numb
    void factoryButton()
    {
        buildingNumb = 1;
        shopPanel.SetActive(false);
        houseRoll.SetActive(false);
        factoryRoll.SetActive(false);
        demoRoll.SetActive(false);
        aptRoll.SetActive(false);
        superRoll.SetActive(false);
        treeRoll.SetActive(false);
        windRoll.SetActive(false);
        solarRoll.SetActive(false);
        rightClickPanel.SetActive(true);
    }
    void factory1Button()
    {
        buildingNumb = 5;
        shopPanel.SetActive(false);
        shopPanel.SetActive(false);
        houseRoll.SetActive(false);
        factoryRoll.SetActive(false);
        demoRoll.SetActive(false);
        aptRoll.SetActive(false);
        superRoll.SetActive(false);
        treeRoll.SetActive(false);
        windRoll.SetActive(false);
        solarRoll.SetActive(false);
        rightClickPanel.SetActive(true);
    }
    void houseButton()
    {
        buildingNumb = 2;
        shopPanel.SetActive(false);
        shopPanel.SetActive(false);
        houseRoll.SetActive(false);
        factoryRoll.SetActive(false);
        demoRoll.SetActive(false);
        aptRoll.SetActive(false);
        superRoll.SetActive(false);
        treeRoll.SetActive(false);
        windRoll.SetActive(false);
        solarRoll.SetActive(false);
        rightClickPanel.SetActive(true);
    }
    void houseButton2()
    {
        buildingNumb = 4;
        shopPanel.SetActive(false);
        shopPanel.SetActive(false);
        houseRoll.SetActive(false);
        factoryRoll.SetActive(false);
        demoRoll.SetActive(false);
        aptRoll.SetActive(false);
        superRoll.SetActive(false);
        treeRoll.SetActive(false);
        windRoll.SetActive(false);
        solarRoll.SetActive(false);
        rightClickPanel.SetActive(true);
    }
    void houseButton3()
    {
        buildingNumb = 6;
        shopPanel.SetActive(false);
        shopPanel.SetActive(false);
        houseRoll.SetActive(false);
        factoryRoll.SetActive(false);
        demoRoll.SetActive(false);
        aptRoll.SetActive(false);
        superRoll.SetActive(false);
        treeRoll.SetActive(false);
        windRoll.SetActive(false);
        solarRoll.SetActive(false);
        rightClickPanel.SetActive(true);
    }
    void windTurbineButton()
    {
        buildingNumb = 7;
        shopPanel.SetActive(false);
        shopPanel.SetActive(false);
        houseRoll.SetActive(false);
        factoryRoll.SetActive(false);
        demoRoll.SetActive(false);
        aptRoll.SetActive(false);
        superRoll.SetActive(false);
        treeRoll.SetActive(false);
        windRoll.SetActive(false);
        solarRoll.SetActive(false);
        rightClickPanel.SetActive(true);
    }
    void tree1Button()
    {
        buildingNumb = 8;
        shopPanel.SetActive(false);
        shopPanel.SetActive(false);
        houseRoll.SetActive(false);
        factoryRoll.SetActive(false);
        demoRoll.SetActive(false);
        aptRoll.SetActive(false);
        superRoll.SetActive(false);
        treeRoll.SetActive(false);
        windRoll.SetActive(false);
        solarRoll.SetActive(false);
        rightClickPanel.SetActive(true);
    }
    void tree2Button()
    {
        buildingNumb = 9;
        shopPanel.SetActive(false);
        shopPanel.SetActive(false);
        houseRoll.SetActive(false);
        factoryRoll.SetActive(false);
        demoRoll.SetActive(false);
        aptRoll.SetActive(false);
        superRoll.SetActive(false);
        treeRoll.SetActive(false);
        windRoll.SetActive(false);
        solarRoll.SetActive(false);
        rightClickPanel.SetActive(true);
    }
    void solarPanelButton()
    {
        buildingNumb = 10;
        shopPanel.SetActive(false);
        shopPanel.SetActive(false);
        houseRoll.SetActive(false);
        factoryRoll.SetActive(false);
        demoRoll.SetActive(false);
        aptRoll.SetActive(false);
        superRoll.SetActive(false);
        treeRoll.SetActive(false);
        windRoll.SetActive(false);
        solarRoll.SetActive(false);
        rightClickPanel.SetActive(true);
    }
    void apartmentButton()
    {
        buildingNumb = 11;
        shopPanel.SetActive(false);
        shopPanel.SetActive(false);
        houseRoll.SetActive(false);
        factoryRoll.SetActive(false);
        demoRoll.SetActive(false);
        aptRoll.SetActive(false);
        superRoll.SetActive(false);
        treeRoll.SetActive(false);
        windRoll.SetActive(false);
        solarRoll.SetActive(false);
        rightClickPanel.SetActive(true);
    }
    void smallStoreButton()
    {
        buildingNumb = 12;
        shopPanel.SetActive(false);
        shopPanel.SetActive(false);
        houseRoll.SetActive(false);
        factoryRoll.SetActive(false);
        demoRoll.SetActive(false);
        aptRoll.SetActive(false);
        superRoll.SetActive(false);
        treeRoll.SetActive(false);
        windRoll.SetActive(false);
        solarRoll.SetActive(false);
        rightClickPanel.SetActive(true);
    }
    void supermarketButton()
    {
        buildingNumb = 13;
        shopPanel.SetActive(false);
        shopPanel.SetActive(false);
        houseRoll.SetActive(false);
        factoryRoll.SetActive(false);
        demoRoll.SetActive(false);
        aptRoll.SetActive(false);
        superRoll.SetActive(false);
        treeRoll.SetActive(false);
        windRoll.SetActive(false);
        solarRoll.SetActive(false);
        rightClickPanel.SetActive(true);
    }
    void returnButton()
    {
        buildingNumb = 0;
        shopPanel.SetActive(false);
        houseRoll.SetActive(false);
        factoryRoll.SetActive(false);
        demoRoll.SetActive(false);
        aptRoll.SetActive(false);
        superRoll.SetActive(false);
        treeRoll.SetActive(false);
        windRoll.SetActive(false);
        solarRoll.SetActive(false);
        rightClickPanel.SetActive(true);
    }
    void destroyBuild()
    {
        buildingNumb = 3;
        shopPanel.SetActive(false);
        shopPanel.SetActive(false);
        houseRoll.SetActive(false);
        factoryRoll.SetActive(false);
        demoRoll.SetActive(false);
        aptRoll.SetActive(false);
        superRoll.SetActive(false);
        treeRoll.SetActive(false);
        windRoll.SetActive(false);
        solarRoll.SetActive(false);
        rightClickPanel.SetActive(true);
    }

    void destroyTrans()
    {
        Collider[] built = Physics.OverlapSphere(gameObject.transform.position, 1f);
        foreach (Collider hit in built)
        {
            if (hit.tag == "Highlight")
            {
                Destroy(hit.gameObject);
            }
        }
    }

}
