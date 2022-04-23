///The CameraFollow script for Unity
///It needs to be a part of the camera otherwise it wont work properly

//Import libraries
using UnityEngine;

//Main Class
public class CameraFollow : MonoBehaviour
{
    //Target transform
    public Transform target;

    //Speed to follow at
    public float smoothSpeed = 0.125f;
    
    //Vector3 Offset
    public Vector3 offset;

    //Updates when the frame is just finished
    void LateUpdate()
    {
        //Set a desired position based on the target's position and offset
        Vector3 desiredPosition = target.position + offset;
        //Set the position
        transform.position = desiredPosition;
    }
}
