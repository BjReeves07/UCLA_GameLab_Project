using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    Rigidbody2D rBody;
    float speed = 3.0f;
    public Vector2 inputDirection;
    public Vector2 lastDirection;
    public SpriteRenderer sRend;

    // Start is called before the first frame update
    void Start()
    {
        rBody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        inputDirection.x = Input.GetAxis("Horizontal");
        inputDirection.y = Input.GetAxis("Vertical");
        if (inputDirection.x != 0)
        {
            lastDirection.x = inputDirection.x;
            if (lastDirection.x < 0)
            {
                sRend.flipX = true;
            }
            else
            {
                sRend.flipX = false;
            }
        }
    }

    private void FixedUpdate()
    {
        Vector2 newPosition = rBody.position + inputDirection * speed * Time.fixedDeltaTime;
        rBody.MovePosition(newPosition);

    }
}
