using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour
{
    public Transform target;
    public float moveSmooth = 10f;
    public float turnSmooth = 10f;

    public Vector3 positionOffset = Vector3.zero;
    public Quaternion rotationOffset = Quaternion.identity;



    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + positionOffset, moveSmooth * Time.deltaTime);
        transform.rotation = Quaternion.Lerp(transform.rotation, target.rotation * rotationOffset, turnSmooth * Time.deltaTime);
    }
}
