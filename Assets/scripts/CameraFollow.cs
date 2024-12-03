using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
  
  public Transform followTarget;    // the target for our camera to follow

  public float smoothTime = 0.3f;    // the time it takes the camera to reach its target

  private Vector3 velocity = Vector3.zero;

  void LateUpdate()
    {
        Vector3 targetPosition = followTarget.position;
        targetPosition.z = transform.position.z;    // we dont want the z position to change as this will mess our camera up

        // smoothly move the camera towards that target position
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }


public void SwitchCameraTargets(Transform newCameraTarget)
    {
        followTarget = newCameraTarget;
    }
}
