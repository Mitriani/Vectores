using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float playerSpeed = 20.0f;
    private float playerRotationSpeed = 100f;
    void Start()
    {
        
    }

    void Update()
    {
        PlayerRotation();
        PlayerMovement();
    }

    void PlayerMovement()
    {
        float vAxis = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(0, 0, vAxis) * playerSpeed * Time.deltaTime);
    }

    void PlayerRotation()
    {
        float hCamAxis = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, hCamAxis * playerRotationSpeed * Time.deltaTime);
    }
}
