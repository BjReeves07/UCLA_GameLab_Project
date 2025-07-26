using UnityEngine;

public class BossMove : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 direction = Vector2.right;
    public float speed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();


        direction = Vector2.down;
        direction = Vector2.up;

        speed = Random.Range(2f, 6f);

    }
    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        Vector2 newPosition = rb.position + direction * speed * Time.fixedDeltaTime;
        rb.MovePosition(newPosition);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        direction *= -1;
    }
}
