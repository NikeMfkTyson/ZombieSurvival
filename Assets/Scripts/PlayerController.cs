using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5;
    private int health = 100;
    private Rigidbody playerRb;
    
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        float horizontalInput = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float verticalInput = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(horizontalInput, 0, verticalInput);
    }
}
