using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookAt : MonoBehaviour
{
    public Transform target;          // Assign the character's transform
    public float smoothSpeed = 0.125f; // Adjust the smoothness

    void Update()
    {
        if (target != null)
        {
            // Smooth rotation towards the target
            Quaternion targetRotation = Quaternion.LookRotation(target.position - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, smoothSpeed);
        }
    }
}
