using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{
    public Joystick js;
    public Rigidbody2D rb;
    public float speed = 6f;
    public float jumpForce = 31f;
    public bool isGrounded;
    public SpriteRenderer sprite;
    public Button bt;
    public GameObject Levels;
    public float sec;
    public Sprite[] Skins;
    public Animator anim;
    public float horizontalmove;
    public int mv2;
    public GameObject[] cpo;
    public GameObject rw;
    public bool im;
    public void Start()
    {
        cpo[1].transform.localPosition = new Vector3(PlayerPrefs.GetFloat("JBX"), PlayerPrefs.GetFloat("JBY"), 0);
        cpo[0].transform.localPosition = new Vector3(PlayerPrefs.GetFloat("FJX"), PlayerPrefs.GetFloat("FJY"), 0);
        rw = GameObject.Find("SY");
        if (rw != null)
        {
            im = true;
            this.gameObject.GetComponent<Animator>().enabled = false;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = rw.GetComponent<SpriteRenderer>().sprite;
            this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(0.7f, 1.5f);
            this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(1.5f, 3);
            rw.SetActive(false);
        }
        if (PlayerPrefs.GetFloat("Skin") == 0 && im == false)
        {
            anim.SetInteger("Skins", 0);
        }
        if (PlayerPrefs.GetFloat("Skin") == 1 && im == false)
        {
            anim.SetInteger("Skins", 1);
        }
        if (PlayerPrefs.GetFloat("Skin") == 2 && im == false)
        {
            anim.SetInteger("Skins", 2);
        }
        if (PlayerPrefs.GetFloat("Skin") == 3 && im == false)
        {
            anim.SetInteger("Skins", 3);
        }
        if (PlayerPrefs.GetFloat("Skin") == 4 && im == false)
        {
            anim.SetInteger("Skins", 4);
        }
        if (PlayerPrefs.GetFloat("Skin") == 5 && im == false)
        {
            anim.SetInteger("Skins", 5);
        }
    }
    public void Jump()
    {
        if (isGrounded == false)
        {
            rb.velocity = Vector2.up * jumpForce;
            anim.SetBool("IsJumping", true);
            isGrounded = true;
        }
    }
    public void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }
    public void Run()
    {
        Vector3 dir = transform.right * Input.GetAxis("Horizontal");
        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);
        sprite.flipX = dir.x > 0.0f;
        if (im == true)
        {
            if (dir.x < 0.0f)
            {
                this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(0.7f, 1.5f);
            }
            if (dir.x >= 0.0f)
            {
                this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(-0.7f, 1.5f);
            }
        }
        mv2 = 2;
    }
    public void Runs()
    {
        Vector3 dir = transform.right * js.Horizontal;
        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);
        sprite.flipX = dir.x > 0.0f;
        if (im == true)
        {
            if (dir.x < 0.0f)
            {
                this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(1.5f, 1.5f);
            }
            if (dir.x >= 0.0f)
            {
                this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(-1.5f, 1.5f);
            }
        }
        mv2 = 1;
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Button" && isGrounded == true)
        {
            Levels.GetComponent<Boss_Defeat>().popal = true;
        }
        if (other.gameObject.tag == "Event")
        {
            PlayerPrefs.SetInt("Egg", 1);
            other.gameObject.SetActive(false);
        }
    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            anim.SetBool("IsJumping", false);
            isGrounded = false;
        }
        if (other.gameObject.tag == "Land")
        {
            anim.SetBool("IsJumping", false);
            isGrounded = false;
        }
    }
    public void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
        if (other.gameObject.tag == "Land")
        {
            isGrounded = true;
        }
    }
    public void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
        if (other.gameObject.tag == "Land")
        {
            isGrounded = false;
        }
    }
    public void Update()
    {
        bt.onClick.AddListener(Jump);
        if (mv2 == 1)
        {
            horizontalmove = js.Horizontal * speed;
        }
        if (mv2 == 2)
        {
            horizontalmove = Input.GetAxisRaw("Horizontal") * speed;
        }
        anim.SetFloat("Speed", Mathf.Abs(horizontalmove));
        if (SceneManager.GetActiveScene().buildIndex == 2 && sec > 1)
        {
            speed = 6 + (1f / sec);
        }
        if (SceneManager.GetActiveScene().buildIndex > 2 && sec > 1)
        {
            speed = 6 + (sec * 0.01f);
        }
        if (transform.position.y < -1 && transform.position.y > -900)
        {
            if (SceneManager.GetActiveScene().buildIndex == 2)
            {
                rb.gravityScale = 1;
                Levels.GetComponent<Levels>().wol = true;
            }
            if (SceneManager.GetActiveScene().buildIndex == 3)
            {
                rb.gravityScale = 1;
                SceneManager.LoadScene(3);
            }
            if (SceneManager.GetActiveScene().buildIndex == 4)
            {
                rb.gravityScale = 1;
                Levels.GetComponent<NeverEnd>().wol = true;
            }
            if (SceneManager.GetActiveScene().buildIndex == 5)
            {
                rb.gravityScale = 1;
                Levels.GetComponent<Boss_Defeat>().wol = true;
            }
        }
        if (js.Horizontal != 0)
        {
            Runs();
        }
        if (Input.GetButton("Horizontal"))
        {
            Run();
        }
        if (Input.GetButton("Vertical"))
        {
            Jump();
        }
    }
}
