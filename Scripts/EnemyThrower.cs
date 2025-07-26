using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EnemyThrower : MonoBehaviour
{
    public GameObject proj;
    public Rigidbody2D enemy;
    public Rigidbody2D target;
    public float timer = 2;
    float countTimer = 0;

    // Start is called before the first frame update
    void Start()
    {
       enemy = GetComponent<Rigidbody2D>();
        countTimer = timer;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(countTimer<=0)
        {
            Thrower();
            countTimer = timer;
        }
        else
        {
            countTimer -= Time.deltaTime;    
        }
    }

    void Thrower()
    {
        GameObject spawned = Instantiate(proj);
        spawned.transform.position = transform.position;
        enemyProjectile projScript = spawned.GetComponent<enemyProjectile>();
        Vector2 aim = target.position - enemy.position;
        projScript.direction = aim.normalized;
       
    }
}
