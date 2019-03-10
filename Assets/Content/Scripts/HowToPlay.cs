using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HowToPlay : MonoBehaviour {

    public GameObject HowToPlayPanel;
    public Button playBtn;


	// Use this for initialization
	void Start () {
        HowToPlayPanel.SetActive(true);
        playBtn.onClick.AddListener(closePanel);
	}
	
	// Update is called once per frame
	void closePanel () {
        HowToPlayPanel.SetActive(false);
	}
}
