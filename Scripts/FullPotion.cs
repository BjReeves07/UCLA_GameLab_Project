using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour
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
                    stats.health = PlayerStats.maxHealth;
                    Destroy(gameObject);
                }
            }
        }
    }
}