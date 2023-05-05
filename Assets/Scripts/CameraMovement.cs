using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Vector3 offset = new Vector3(0, 15, 0);
    private Transform targetTransorm;
    void Start()
    {
        targetTransorm = GameObject.Find("Player").GetComponent<Transform>();
    }

    void LateUpdate()
    {
        transform.position = targetTransorm.position + offset;
    }
}
