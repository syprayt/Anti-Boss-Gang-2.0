using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Concrete : MonoBehaviour
{
    public bool drp;
    public GameObject Player;
    public GameObject concr;
    public bool popal = false;
    public int clicks = 0;
    public Button bt;
    public Sprite[] ds;
    public void Update()
    {
        if (drp == false)
        {
            this.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0.3f;
            this.gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            this.gameObject.transform.position = new Vector3(Random.Range(-9, 9), 7, 1);
            drp = true;
        }
        if(popal == true)
        {
            if (Input.GetButton("Vertical"))
            {
                Click();
            }
            if(clicks == 0) 
            {
                concr.GetComponent<SpriteRenderer>().sprite = ds[0];
            }
            else if (clicks == 2)
            {
                concr.GetComponent<SpriteRenderer>().sprite = ds[1];
            }
            else if (clicks == 4)
            {
                concr.GetComponent<SpriteRenderer>().sprite = ds[2];
            }
            else if (clicks == 6)
            {
                concr.GetComponent<SpriteRenderer>().sprite = ds[3];
            }
            if (clicks < 7) 
            {
                Player.GetComponent<Move>().enabled = false;
                concr.SetActive(true);
                bt.GetComponent<JumpButtonController>().button.onClick.RemoveAllListeners();
                bt.onClick.AddListener(Click);
            }
            else
            {
                Player.GetComponent<Move>().enabled = true;
                concr.SetActive(false);
                clicks = 0;
                bt.GetComponent<JumpButtonController>().button.onClick.RemoveAllListeners();
                bt.GetComponent<JumpButtonController>().Start();
                StartCoroutine(wait());
                popal = false;
            }
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Land") StartCoroutine(wait());
        if(collision.tag == "Player") popal = true;
    }
    public void Click()
    {
        clicks++;
    }
    IEnumerator wait()
    {
        this.gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        this.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
        this.gameObject.transform.position = new Vector3(50, 0, 1);
        yield return new WaitForSeconds(1);
        drp = false;
    }
}
