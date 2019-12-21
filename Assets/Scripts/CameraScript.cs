using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 rot = transform.eulerAngles;
        rot.x = 30;
        rot.y = 0;
        rot.z = 0;
        transform.eulerAngles = rot;

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 rot = transform.eulerAngles;
        rot.x = 30;
        rot.y = 0;
        rot.z = 0;
        transform.eulerAngles = rot;
    }
}
