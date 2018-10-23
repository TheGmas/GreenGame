using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour {

    private int check;

    // Use this for initialization
    void Start()
    {

        check = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouse = Input.mousePosition;
        if (check == 1)
        {

            if (1 == 1)
            {
                mouse.z = 15f; // distance from camera
            }

            this.transform.position = Camera.main.ScreenToWorldPoint(mouse);

            if (Input.GetAxis("Mouse ScrollWheel") > 0f) // forward
            {
                mouse.z = mouse.z - 1f;
            }

            else if (Input.GetAxis("Mouse ScrollWheel") < 0f) // backwards
            {
                mouse.z--;
            }

            else if (Input.GetMouseButtonDown(0))
            {
                check = 2;
            }
        }
    }
}

