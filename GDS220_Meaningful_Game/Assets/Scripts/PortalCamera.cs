using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCamera : MonoBehaviour
{
    public Transform playerCamera;
    public Transform portal;
    public Transform otherPortal;

    void Start()
    {
        
    }

    void Update()
    {
        //GetOffset();
        GetRotation();
    }

    void GetOffset()
    {
        Vector3 playerOffsetFromPortal = playerCamera.position - otherPortal.position;
        transform.position = portal.position - playerOffsetFromPortal;
    }

    void GetRotation()
    {
        float angularDefferenceBetweenPortalRotations = Quaternion.Angle(portal.rotation, otherPortal.rotation);


        Quaternion portalRotationalDefference = Quaternion.AngleAxis(angularDefferenceBetweenPortalRotations, Vector3.up);
        Vector3 newCameraDirection = portalRotationalDefference * playerCamera.forward;
        transform.rotation = Quaternion.LookRotation(newCameraDirection, Vector3.up);
    }
}
