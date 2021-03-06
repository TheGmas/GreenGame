﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {
	
	// Update is called once per frame
	void Update ()
    {
        if ((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) && gameObject.transform.position.x > -37)
        {
            transform.Translate(new Vector3(-0.2f, 0f, 0f));
        }
        if ((Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) && gameObject.transform.position.x < 22)
        {
            transform.Translate(new Vector3(0.2f, 0f, 0f));
        }
        if ((Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) && gameObject.transform.position.z < -10)
        {
            transform.Translate(new Vector3(0f, 0.2f, 0.2f));
        }
        if ((Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)) && gameObject.transform.position.z > -85)
        {
            transform.Translate(new Vector3(0f, -0.2f, -0.2f));
        }
    }
}
