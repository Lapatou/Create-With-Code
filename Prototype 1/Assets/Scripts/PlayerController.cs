using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed;
    public float turnSpeed;

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * Speed* Input.GetAxis("Vertical"));
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * Input.GetAxis("Horizontal"));
    }
}
