using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;  // players rotation and info
    public Vector3 offset;

    void Update()
    {

        transform.position = player.position + offset;
    }
}
