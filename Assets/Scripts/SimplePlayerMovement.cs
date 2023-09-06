using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Handles moving the player along the screen with the WASD keys.
public class SimplePlayerMovement : MonoBehaviour
{
    [Range(0, 15), SerializeField] private float MoveSpeed;

    private void Update()
    {
        // translational movement with WASD
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");
        transform.position += (horizontalInput * Vector3.right + verticalInput * Vector3.up) * MoveSpeed * Time.deltaTime;

        // have player face the mouse
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float theta = - Mathf.Atan2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y) * 180 / Mathf.PI;
        transform.eulerAngles = new Vector3(0f, 0f, theta);
    }
}
