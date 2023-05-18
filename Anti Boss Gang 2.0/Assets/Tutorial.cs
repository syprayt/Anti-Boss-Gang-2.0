using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    public float speed = 3f;
    public GameObject tp;
    public GameObject Enemy;
    public bool fl;
    public GameObject drop;
    public int mv = 0;
    public GameObject Text;
    public GameObject[] meteors;
    public TextMesh txt;
    public GameObject ln;
    public GameObject tt;
    public Camera cam;
    public bool dei;
    public GameObject Button;
    public GameObject Compl;
    public GameObject[] pauses;
    public AudioSource au;
    public AudioClip sound;
    public bool moffon;
    public Font[] ft;
    public Text[] lng;
    public void Start()
    {
        Time.timeScale = 1;
        if (PlayerPrefs.GetInt("Language") == 0)
        {
            lng[0].text = "Resume";
            lng[1].text = "Back to lobby";
            lng[0].font = ft[0];
            lng[1].font = ft[0];
        }
        if (PlayerPrefs.GetInt("Language") == 1)
        {
            lng[0].text = "Wznawiać";
            lng[1].text = "Powrót do holu";
            lng[0].font = ft[1];
            lng[1].font = ft[1];
        }
        if (PlayerPrefs.GetInt("Language") == 2)
        {
            lng[0].text = "Перезавантажити";
            lng[1].text = "Назад до хабу";
            lng[0].font = ft[2];
            lng[1].font = ft[2];
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        transform.position = new Vector2(0, -10);
        this.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
        mv += 1;
        fl = true;
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(3);
        }
    }
    public void Update()
    {
        if (moffon == false && PlayerPrefs.GetInt("Sound") == 0)
        {
            StartCoroutine(wait());
        }
        if (mv == 1)
        {
            ln.SetActive(false);
            Enemy.transform.position += (tp.transform.position - Enemy.transform.position).normalized * speed * Time.deltaTime;
        }
        if ((tp.transform.position - Enemy.transform.position).sqrMagnitude < 0.01f && mv == 1)
        {
            ln.transform.position = new Vector2(-6, ln.transform.position.y);
            ln.SetActive(true);
            this.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0.1f;
            this.transform.position = new Vector2(Enemy.transform.position.x - 1, 9);

            Text.transform.position = new Vector2(Enemy.transform.position.x + 0.6f, 9);
            mv += 1;
        }
        if (mv == 3)
        {
            ln.transform.position = new Vector2(-1, ln.transform.position.y);
            Text.SetActive(true);
            Text.transform.position = Vector2.MoveTowards(Text.transform.position, Text.transform.position + Text.transform.right, speed * Time.deltaTime);
            if (Text.transform.position.x >= 9)
            {
                Text.transform.position = new Vector2(9, 1.4f);
                mv += 1;
            }
        }
        if (mv == 4)
        {
            Text.transform.position = Vector2.MoveTowards(Text.transform.position, Text.transform.position - Text.transform.right, speed * Time.deltaTime);
            if (Text.transform.position.x <= 0)
            {
                Text.SetActive(false);
                mv += 1;
            }
        }
        if (mv == 5 && dei == false)
        {
            ln.SetActive(false);
            tp.transform.position = new Vector2(0, 9);
            Enemy.transform.position += (tp.transform.position - Enemy.transform.position).normalized * speed * Time.deltaTime;
            if ((tp.transform.position - Enemy.transform.position).sqrMagnitude < 0.01f && mv == 5)
            {
                cam.backgroundColor = new Color32(125, 6, 0, 0);
                ln.SetActive(false);
                ln.transform.position = new Vector2(4, ln.transform.position.y);
                tt.SetActive(true);
                dei = true;
                StartCoroutine(boss());
            }
        }
        if (mv == 6 && fl == true)
        {
            meteors[0] = Instantiate(this.gameObject);
            meteors[1] = Instantiate(this.gameObject);
            meteors[0].GetComponent<Tutorial>().mv = -100;
            meteors[1].GetComponent<Tutorial>().mv = -100;
            this.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0.1f;
            meteors[0].gameObject.GetComponent<Rigidbody2D>().gravityScale = 0.1f;
            meteors[1].gameObject.GetComponent<Rigidbody2D>().gravityScale = 0.1f;
            transform.position = new Vector2(0, 9);
            meteors[0].transform.position = new Vector2(4, 9);
            meteors[1].transform.position = new Vector2(-4, 9);
            fl = false;
        }
        if (mv == 7 && fl == true)
        {
            this.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0.1f;
            meteors[0].gameObject.GetComponent<Rigidbody2D>().gravityScale = 0.1f;
            meteors[1].gameObject.GetComponent<Rigidbody2D>().gravityScale = 0.1f;
            transform.position = new Vector2(-8, 9);
            meteors[0].transform.position = new Vector2(7, 9);
            meteors[1].transform.position = new Vector2(-3, 9);
            fl = false;
        }
        if (mv == 8 && fl == true)
        {
            this.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0.1f;
            meteors[0].gameObject.GetComponent<Rigidbody2D>().gravityScale = 0.1f;
            meteors[1].gameObject.GetComponent<Rigidbody2D>().gravityScale = 0.1f;
            transform.position = new Vector2(5, 9);
            meteors[0].transform.position = new Vector2(3, 9);
            meteors[1].transform.position = new Vector2(1, 9);
            fl = false;
        }
        if (mv == 9 && fl == true)
        {
            this.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0.1f;
            meteors[0].gameObject.GetComponent<Rigidbody2D>().gravityScale = 0.1f;
            meteors[1].gameObject.GetComponent<Rigidbody2D>().gravityScale = 0.1f;
            transform.position = new Vector2(-2, 9);
            meteors[0].transform.position = new Vector2(8, 9);
            meteors[1].transform.position = new Vector2(1, 9);
            fl = false;
        }
        if (mv > 9)
        {
            ln.SetActive(false);
            Button.SetActive(true);
            Compl.SetActive(true);
        }
    }
    IEnumerator boss()
    {
        yield return new WaitForSeconds(2);
        mv += 1;
        tt.SetActive(false);
        ln.SetActive(true);
    }
    public void Lobby()
    {
        SceneManager.LoadScene(1);
    }
    public void Pause()
    {
        pauses[0].SetActive(true);
        pauses[1].SetActive(true);
        Time.timeScale = 0;
    }
    public void Resume()
    {
        pauses[0].SetActive(false);
        pauses[1].SetActive(false);
        Time.timeScale = 1;
    }
    public void GTL()
    {
        SceneManager.LoadScene(1);
    }
    IEnumerator wait()
    {
        moffon = true;
        au.clip = sound;
        au.Play();
        yield return new WaitForSeconds(123);
        moffon = false;
    }
}
