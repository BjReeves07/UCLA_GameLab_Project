using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPotion : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerStats stats = collision.gameObject.GetComponent<PlayerStats>();
        if (stats != null)
        {
            if (collision.gameObject.tag == "Player")
            {
                if (stats.health + 3 <= PlayerStats.maxHealth)
                {
                    stats.health += 3;
                    Destroy(gameObject);
                }
                else
                {
                    stats.health = PlayerStats.maxHealth;
                    Destroy(gameObject);
                }
            }
        }
    }
}