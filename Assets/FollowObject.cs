using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour
{
    [SerializeField] private Transform ObjectToFollow;

    private void Update()
    {
        transform.position = ObjectToFollow.position;
        transform.position -= transform.forward * 10.0f;
    }
}
