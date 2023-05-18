using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public bool mv = true;
    public bool rd = true;
    public float ps;
    public float speed = 6f;
    public GameObject tp;
    public GameObject dr;
    public float sec;
    public Animator anim;
    public float horizontalmove;
    public int boss;
    public bool Rage;
    public bool Stra;
    public GameObject rw;
    public bool im = false;
    public bool ons = false;
    public bool kdt = false;
    public void Start()
    {
        rw = GameObject.Find("SE");
        if (rw != null)
        {
            im = true;
            this.gameObject.GetComponent<Animator>().enabled = false;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = rw.GetComponent<SpriteRenderer>().sprite;
            this.gameObject.transform.localScale = new Vector3(1, 1, 1);
            this.gameObject.transform.position = new Vector3(transform.position.x, 8.35f, 1);
            rw.SetActive(false);
        }
    }
    public void Awake()
    {
        anim.GetComponent<Animator>();
    }
    public void Update()
    {
        if ((tp.transform.position - transform.position).magnitude < 0.7f)
        {
            StartCoroutine(thr());
        }
        if ((tp.transform.position - transform.position).magnitude < 0.2f)
        {
            dr.GetComponent<Drop>().pd = true;
            dr.SetActive(true);
            rd = true;
        }
        else
        {
            transform.position += (tp.transform.position - transform.position).normalized * speed * Time.deltaTime;
        }
        if (boss == 1 && im == false && ons == false)
        {
            this.gameObject.transform.position = new Vector3(transform.position.x, 9.5f, 1);
            this.gameObject.transform.localScale = new Vector3(0.6f, 0.6f, 1);
            ons = true;
        }
        if (boss == 2 && im == false && ons == false)
        {
            this.gameObject.transform.position = new Vector3(transform.position.x, 9.65f, 1);
            this.gameObject.transform.localScale = new Vector3(0.6f, 0.6f, 1);
            ons = true;
        }
        if (boss == 3 && im == false && ons == false)
        {
            this.gameObject.transform.position = new Vector3(transform.position.x, 9.05f, 1);
            this.gameObject.transform.localScale = new Vector3(0.7f, 0.7f, 1);
            ons = true;
        }
        if (rd == true)
        {
            if (im == true)
            {
                ps = Random.Range(-9, 9);
                tp.transform.position = new Vector2(ps, 8.30f);
                rd = false;
            }
            else if (boss == 1 && im == false)
            {
                ps = Random.Range(-9, 9);
                tp.transform.position = new Vector2(ps, 9.45f);
                rd = false;
            }
            else if (boss == 2 && im == false)
            {
                ps = Random.Range(-9, 9);
                tp.transform.position = new Vector2(ps, 9.55f);
                rd = false;
            }
            else if (boss == 2 && im == false && Rage == true && Stra == false)
            {
                ps = Random.Range(-9, 9);
                tp.transform.position = new Vector2(ps, 9.60f);
                rd = false;
            }
            else if (boss == 3 && im == false && Rage == false)
            {
                ps = Random.Range(-9, 9);
                tp.transform.position = new Vector2(ps, 9f);
                rd = false;
            }
            else if (boss == 3 && im == false && Rage == true && Stra == false)
            {
                ps = Random.Range(-9, 9);
                tp.transform.position = new Vector2(ps, 9.45f);
                rd = false;
            }
        }
        if (boss == 1 && im == false)
        {
            anim.SetInteger("Boss", 1);
        }
        else if (boss == 2 && im == false)
        {
            anim.SetInteger("Boss", 2);
        }
        else if (boss == 3 && im == false)
        {
            anim.SetInteger("Boss", 3);
        }
        if (boss == 1 && Rage == true && Stra == true && im == false)
        {
            anim.SetInteger("Boss", 1);
            anim.SetBool("Start_Rage", true);
        }
        else if (boss == 1 && Rage == false && Stra == false && im == false)
        {
            anim.SetInteger("Boss", 1);
            anim.SetBool("Rage", false);
            horizontalmove = (tp.transform.position.x - transform.position.x) * speed * Time.deltaTime;
            anim.SetFloat("Speed", Mathf.Abs(horizontalmove));
        }
        else if (boss == 1 && Rage == true && Stra == false && im == false)
        {
            anim.SetInteger("Boss", 1);
            anim.SetBool("Rage", true);
            horizontalmove = (tp.transform.position.x - transform.position.x) * speed * Time.deltaTime;
            anim.SetFloat("Speed", Mathf.Abs(horizontalmove));
            anim.SetBool("Start_Rage", false);
        }
        if (boss == 2 && Rage == true && Stra == true && im == false)
        {
            anim.SetInteger("Boss", 2);
            anim.SetBool("Start_Rage", true);
        }
        else if (boss == 2 && Rage == false && Stra == false && im == false)
        {
            anim.SetInteger("Boss", 2);
            anim.SetBool("Rage", false);
            horizontalmove = (tp.transform.position.x - transform.position.x) * speed * Time.deltaTime;
            anim.SetFloat("Speed", Mathf.Abs(horizontalmove));
        }
        else if (boss == 2 && Rage == true && Stra == false && im == false)
        {
            anim.SetInteger("Boss", 2);
            anim.SetBool("Rage", true);
            horizontalmove = (tp.transform.position.x - transform.position.x) * speed * Time.deltaTime;
            anim.SetFloat("Speed", Mathf.Abs(horizontalmove));
            anim.SetBool("Start_Rage", false);
        }
        if (boss == 3 && Rage == true && Stra == true && im == false)
        {
            anim.SetInteger("Boss", 3);
            anim.SetBool("Start_Rage", true);
        }
        else if (boss == 3 && Rage == false && Stra == false && im == false)
        {
            anim.SetInteger("Boss", 3);
            this.gameObject.transform.localScale = new Vector3(0.7f, 0.7f, 1);
            anim.SetBool("Rage", false);
            horizontalmove = (tp.transform.position.x - transform.position.x) * speed * Time.deltaTime;
            anim.SetFloat("Speed", Mathf.Abs(horizontalmove));
        }
        else if (boss == 3 && Rage == true && Stra == false && im == false)
        {
            anim.SetInteger("Boss", 3);
            this.gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 1);
            anim.SetBool("Rage", true);
            horizontalmove = (tp.transform.position.x - transform.position.x) * speed * Time.deltaTime;
            anim.SetFloat("Speed", Mathf.Abs(horizontalmove));
            anim.SetBool("Start_Rage", false);
        }
        if (SceneManager.GetActiveScene().buildIndex == 2 && sec > 1)
        {
            speed = 6 + (2 / sec);
        }
        else if (SceneManager.GetActiveScene().buildIndex > 2 && sec > 1)
        {
            speed = 6 + (sec * 0.02f);
        }
    }
    IEnumerator thr()
    {
        if (kdt == true)
        {
            anim.SetBool("Throw", true);
            yield return new WaitForSeconds(0.2f);
            anim.SetBool("Throw", false);
            kdt = false;
        }
    }
}
