using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Enemies will simply chase the player around and disappear on contact
public class EnemyFollow : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [Range(0, 15), SerializeField] private float MoveSpeed;

    private void Start()
    {
        Player = FindObjectOfType<SimplePlayerMovement>().gameObject;
    }

    private void Update()
    {
        transform.position += (Player.transform.position - transform.position).normalized * MoveSpeed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.GetComponent<EnemyFollow>() == null)
        {
            Destroy(gameObject);
        }
    }
}
