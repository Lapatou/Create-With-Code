using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 6, -10);

    // Update is called once per frame
    void LateUpdate()
    {
        // Offset camera behind player 
        transform.position = player.transform.position + offset;
    }
}
