using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RollOver : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    //set this to a seperate panel with text of building description
    public GameObject houseRollover, factoryRollover, demolishRollover;

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
    }
}
