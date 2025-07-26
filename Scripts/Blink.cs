using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour
{
    public SpriteRenderer sRend;
    public Color baseColor = Color.cyan;
    public Color changeColor = Color.black;

    // Start is called before the first frame update
    void Start()
    {
        //sRend = gameObject.GetComponent<SpriteRenderer>();
        sRend.color = changeColor;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            sRend.color = changeColor;
        }
        else
        {
            sRend.color = baseColor;
        }
    }
}
