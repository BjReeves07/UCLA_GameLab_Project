using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCode : MonoBehaviour
{
    public Rigidbody2D playerRb;

    Rigidbody2D enemyRb;

    public float speed = 3;
    public float followRange = 5;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Vector2 difference = playerRb.position - enemyRb.position;

        float distance = difference.magnitude;

        if (distance < followRange)
        {
            Vector2 moveDirection = difference.normalized;
            Vector2 newPosition = enemyRb.position + moveDirection * speed * Time.fixedDeltaTime;
            enemyRb.MovePosition(newPosition);
        }

    }
}
