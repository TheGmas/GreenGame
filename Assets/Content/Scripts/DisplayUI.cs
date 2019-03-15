using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayUI : MonoBehaviour
{
    public GameObject displayUI;
    public float delay = 5.0f;
    private float countdown;

    // Use this for initialization
    void Start ()
    {
        countdown = delay;
    }
	
	// Update is called once per frame
	void Update ()
    {
        countdown -= Time.deltaTime;

        if (countdown <= 0.0f)
        {
            displayUI.SetActive(true);
        }
    }
}
