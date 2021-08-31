using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCamara2 : MonoBehaviour
{
    public Camera OtherCam;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion direccion = Quaternion.Inverse(transform.rotation) * Camera.main.transform.rotation;

        OtherCam.transform.localEulerAngles = new Vector3(direccion.eulerAngles.x,
                                                          direccion.eulerAngles.y + 180, direccion.eulerAngles.z);

        Vector3 distancia = transform.InverseTransformPoint(Camera.main.transform.position);
        OtherCam.transform.localPosition = -new Vector3(distancia.x, -distancia.y, distancia.z) - new Vector3(0, 0, 20);
        
    }
}
