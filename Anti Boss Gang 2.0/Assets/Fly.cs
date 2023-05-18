using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fly : MonoBehaviour
{
    public float speed = 5f;
    public int move = 0;
    public bool lights = true;
    public bool pl_rt = false;
    public bool pl_lt = false;
    public GameObject en;
    public GameObject lv;
    public TextMesh txt;
    public int text;
    public bool ups;
    public float sec;
    public void Start()
    {
        text = Random.Range(0, 5);
        if (text == 0)
        {
            if (PlayerPrefs.GetInt("Pick") == 0)
            {
                txt.text = "Hi";
                this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(1.413055f, -1.340625f);
                this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(2.82611f, 2.68125f);
            }
            if (PlayerPrefs.GetInt("Pick") >= 1)
            {
                txt.text = PlayerPrefs.GetString("txt1");
            }
        }
        if (text == 1)
        {
            if (PlayerPrefs.GetInt("Pick") == 0)
            {
                txt.text = "bro";
                this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(2.841984f, -1.340625f);
                this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(5.683968f, 2.68125f);
            }
            if (PlayerPrefs.GetInt("Pick") >= 1)
            {
                txt.text = PlayerPrefs.GetString("txt2");
            }
        }
        if (text == 2)
        {
            if (PlayerPrefs.GetInt("Pick") == 0)
            {
                txt.text = "you";
                this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(3.125408f, -1.340625f);
                this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(6.250816f, 2.68125f);
            }
            if (PlayerPrefs.GetInt("Pick") >= 1)
            {
                txt.text = PlayerPrefs.GetString("txt3");
            }

        }
        if (text == 3)
        {
            if (PlayerPrefs.GetInt("Pick") == 0)
            {
                txt.text = "play";
                this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(3.680447f, -1.340625f);
                this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(7.360893f, 2.68125f);
            }
            if (PlayerPrefs.GetInt("Pick") >= 1)
            {
                txt.text = PlayerPrefs.GetString("txt4");
            }
        }
        if (text == 4)
        {
            if (PlayerPrefs.GetInt("Pick") == 0)
            {
                txt.text = "great";
                this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(4.755096f, -1.340625f);
                this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(9.510193f, 2.68125f);
            }
            if (PlayerPrefs.GetInt("Pick") >= 1)
            {
                txt.text = PlayerPrefs.GetString("txt5");
            }
        }
        if (PlayerPrefs.GetInt("Pick") >= 1)
        {
            if (txt.text.Length == 1)
            {
                this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(0.894996f, -1.423918f);
                this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(1.789992f, 2.223129f);
            }
            if (txt.text.Length == 2)
            {
                this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(2.081931f, -1.423918f);
                this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(4.163861f, 2.223129f);
            }
            if (txt.text.Length == 3)
            {
                this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(3.143925f, -1.423918f);
                this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(6.287849f, 2.223129f);
            }
            if (txt.text.Length == 4)
            {
                this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(4.299624f, -1.423918f);
                this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(8.599249f, 2.223129f);
            }
            if (txt.text.Length == 5)
            {
                this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(5.299149f, -1.423918f);
                this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(10.5983f, 2.223129f);
            }
            if (txt.text.Length == 6)
            {
                this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(6.413202f, -1.423918f);
                this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(12.8264f, 2.223129f);
            }
            if (txt.text.Length == 7)
            {
                this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(7.49602f, -1.423918f);
                this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(14.99204f, 2.223129f);
            }
        }
    }
    public void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 2 && sec > 1)
        {
            speed = 5 + (2f / sec);
        }
        if (SceneManager.GetActiveScene().buildIndex > 2 && sec > 1)
        {
            speed = 5 + (sec * 0.02f);
        }
        if (lights == true)
        {
            move = Random.Range(0, 4);
            lights = false;
        }
        if (pl_rt == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, transform.position + -transform.right, speed * Time.deltaTime);
            if (transform.position.x <= 0)
            {
                text = Random.Range(0, 5);
                if (text == 0)
                {
                    if (PlayerPrefs.GetInt("Pick") == 0)
                    {
                        txt.text = "Hi";
                        this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(1.413055f, -1.340625f);
                        this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(2.82611f, 2.68125f);
                    }
                    if (PlayerPrefs.GetInt("Pick") >= 1)
                    {
                        txt.text = PlayerPrefs.GetString("txt1");
                    }
                }
                if (text == 1)
                {
                    if (PlayerPrefs.GetInt("Pick") == 0)
                    {
                        txt.text = "bro";
                        this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(2.841984f, -1.340625f);
                        this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(5.683968f, 2.68125f);
                    }
                    if (PlayerPrefs.GetInt("Pick") >= 1)
                    {
                        txt.text = PlayerPrefs.GetString("txt2");
                    }
                }
                if (text == 2)
                {
                    if (PlayerPrefs.GetInt("Pick") == 0)
                    {
                        txt.text = "you";
                        this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(3.125408f, -1.340625f);
                        this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(6.250816f, 2.68125f);
                    }
                    if (PlayerPrefs.GetInt("Pick") >= 1)
                    {
                        txt.text = PlayerPrefs.GetString("txt3");
                    }

                }
                if (text == 3)
                {
                    if (PlayerPrefs.GetInt("Pick") == 0)
                    {
                        txt.text = "play";
                        this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(3.680447f, -1.340625f);
                        this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(7.360893f, 2.68125f);
                    }
                    if (PlayerPrefs.GetInt("Pick") >= 1)
                    {
                        txt.text = PlayerPrefs.GetString("txt4");
                    }
                }
                if (text == 4)
                {
                    if (PlayerPrefs.GetInt("Pick") == 0)
                    {
                        txt.text = "great";
                        this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(4.755096f, -1.340625f);
                        this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(9.510193f, 2.68125f);
                    }
                    if (PlayerPrefs.GetInt("Pick") >= 1)
                    {
                        txt.text = PlayerPrefs.GetString("txt5");
                    }
                }
                if (PlayerPrefs.GetInt("Pick") == 1)
                {
                    if (txt.text.Length == 1)
                    {
                        this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(0.894996f, -1.423918f);
                        this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(1.789992f, 2.223129f);
                    }
                    if (txt.text.Length == 2)
                    {
                        this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(2.081931f, -1.423918f);
                        this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(4.163861f, 2.223129f);
                    }
                    if (txt.text.Length == 3)
                    {
                        this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(3.143925f, -1.423918f);
                        this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(6.287849f, 2.223129f);
                    }
                    if (txt.text.Length == 4)
                    {
                        this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(4.299624f, -1.423918f);
                        this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(8.599249f, 2.223129f);
                    }
                    if (txt.text.Length == 5)
                    {
                        this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(5.299149f, -1.423918f);
                        this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(10.5983f, 2.223129f);
                    }
                    if (txt.text.Length == 6)
                    {
                        this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(6.413202f, -1.423918f);
                        this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(12.8264f, 2.223129f);
                    }
                    if (txt.text.Length == 7)
                    {
                        this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(7.49602f, -1.423918f);
                        this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(14.99204f, 2.223129f);
                    }
                }
                lights = true;
                transform.position = new Vector2(en.transform.position.x, 9.5f);
                pl_rt = false;
            }
        }
        if (pl_lt == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, transform.position + transform.right, speed * Time.deltaTime);
            if (transform.position.x >= 0)
            {
                text = Random.Range(0, 5);
                if (text == 0)
                {
                    if (PlayerPrefs.GetInt("Pick") == 0)
                    {
                        txt.text = "Hi";
                        this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(1.413055f, -1.340625f);
                        this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(2.82611f, 2.68125f);
                    }
                    if (PlayerPrefs.GetInt("Pick") == 1)
                    {
                        txt.text = PlayerPrefs.GetString("txt1");
                    }
                }
                if (text == 1)
                {
                    if (PlayerPrefs.GetInt("Pick") == 0)
                    {
                        txt.text = "bro";
                        this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(2.841984f, -1.340625f);
                        this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(5.683968f, 2.68125f);
                    }
                    if (PlayerPrefs.GetInt("Pick") == 1)
                    {
                        txt.text = PlayerPrefs.GetString("txt2");
                    }
                }
                if (text == 2)
                {
                    if (PlayerPrefs.GetInt("Pick") == 0)
                    {
                        txt.text = "you";
                        this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(3.125408f, -1.340625f);
                        this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(6.250816f, 2.68125f);
                    }
                    if (PlayerPrefs.GetInt("Pick") == 1)
                    {
                        txt.text = PlayerPrefs.GetString("txt3");
                    }

                }
                if (text == 3)
                {
                    if (PlayerPrefs.GetInt("Pick") == 0)
                    {
                        txt.text = "play";
                        this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(3.680447f, -1.340625f);
                        this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(7.360893f, 2.68125f);
                    }
                    if (PlayerPrefs.GetInt("Pick") == 1)
                    {
                        txt.text = PlayerPrefs.GetString("txt4");
                    }
                }
                if (text == 4)
                {
                    if (PlayerPrefs.GetInt("Pick") == 0)
                    {
                        txt.text = "great";
                        this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(4.755096f, -1.340625f);
                        this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(9.510193f, 2.68125f);
                    }
                    if (PlayerPrefs.GetInt("Pick") == 1)
                    {
                        txt.text = PlayerPrefs.GetString("txt5");
                    }
                }
                if (PlayerPrefs.GetInt("Pick") == 1)
                {
                    if (txt.text.Length == 1)
                    {
                        this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(0.894996f, -1.423918f);
                        this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(1.789992f, 2.223129f);
                    }
                    if (txt.text.Length == 2)
                    {
                        this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(2.081931f, -1.423918f);
                        this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(4.163861f, 2.223129f);
                    }
                    if (txt.text.Length == 3)
                    {
                        this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(3.143925f, -1.423918f);
                        this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(6.287849f, 2.223129f);
                    }
                    if (txt.text.Length == 4)
                    {
                        this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(4.299624f, -1.423918f);
                        this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(8.599249f, 2.223129f);
                    }
                    if (txt.text.Length == 5)
                    {
                        this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(5.299149f, -1.423918f);
                        this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(10.5983f, 2.223129f);
                    }
                    if (txt.text.Length == 6)
                    {
                        this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(6.413202f, -1.423918f);
                        this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(12.8264f, 2.223129f);
                    }
                    if (txt.text.Length == 7)
                    {
                        this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(7.49602f, -1.423918f);
                        this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(14.99204f, 2.223129f);
                    }
                }
                lights = true;
                transform.position = new Vector2(en.transform.position.x, 9.5f);
                pl_lt = false;
            }
        }
        if (move == 0)
        {
            transform.position = Vector3.MoveTowards(transform.position, transform.position + transform.right, speed * Time.deltaTime);
            if (transform.position.x >= 9 && ups == false)
            {
                transform.position = new Vector2(9, 1.6f);
                pl_rt = true;
                move = -1;
            }
            if (transform.position.x >= 9 && ups == true)
            {
                transform.position = new Vector2(9, 4.4f);
                pl_rt = true;
                move = -1;
            }
        }
        if (move == 2)
        {
            transform.position = Vector3.MoveTowards(transform.position, transform.position + transform.right, speed * Time.deltaTime);
            if (transform.position.x >= 9 && ups == false)
            {
                transform.position = new Vector2(9, 1.6f);
                pl_rt = true;
                move = -1;
            }
            if (transform.position.x >= 9 && ups == true)
            {
                transform.position = new Vector2(9, 4.4f);
                pl_rt = true;
                move = -1;
            }
        }
        if (move == 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, transform.position + -transform.right, speed * Time.deltaTime);
            if (transform.position.x <= -9 && ups == false)
            {
                transform.position = new Vector2(-9, 1.6f);
                pl_lt = true;
                move = -1;
            }
            if (transform.position.x <= -9 && ups == true)
            {
                transform.position = new Vector2(9, 4.4f);
                pl_rt = true;
                move = -1;
            }
        }
        if (move == 3)
        {
            transform.position = Vector3.MoveTowards(transform.position, transform.position + -transform.right, speed * Time.deltaTime);
            if (transform.position.x <= -9 && ups == false)
            {
                transform.position = new Vector2(-9, 1.6f);
                pl_lt = true;
                move = -1;

            }
            if (transform.position.x <= -9 && ups == true)
            {
                transform.position = new Vector2(9, 4.4f);
                pl_rt = true;
                move = -1;
            }
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
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
}
