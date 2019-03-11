using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RollOver : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    // Set this to a seperate panel with text of building description
    public GameObject houseRollover, apartmentRollover, factoryRollover, supermarketRollover, treeRollover, windturbineRollover, solarpanelRollover, demolishRollover, shopWindow;

        public void OnPointerEnter(PointerEventData eventData)
        {
        if (gameObject.name == "House_1" || gameObject.name == "House_2" || gameObject.name == "House_3")
        {
            houseRollover.SetActive(true);
        }
        if (gameObject.name == "Factory_1" || gameObject.name == "Factory_2")
        {
            factoryRollover.SetActive(true);
        }
        if (gameObject.name == "Demolish")
        {
            demolishRollover.SetActive(true);
        }
        if (gameObject.name == "Apartments")
        {
            apartmentRollover.SetActive(true);
        }
        if (gameObject.name == "SmallStore" || gameObject.name == "Supermarket")
        {
            supermarketRollover.SetActive(true);
        }
        if (gameObject.name == "WindTurbine")
        {
            windturbineRollover.SetActive(true);
        }
        if (gameObject.name == "Tree_1" || gameObject.name == "Tree_2")
        {
            treeRollover.SetActive(true);
        }
        if (gameObject.name == "SolarPanel")
        {
            solarpanelRollover.SetActive(true);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (gameObject.name == "House_1" || gameObject.name == "House_2" || gameObject.name == "House_3")
        {
            houseRollover.SetActive(false);
        }
        if (gameObject.name == "Factory_1" || gameObject.name == "Factory_2")
        {
            factoryRollover.SetActive(false);
        }
        if (gameObject.name == "Demolish")
        {
            demolishRollover.SetActive(false);
        }
        if (gameObject.name == "Apartments")
        {
            apartmentRollover.SetActive(false);
        }
        if (gameObject.name == "SmallStore" || gameObject.name == "Supermarket")
        {
            supermarketRollover.SetActive(false);
        }
        if (gameObject.name == "WindTurbine")
        {
            windturbineRollover.SetActive(false);
        }
        if (gameObject.name == "Tree_1" || gameObject.name == "Tree_2")
        {
            treeRollover.SetActive(false);
        }
        if (gameObject.name == "SolarPanel")
        {
            solarpanelRollover.SetActive(false);
        }
    }
}
