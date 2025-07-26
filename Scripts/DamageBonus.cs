using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBonus : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerStats stats = collision.gameObject.GetComponent<PlayerStats>();
        if (stats != null)
        {
            if (collision.gameObject.tag == "Player")
            {
                if (PlayerStats.damageMultiplier > 0)
                {
                    PlayerStats.damageMultiplier += 0.5f;
                    Destroy(gameObject);
                }
            }
        }
    }
}
