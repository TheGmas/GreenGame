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
        houseBtn.onClick.AddListener(houseButton);
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
            if (buildingNumb == 1 && moneyInt >= 25)
            {
                build = Instantiate(factory, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.Euler(new Vector3(-90, 180, 0))) as GameObject;
                spawned = true;
                moneyInt -= 20;
                moneyText.text = moneyInt.ToString();
            }
            else if (buildingNumb == 2 && moneyInt >= 20 && energyInt >= 5)
            {
                Instantiate(house, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.Euler(new Vector3(-90, 180, 0)));
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
    void houseButton()
    {
        buildingNumb = 2;
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
