using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lava : MonoBehaviour
{
    public bool flood;
    public float speed = 1f;
    public bool ups = true;
    public GameObject lv;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && SceneManager.GetActiveScene().buildIndex == 2)
        {
            lv.GetComponent<Levels>().wol = true;
        }
        if (other.gameObject.tag == "Player" && SceneManager.GetActiveScene().buildIndex == 4)
        {
            lv.GetComponent<NeverEnd>().wol = true;
        }
        if (other.gameObject.tag == "Player" && SceneManager.GetActiveScene().buildIndex == 5)
        {
            lv.GetComponent<NeverEnd>().wol = true;
        }
    }
    public void Update()
    {
        if (flood == true)
        {
            if (ups == true)
            {
                transform.position = Vector2.MoveTowards(transform.position, transform.position + transform.up, speed * Time.deltaTime);
            }
            if (transform.position.y >= 0 && ups == true)
            {
                ups = false;
            }
        }
        if (flood == false)
        {
            if (ups == false)
            {
                transform.position = Vector2.MoveTowards(transform.position, transform.position - transform.up, speed * Time.deltaTime);
            }
            if (transform.position.y <= -1.5 && ups == false)
            {
                this.gameObject.SetActive(false);
                ups = true;
            }
        }
    }
}
