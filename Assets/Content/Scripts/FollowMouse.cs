using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    public GameObject Coal_Factory;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100) && hit.point.y < 50f)
            {
                if (hit.collider.tag.Equals("Building"))
                {
                    print("There is already a building there!");
                }
                else
                {
                    GameObject coalfact = Instantiate(Coal_Factory, new Vector3(0, 0, 0), Quaternion.Euler(new Vector3(-90, 180, 0)));
                    coalfact.transform.localScale = new Vector3(50f, 50f, 50f);
                    float rx = (float)(Mathf.RoundToInt(hit.point.x));
                    float ry = (float)(Mathf.RoundToInt(hit.point.y));
                    float rz = (float)(Mathf.RoundToInt(hit.point.z));
                    coalfact.transform.position = new Vector3(rx, 0.8794785f, rz) + new Vector3(0f, 0f, 0f);
                }

                //Rigidbody rgbd = Coal_Factory.GetComponent<Rigidbody>();
                //rgbd.useGravity = false;
                //rgbd.constraints = RigidbodyConstraints.FreezeAll;
            }
        }
    }
}
