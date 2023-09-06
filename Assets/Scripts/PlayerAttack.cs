using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Player will either fire projectiles or swing sword depending on if enemies are close
public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private GameObject ProjectilePrefab, ProjectileSpawnpoint;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        { 
            if (GetComponent<PlayerEnemyDetection>().CheckEnemyClose())
            {
                GetComponent<Animator>().SetTrigger("Swing");
            }
            else
            {
                Instantiate(ProjectilePrefab, ProjectileSpawnpoint.transform.position, Quaternion.identity);
            }
        }
    }
}
