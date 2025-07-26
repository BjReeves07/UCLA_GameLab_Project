using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxPotion : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerStats stats = collision.gameObject.GetComponent<PlayerStats>();
        if (stats != null)
        {
            if (collision.gameObject.tag == "Player")
            {
                if (stats.health > 0)
                {
                    PlayerStats.maxHealth += 3;
                    stats.health = PlayerStats.maxHealth;
                    Destroy(gameObject);
                }
            }
        }
    }
}