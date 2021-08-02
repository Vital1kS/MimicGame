using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    Camera cam;
    GameObject mimic;
    void Start()
    {
        cam = GetComponent<Camera>();
        mimic = GameObject.Find("Mimic");
    }

    // Update is called once per frame
    void LateUpdate()
    {
        cam.transform.position = new Vector3(mimic.transform.position.x, mimic.transform.position.y, cam.transform.position.z);
    }
}
