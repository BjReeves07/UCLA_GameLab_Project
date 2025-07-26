using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyProjectile : MonoBehaviour
{
    public Vector2 direction = Vector2.right;
    public Rigidbody2D projectileRB;
    public float speed = 8.0f;
    //public GameObject player;
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
       

        if (collision.tag == "Player") 
        {
            PlayerStats stats = collision.gameObject.GetComponent<PlayerStats>();
            stats.health--;
            Destroy(gameObject); 
        } 

    }

}
