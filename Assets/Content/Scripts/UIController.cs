using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {
    public Button shopButton, backButton;
    public GameObject shopPanel, shopButtonPanel, backPanel;

    void Start()
    {
        shopButton.onClick.AddListener(openShop);
        backButton.onClick.AddListener(closeShop);
    }

    void openShop()
    {
        shopPanel.gameObject.SetActive(true);
        //shopButtonPanel.gameObject.SetActive(false);
        //backPanel.gameObject.SetActive(true);
    }

    void closeShop()
    {
        shopPanel.gameObject.SetActive(false);
        //shopButtonPanel.gameObject.SetActive(true);
        //backPanel.gameObject.SetActive(false);
    }

}
