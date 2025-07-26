using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Vector2 direction = Vector2.right;
    public Rigidbody2D projectileRB;
    public float speed = 8.0f;
    public GameObject player;
    //public Destructible destructibleObject;

    // Start is called before the first frame update
    void Start()
    {
        projectileRB = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        //Vector2 newPosition = projectileRB.position + player.inputDirection * speed * Time.fixedDeltaTime;
        Vector2 newPosition = projectileRB.position + direction * speed * Time.fixedDeltaTime;
        projectileRB.MovePosition(newPosition);
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destructible destructibleObject = collision.gameObject.GetComponent<Destructible>();
        EnemyDestroy enemy = collision.gameObject.GetComponent<EnemyDestroy>();
        if (destructibleObject != null)
        {
            Destroy(gameObject);
            PlayerStats stats = player.gameObject.GetComponent<PlayerStats>();
            destructibleObject.health -= (1 * PlayerStats.damageMultiplier);
        } else if (enemy != null){
            Destroy(gameObject);
            PlayerStats stats = player.gameObject.GetComponent<PlayerStats>();
            enemy.health -= (1 * PlayerStats.damageMultiplier);
        } else {
            if (collision.tag != "Player") { Destroy(gameObject); } else { player = collision.gameObject; }
        }
    }

}
