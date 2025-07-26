using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public int health = 5;
    public static int maxHealth = 5;
    public Text label;
    public Text label2;
    public static float damageMultiplier = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
     
        
    }

    // Update is called once per frame
    void Update()
    {
        label.text = "Health: " + health + " / " + maxHealth;
        label2.text = "Damage Multiplier: " + damageMultiplier;

        if(health<=0)
        {
            SceneManager.LoadScene("Game Over");
        }
    }
}
