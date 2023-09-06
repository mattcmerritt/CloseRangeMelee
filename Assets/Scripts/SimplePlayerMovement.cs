using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Handles moving the player along the screen with the WASD keys.
public class SimplePlayerMovement : MonoBehaviour
{
    [Range(0, 15), SerializeField] private float MoveSpeed;

    private void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        transform.position += (horizontalInput * Vector3.right + verticalInput * Vector3.up) * MoveSpeed * Time.deltaTime;
    }
}
