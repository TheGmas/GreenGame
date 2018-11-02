using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{


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
            if (Physics.Raycast(ray, out hit, 100) && hit.point.y < 1.01f)
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.localScale = new Vector3(1.01f, 1.01f, 1.01f);
                float rx = (float)(Mathf.RoundToInt(hit.point.x));
                float ry = (float)(Mathf.RoundToInt(hit.point.y));
                float rz = (float)(Mathf.RoundToInt(hit.point.z));
                cube.transform.position = new Vector3(rx, ry, rz) + new Vector3(0, 0.5F, 0);


                Rigidbody rgbd = cube.AddComponent<Rigidbody>();
                rgbd.useGravity = false;
                rgbd.constraints = RigidbodyConstraints.FreezeAll;
            }
        }
    }
}
