using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    Camera mainCam;


    private void Awake()
    {
        mainCam = GetComponent<Camera>();
        instance = this;
    }


    public static CamSwitch instance;

    public void SwitchCamToPlanet(Planet planet)
    {
        Transform planetTf = planet.gameObject;

        Vector3 lookDir = (transform.position - planetTf.transform.position).normalized;

        transform.LookAt(lookDir);


    }
}
