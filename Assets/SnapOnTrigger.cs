using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction;
using OculusSampleFramework;

public class SnapOnTrigger : MonoBehaviour
{   
 public GameObject targetObject;
    private bool isColliding = false;
    private bool isGrabbed = false;
    private Grabbable grabbable;

    private void Start()
    {
        grabbable = GetComponent<Grabbable>();
        grabbable.WhenGrabbableUpdated += OnGrabbableUpdated;
    }

    private void OnGrabbableUpdated(GrabbableArgs args)
    {
        if (args.GrabbableEvent == GrabbableEvent.Add)
        {
            isGrabbed = true;
        }
        else if (args.GrabbableEvent == GrabbableEvent.Remove)
        {
            isGrabbed = false;
            if (isColliding)
            {
                transform.position = targetObject.transform.position;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isGrabbed && other.gameObject == targetObject)
        {
            isColliding = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (!isGrabbed && other.gameObject == targetObject)
        {
            isColliding = false;
        }
    }
}
