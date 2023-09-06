using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Keeps track of if there is an enemy close to the player
public class PlayerEnemyDetection : MonoBehaviour
{
    [SerializeField] private bool EnemyClose;

    public bool CheckEnemyClose()
    {
        return EnemyClose;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        EnemyClose = collision.GetComponent<EnemyFollow>() != null;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        EnemyClose = !(collision.GetComponent<EnemyFollow>() != null);
    }
}
