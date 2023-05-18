using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Drop : MonoBehaviour
{
    public GameObject spwn;
    public bool pd;
    public GameObject en;
    public bool tr = true;
    public GameObject lv;
    public bool meteor = false;
    public bool nmt = false;
    public GameObject[] meteors;
    public Camera cam;
    public bool fly;
    public bool chg;
    public float sec;
    public GameObject rw;
    public bool im;
    public Sprite[] drops;
    public int boss;
    public bool Rage;
    public void Start()
    {
        rw = GameObject.Find("SD");
        if (rw != null)
        {
            im = true;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = rw.GetComponent<SpriteRenderer>().sprite;
            this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(0.25f, 0.25f);
            this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(1f, 1f);
            rw.SetActive(false);
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Land")
        {
            this.gameObject.transform.position = new Vector2(Random.Range(-9, 9), 9);
            tr = true;
            pd = true;
        }
        if (collision.gameObject.tag == "Player" && SceneManager.GetActiveScene().buildIndex == 2)
        {
            lv.GetComponent<Levels>().wol = true;
        }
        if (collision.gameObject.tag == "Player" && SceneManager.GetActiveScene().buildIndex == 4)
        {
            lv.GetComponent<NeverEnd>().wol = true;
        }
        if (collision.gameObject.tag == "Player" && SceneManager.GetActiveScene().buildIndex == 5)
        {
            lv.GetComponent<Boss_Defeat>().wol = true;
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Land")
        {
            if (nmt == false && fly == false)
            {
                en.GetComponent<Enemy>().kdt = true;
                spwn.SetActive(false);
                tr = true;
                this.gameObject.transform.position = new Vector2(0, 9);
            }
            if (nmt == true && fly == false)
            {
                tr = true;
                pd = true;
            }
        }
        if (collision.gameObject.tag == "Player" && SceneManager.GetActiveScene().buildIndex == 2)
        {
            lv.GetComponent<Levels>().wol = true;
        }
        if (collision.gameObject.tag == "Player" && SceneManager.GetActiveScene().buildIndex == 4)
        {
            lv.GetComponent<NeverEnd>().wol = true;
        }
        if (collision.gameObject.tag == "Player" && SceneManager.GetActiveScene().buildIndex == 5)
        {
            lv.GetComponent<Boss_Defeat>().wol = true;
        }
    }
    public void Update()
    {
        if (boss == 1 && im == false)
        {
            this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(-0.2f, -0.3f);
            this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(2.3f, 2f);
            this.gameObject.GetComponent<SpriteRenderer>().sprite = drops[0];
            this.gameObject.transform.localScale = new Vector3(0.4f, 0.4f, 1);
        }
        if (boss == 2 && im == false && Rage == false)
        {
            this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(-0.07503504f, -0.6987648f);
            this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(0.8874475f, 0.8593063f);
            this.gameObject.GetComponent<SpriteRenderer>().sprite = drops[1];
            this.gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 1);
        }
        if (boss == 2 && im == false && Rage == true)
        {
            this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(-0.07503504f, -0.7060804f);
            this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(1.092293f, 1.078783f);
            this.gameObject.GetComponent<SpriteRenderer>().sprite = drops[2];
            this.gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 1);
        }
        if (boss == 3 && im == false)
        {
            this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(0.08577597f, -0.2328199f);
            this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(0.8039405f, 1.073521f);
            this.gameObject.GetComponent<SpriteRenderer>().sprite = drops[3];
            this.gameObject.transform.localScale = new Vector3(0.8f, 0.8f, 1);
        }
        if (SceneManager.GetActiveScene().buildIndex == 2 && fly == false && sec > 1)
        {
            this.gameObject.GetComponent<Rigidbody2D>().gravityScale = 1 + (2f / sec);
        }
        if (SceneManager.GetActiveScene().buildIndex > 2 && fly == false && sec > 1)
        {
            this.gameObject.GetComponent<Rigidbody2D>().gravityScale = 1 + (sec * 0.02f);
        }
        if (meteor == true)
        {
            meteors[0] = Instantiate(this.gameObject);
            meteors[1] = Instantiate(this.gameObject);
            meteors[2] = Instantiate(this.gameObject);
            meteors[3] = Instantiate(this.gameObject);
            meteors[0].GetComponent<Rigidbody2D>().gravityScale = Random.Range(0.5f, 2f);
            meteors[1].GetComponent<Rigidbody2D>().gravityScale = Random.Range(0.5f, 2f);
            meteors[2].GetComponent<Rigidbody2D>().gravityScale = Random.Range(0.5f, 2f);
            meteors[3].GetComponent<Rigidbody2D>().gravityScale = Random.Range(0.5f, 2f);
            meteors[0].GetComponent<BoxCollider2D>().isTrigger = false;
            meteors[1].GetComponent<BoxCollider2D>().isTrigger = false;
            meteors[2].GetComponent<BoxCollider2D>().isTrigger = false;
            meteors[3].GetComponent<BoxCollider2D>().isTrigger = false;
            this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
            meteors[0].GetComponent<Drop>().meteor = false;
            meteors[1].GetComponent<Drop>().meteor = false;
            meteors[2].GetComponent<Drop>().meteor = false;
            meteors[3].GetComponent<Drop>().meteor = false;
            if (SceneManager.GetActiveScene().buildIndex == 2)
            {
                lv.GetComponent<Levels>().meteoru[0] = meteors[0];
                lv.GetComponent<Levels>().meteoru[1] = meteors[1];
                lv.GetComponent<Levels>().meteoru[2] = meteors[2];
                lv.GetComponent<Levels>().meteoru[3] = meteors[3];
            }
            if (SceneManager.GetActiveScene().buildIndex == 4)
            {
                lv.GetComponent<NeverEnd>().meteoru[0] = meteors[0];
                lv.GetComponent<NeverEnd>().meteoru[1] = meteors[1];
                lv.GetComponent<NeverEnd>().meteoru[2] = meteors[2];
                lv.GetComponent<NeverEnd>().meteoru[3] = meteors[3];
            }
            if (SceneManager.GetActiveScene().buildIndex == 5)
            {
                lv.GetComponent<Boss_Defeat>().meteoru[0] = meteors[0];
                lv.GetComponent<Boss_Defeat>().meteoru[1] = meteors[1];
                lv.GetComponent<Boss_Defeat>().meteoru[2] = meteors[2];
                lv.GetComponent<Boss_Defeat>().meteoru[3] = meteors[3];
            }
            meteors[0].GetComponent<Drop>().nmt = true;
            meteors[1].GetComponent<Drop>().nmt = true;
            meteors[2].GetComponent<Drop>().nmt = true;
            meteors[3].GetComponent<Drop>().nmt = true;
            meteors[0].GetComponent<Drop>().pd = true;
            meteors[1].GetComponent<Drop>().pd = true;
            meteors[2].GetComponent<Drop>().pd = true;
            meteors[3].GetComponent<Drop>().pd = true;
            meteors[0].SetActive(true);
            meteors[1].SetActive(true);
            meteors[2].SetActive(true);
            meteors[3].SetActive(true);
            StartCoroutine(mr());
            nmt = true;
            meteor = false;
        }
        if (pd == true && tr == true && nmt == false && fly == true)
        {
            this.gameObject.transform.position = new Vector2(Random.Range(-9, 9), 0);
            this.gameObject.transform.rotation = Quaternion.Euler(0, 0, 180);
            tr = false;
            pd = false;
        }
        if (pd == true && tr == true && nmt == true && fly == false)
        {
            this.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
            this.gameObject.transform.position = new Vector2(Random.Range(-9, 9), 9);
            tr = false;
            pd = false;
        }
        if (pd == true && tr == true && nmt == false && fly == false)
        {
            spwn.transform.position = new Vector2(en.transform.position.x, 9);
            this.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
            tr = false;
            pd = false;
        }
        if (transform.position.y < -1 && nmt == false && fly == false)
        {
            en.GetComponent<Enemy>().kdt = true;
            spwn.SetActive(false);
            tr = true;
            this.gameObject.transform.position = new Vector2(0, 9);
        }
        if (transform.position.y < -1 && nmt == true && fly == false)
        {
            this.gameObject.transform.position = new Vector2(Random.Range(-9, 9), 9);
            tr = true;
            pd = true;
        }
        if (transform.position.y > 5 && nmt == false && fly == true)
        {
            this.gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            this.gameObject.GetComponent<Rigidbody2D>().gravityScale = 2;
            this.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
            this.gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            chg = true;
        }
        if (transform.position.y <= 0 && chg == true)
        {
            tr = true;
            pd = true;
            this.gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            this.gameObject.GetComponent<Rigidbody2D>().gravityScale = -2;
            this.gameObject.transform.rotation = Quaternion.Euler(0, 0, 180);
            this.gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            chg = false;
        }
    }
    IEnumerator mr()
    {
        yield return new WaitForSeconds(5);
        Destroy(meteors[0]);
        Destroy(meteors[1]);
        Destroy(meteors[2]);
        Destroy(meteors[3]);
        this.gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
        en.GetComponent<Enemy>().Rage = false;
        cam.backgroundColor = new Color32(49, 77, 121, 0);
        meteor = false;
        nmt = false;
    }
}
