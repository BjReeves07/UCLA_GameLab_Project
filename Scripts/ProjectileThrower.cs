using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileThrower : MonoBehaviour
{
    public GameObject proj;
    public PlayerMover playerMover;
    
    // Start is called before the first frame update
    void Start()
    {
        PlayerMover playerMover = GetComponent<PlayerMover>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {Thrower();}
    }

    void Thrower()
    {
        GameObject spawned = Instantiate(proj);
        spawned.transform.position = transform.position;
        Projectile projScript = spawned.GetComponent<Projectile>();
        if (playerMover.lastDirection.x < 0)
        {
            projScript.direction = Vector2.left;
        }
        else 
        {
            projScript.direction = Vector2.right;
        }
    }
}
