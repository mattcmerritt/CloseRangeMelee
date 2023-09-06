using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private Vector3 Direction;
    [SerializeField] private float MoveSpeed, MaxDimension;

    private void Start()
    {
        Vector3 playerLocation = FindObjectOfType<SimplePlayerMovement>().transform.position;
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Direction = (mousePosition - playerLocation).normalized;
    }

    private void Update()
    {
        transform.position += Direction * MoveSpeed * Time.deltaTime;
        if (Mathf.Abs(transform.position.x) > MaxDimension || Mathf.Abs(transform.position.y) > MaxDimension)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.GetComponent<EnemyFollow>() != null)
        {
            Destroy(gameObject);
        }
    }
}
