using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TestScript : MonoBehaviour
{
     public int health = 0;
     public string myName = "";
     public float speed = 0.0f;
    public bool hasGlasses;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Your game is broke");
        Debug.Log(myName + " has " + health + " health");

        if (hasGlasses)
        {
            Debug.Log("bro is super epic");
        }
        else
        {
            Debug.Log("get some glasses");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (health >= 0 || health == -3)
        {
            Debug.Log("victory royale");
            health -= 600;
        }
        else
        {
            Debug.Log("YOU FAILED");
            health += 600;
        }
    }


}
