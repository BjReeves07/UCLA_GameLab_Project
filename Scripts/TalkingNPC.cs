using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalkingNPC : MonoBehaviour
{
    GameObject NPCText;
    public TextMesh label;
    public string saying1;
    public string saying2;
    public string saying3;

    // Start is called before the first frame update
    void Start()
    {
        NPCText = transform.GetChild(0).gameObject;

        NPCText.SetActive(false);

        // Victim = Chris.GetChild();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {

            StopAllCoroutines();
            StartCoroutine(delayedTextChange());
        }
        
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        NPCText.SetActive(false);
    }

    IEnumerator delayedTextChange()
    {
        NPCText.SetActive(true);
        label.text = saying1;
        yield return new WaitForSeconds(2);
        label.text = saying2;
        yield return new WaitForSeconds(2);
        label.text = saying3;
        yield return new WaitForSeconds(2);
        NPCText.SetActive(false);
    }
}
