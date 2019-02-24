using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnOnPlane : MonoBehaviour
{
    bool spawned = false;
    int buildingNumb, moneyInt, energyInt;
    public GameObject factory, house;
    public Material green, lightGreen;
    public Button factoryBtn, houseBtn, backBtn, demolishBtn;
    public Text moneyText, energyText;
    GameObject build;
    RaycastHit BuildCheck;
    public Transform buildCheck;

	// Use this for initialization
    void Start()
    {
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
            print("builddest");
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
