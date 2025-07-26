using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class GameOverOnCollision : MonoBehaviour
{
    Rigidbody2D enemyRb;
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerStats stats = collision.gameObject.GetComponent<PlayerStats>();
        if (stats != null)
        {
            if (collision.gameObject.tag == "Player")
            {
                if (stats.health > 0)
                {
                    stats.health--;
                    GameObject.Destroy(gameObject);
                }
                else
                {
                    SceneManager.LoadScene("Game Over");
                }
            }
        }
    }
}

