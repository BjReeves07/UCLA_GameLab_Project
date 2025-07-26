using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyDestroy : MonoBehaviour
{
    public float health;
    public bool isAnimated;
    public int phase2Health;
    public bool isBoss = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health == 0)
        {
            GameObject.Destroy(gameObject);   
            if (isBoss)
            {
                SceneManager.LoadScene("Win");
            }
        }

    }
}
