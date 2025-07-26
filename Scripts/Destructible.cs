using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour
{
    public float health;
    public bool isAnimated;
    public int phase2Health;
    public GameObject coin;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            GameObject.Destroy(gameObject);
            if (Mathf.Round(Random.Range(0,6)) == 1) 
            {
                GameObject spawned = Instantiate(coin);
                spawned.transform.position = transform.position;
            }
            
        }
        if (health <= phase2Health)
        {

        }
    }
}
