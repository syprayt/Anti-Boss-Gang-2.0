using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Boss_Defeat : MonoBehaviour
{
    public bool tm;
    public float sec = 0;
    public GameObject[] stop;
    public GameObject[] spawn;
    public Text txt;
    public bool lv = false;
    public float lvs;
    public Text txts;
    public Text[] btt;
    public bool wol;
    public float mt;
    public bool nmtr = true;
    public Camera cam;
    public int ivent;
    public float flipcam;
    public float Lavas;
    public GameObject Lava;
    public GameObject[] platform;
    public GameObject[] meteoru;
    public int boss;
    public float best;
    public float ot = 1f;
    public float Do = 100f;
    public float otB = 1f;
    public float DoB = 20f;
    public float bt;
    public bool hs;
    public float hp;
    public GameObject bull;
    public bool popal;
    public bool go;
    public float speed = 10f;
    public bool ntr = true;
    public float flot;
    public Text hpt;
    public float level;
    public bool pdd;
    public float coin;
    public bool coins;
    public float[] btw;
    public GameObject[] pauses;
    public AudioSource au;
    public AudioClip sound;
    public bool moffon;
    public Text[] lng;
    public Font[] ft;
    public GameObject[] floor;
    public Sprite[] floor_skins;
    public Sprite[] bgb;
    public GameObject[] bg;
    public bool iv;
    public bool cont;
    public float[] grvt;
    public int ive;
    public Text TTO;
    public Animator anima;
    public GameObject window;
    public bool continie = true;
    public GameObject ad;
    public bool lnm;
    public GameObject Shield;
    public GameObject[] events;
    public void Start()
    {
        Time.timeScale = 1;
        if (PlayerPrefs.GetInt("Language") == 0)
        {
            lng[0].text = "Restart";
            lng[1].text = "Back to lobby";
            lng[2].text = "Resume";
            lng[3].text = "Back to lobby";
            for (int i = 0; i < 4; i++)
            {
                lng[i].font = ft[0];
            }
        }
        if (PlayerPrefs.GetInt("Language") == 1)
        {
            lng[0].text = "Zagraj ponownie";
            lng[1].text = "Powrót do holu";
            lng[2].text = "Wznawiać";
            lng[3].text = "Powrót do holu";
            for (int i = 0; i < 4; i++)
            {
                lng[i].font = ft[1];
            }
        }
        if (PlayerPrefs.GetInt("Language") == 2)
        {
            lng[0].text = "Перезавантажити";
            lng[1].text = "Назад до хабу";
            lng[2].text = "Продовжити";
            lng[3].text = "Назад до хабу";
            for (int i = 0; i < 4; i++)
            {
                lng[i].font = ft[2];
            }
        }
        if (PlayerPrefs.GetInt("Pick") == 0)
        {
            coin = PlayerPrefs.GetFloat("Coin");
            hs = true;
            boss = PlayerPrefs.GetInt("WBD");
            btw[2] = Do - ot;
            if (boss == 1)
            {
                hp = 3 + PlayerPrefs.GetFloat("Level_Defeat_1");
                level = PlayerPrefs.GetFloat("Level_Defeat_1");
                ivent = 1;
            }
            if (boss == 2)
            {
                hp = 3 + PlayerPrefs.GetFloat("Level_Defeat_2");
                level = PlayerPrefs.GetFloat("Level_Defeat_2");
                ivent = 2;
            }
            if (boss == 3)
            {
                hp = 3 + PlayerPrefs.GetFloat("Level_Defeat_3");
                level = PlayerPrefs.GetFloat("Level_Defeat_3");
                ivent = 3;
            }
        }
        if (PlayerPrefs.GetInt("Pick") == 3)
        {
            hs = true;
            hp = PlayerPrefs.GetFloat("Healbar");
            btw[0] = PlayerPrefs.GetFloat("ot");
            btw[1] = PlayerPrefs.GetFloat("do");
            ot = btw[0];
            Do = btw[1];
            btw[2] = btw[1] - btw[0];
            coins = true;
            if (PlayerPrefs.GetInt("Selection") == 1)
            {
                ivent = 1;
                boss = 1;
            }
            if (PlayerPrefs.GetInt("Selection") == 2)
            {
                ivent = 2;
                boss = 2;
            }
            if (PlayerPrefs.GetInt("Selection") == 3)
            {
                ivent = 3;
                boss = 3;
            }
        }
    }
    public void Update()
    {
        if (moffon == false && PlayerPrefs.GetInt("Sound") == 0)
        {
            StartCoroutine(wait());
        }
        stop[3].GetComponent<Enemy>().sec = sec;
        stop[0].GetComponent<Fly>().sec = sec;
        stop[2].GetComponent<Drop>().sec = sec;
        stop[1].GetComponent<Move>().sec = sec;
        if (sec >= 30 && boss == 1)
        {
            stop[4].GetComponent<Concrete>().enabled = true;
        }
        if (stop[1].transform.position.y <= -900 && pdd == false)
        {
            cam.transform.position = new Vector3(cam.transform.position.x, -995, -10);
            stop[1].transform.position = new Vector2(1, -993);
            pdd = true;
        }
        if (PlayerPrefs.GetInt("Language") == 0)
        {
            hpt.text = "Boss hp:" + hp;
            hpt.font = ft[0];
        }
        if (PlayerPrefs.GetInt("Language") == 1)
        {
            hpt.text = "HP bossa:" + hp;
            hpt.font = ft[1];
        }
        if (PlayerPrefs.GetInt("Language") == 2)
        {
            hpt.text = "HP босса:" + hp;
            hpt.font = ft[1];
        }
        if (popal == true)
        {
            spawn[4].SetActive(false);
            bull.transform.position = new Vector2(spawn[4].transform.position.x, spawn[4].transform.position.y);
            bull.SetActive(true);
            stop[3].GetComponent<Enemy>().enabled = false;
            bull.transform.LookAt(stop[3].transform.position);
            if (stop[3].transform.position.x > spawn[4].transform.position.x)
            {
                flot = -bull.transform.localEulerAngles.x;
                bull.GetComponent<SpriteRenderer>().flipX = false;
            }
            if (stop[3].transform.position.x <= spawn[4].transform.position.x)
            {
                flot = bull.transform.localEulerAngles.x;
                bull.GetComponent<SpriteRenderer>().flipX = true;
            }
            go = true;
            popal = false;
        }
        if (go == true)
        {
            bull.transform.rotation = Quaternion.Euler(0, 0, flot);
            bull.transform.position = Vector3.MoveTowards(bull.transform.position, stop[3].transform.position, speed * Time.deltaTime);
        }
        if (hs == true)
        {
            bt = Random.Range(otB, DoB);
            spawn[4].transform.position = new Vector2(Random.Range(-7f, 7f), 1.6f);
            hs = false;
        }
        if (bt - sec <= 1 && bt - sec >= -1 && ntr == true && iv == false)
        {
            ntr = false;
            StartCoroutine(Buton());
        }
        if (bt - sec <= 1 && bt - sec >= -1 && ntr == true && iv == true)
        {
            otB += 20;
            DoB += 20;
            bt = Random.Range(otB, DoB);
        }
        if (wol == false)
        {
            sec += Time.deltaTime;
            if (PlayerPrefs.GetInt("Language") == 0)
            {
                txt.font = ft[0];
                txt.text = "Time:" + sec.ToString("0");
            }
            if (PlayerPrefs.GetInt("Language") == 1)
            {
                txt.font = ft[1];
                txt.text = "Czas:" + sec.ToString("0");
            }
            if (PlayerPrefs.GetInt("Language") == 2)
            {
                txt.font = ft[2];
                txt.text = "Час:" + sec.ToString("0");
            }
        }
        if (ivent == 1)
        {
            floor[0].GetComponent<SpriteRenderer>().sprite = floor_skins[0];
            floor[1].GetComponent<SpriteRenderer>().sprite = floor_skins[0];
            floor[2].GetComponent<SpriteRenderer>().sprite = floor_skins[0];
            floor[3].GetComponent<SpriteRenderer>().sprite = floor_skins[0];
            floor[4].GetComponent<SpriteRenderer>().sprite = floor_skins[0];
            floor[5].GetComponent<SpriteRenderer>().sprite = floor_skins[0];
            floor[6].GetComponent<SpriteRenderer>().sprite = floor_skins[0];
            floor[7].GetComponent<SpriteRenderer>().sprite = floor_skins[0];
            floor[8].GetComponent<SpriteRenderer>().sprite = floor_skins[0];
            floor[9].GetComponent<SpriteRenderer>().sprite = floor_skins[0];
            bg[0].SetActive(true);
            mt = Random.Range(ot, Do);
            stop[3].GetComponent<Enemy>().boss = 1;
            stop[2].GetComponent<Drop>().boss = 1;
            ivent = 0;
        }
        if (ivent == 2)
        {
            floor[0].GetComponent<SpriteRenderer>().sprite = floor_skins[1];
            floor[1].GetComponent<SpriteRenderer>().sprite = floor_skins[1];
            floor[2].GetComponent<SpriteRenderer>().sprite = floor_skins[1];
            floor[3].GetComponent<SpriteRenderer>().sprite = floor_skins[1];
            floor[4].GetComponent<SpriteRenderer>().sprite = floor_skins[1];
            floor[5].GetComponent<SpriteRenderer>().sprite = floor_skins[1];
            floor[6].GetComponent<SpriteRenderer>().sprite = floor_skins[1];
            floor[7].GetComponent<SpriteRenderer>().sprite = floor_skins[1];
            floor[8].GetComponent<SpriteRenderer>().sprite = floor_skins[1];
            floor[9].GetComponent<SpriteRenderer>().sprite = floor_skins[1];
            bg[1].SetActive(true);
            flipcam = Random.Range(ot, Do);
            stop[3].GetComponent<Enemy>().boss = 2;
            stop[2].GetComponent<Drop>().boss = 2;
            ivent = 0;
        }
        if (ivent == 3)
        {
            floor[0].GetComponent<SpriteRenderer>().sprite = floor_skins[2];
            floor[1].GetComponent<SpriteRenderer>().sprite = floor_skins[2];
            floor[2].GetComponent<SpriteRenderer>().sprite = floor_skins[2];
            floor[3].GetComponent<SpriteRenderer>().sprite = floor_skins[2];
            floor[4].GetComponent<SpriteRenderer>().sprite = floor_skins[2];
            floor[5].GetComponent<SpriteRenderer>().sprite = floor_skins[2];
            floor[6].GetComponent<SpriteRenderer>().sprite = floor_skins[2];
            floor[7].GetComponent<SpriteRenderer>().sprite = floor_skins[2];
            floor[8].GetComponent<SpriteRenderer>().sprite = floor_skins[2];
            floor[9].GetComponent<SpriteRenderer>().sprite = floor_skins[2];
            bg[2].SetActive(true);
            Lavas = Random.Range(ot, Do);
            stop[3].GetComponent<Enemy>().boss = 3;
            stop[2].GetComponent<Drop>().boss = 3;
            ivent = 0;
        }
        if (flipcam - sec <= 1 && flipcam - sec >= -1 && nmtr == true && boss == 2 && PlayerPrefs.GetInt("Pick") < 4)
        {
            ive = 2;
            bg[1].GetComponent<Image>().sprite = bgb[3];
            stop[3].GetComponent<Enemy>().Rage = true;
            stop[3].GetComponent<Enemy>().Stra = true;
            stop[2].GetComponent<Drop>().Rage = true;
            iv = true;
            spawn[3].SetActive(true);
            nmtr = false;
            cam.backgroundColor = new Color32(125, 6, 0, 0);
            StartCoroutine(flip());
        }
        if (Lavas - sec <= 1 && Lavas - sec >= -1 && nmtr == true && boss == 3 && PlayerPrefs.GetInt("Pick") < 4)
        {
            ive = 3;
            bg[2].GetComponent<Image>().sprite = bgb[5];
            stop[3].GetComponent<Enemy>().Rage = true;
            stop[3].GetComponent<Enemy>().Stra = true;
            iv = true;
            spawn[3].SetActive(true);
            platform[0].SetActive(true);
            platform[1].SetActive(true);
            platform[2].SetActive(true);
            nmtr = false;
            cam.backgroundColor = new Color32(125, 6, 0, 0);
            StartCoroutine(lava());
        }
        if (mt - sec <= 1 && mt - sec >= -1 && nmtr == true && boss == 1 && PlayerPrefs.GetInt("Pick") < 4)
        {
            ive = 1;
            bg[0].GetComponent<Image>().sprite = bgb[1];
            stop[3].GetComponent<Enemy>().Rage = true;
            stop[3].GetComponent<Enemy>().Stra = true;
            iv = true;
            spawn[3].SetActive(true);
            nmtr = false;
            cam.backgroundColor = new Color32(125, 6, 0, 0);
            StartCoroutine(mtr());
        }
        if (lv == true)
        {
            if (ivent == 1)
            {
                best = PlayerPrefs.GetFloat("Best_Score_1");
                if (sec > best)
                {
                    PlayerPrefs.SetFloat("Best_Score_1", sec);
                }
            }
            if (ivent == 2)
            {
                best = PlayerPrefs.GetFloat("Best_Score_2");
                if (sec > best)
                {
                    PlayerPrefs.SetFloat("Best_Score_2", sec);
                }
            }
            if (ivent == 3)
            {
                best = PlayerPrefs.GetFloat("Best_Score_3");
                if (sec > best)
                {
                    PlayerPrefs.SetFloat("Best_Score_3", sec);
                }
            }
            lv = false;
        }
        if (hp <= 0)
        {
            if (PlayerPrefs.GetInt("Language") == 0)
            {
                txts.text = "You win";
                btt[0].text = "Next level";
                btt[1].text = "Back to lobby";
                txts.font = ft[0];
                btt[0].font = ft[0];
                btt[1].font = ft[0];
            }
            if (PlayerPrefs.GetInt("Language") == 1)
            {
                txts.text = "Wygrałeś";
                btt[0].text = "Następny poziom";
                btt[1].text = "Powrót do holu";
                txts.font = ft[1];
                btt[0].font = ft[1];
                btt[1].font = ft[1];
            }
            if (PlayerPrefs.GetInt("Language") == 2)
            {
                txts.text = "Ти переміг";
                btt[0].text = "Наступний рівень";
                btt[1].text = "Назад до хабу";
                txts.font = ft[2];
                btt[0].font = ft[2];
                btt[1].font = ft[2];
            }
            if (stop[3].GetComponent<Enemy>().im == true)
            {
                stop[3].GetComponent<Enemy>().rw.SetActive(true);
                DontDestroyOnLoad(stop[3].GetComponent<Enemy>().rw);
            }
            else if (stop[1].GetComponent<Move>().im == true)
            {
                stop[1].GetComponent<Move>().rw.SetActive(true);
                DontDestroyOnLoad(stop[1].GetComponent<Move>().rw);
            }
            else if (stop[2].GetComponent<Drop>().im == true)
            {
                stop[2].GetComponent<Drop>().rw.SetActive(true);
                DontDestroyOnLoad(stop[2].GetComponent<Drop>().rw);
            }
            ad.SetActive(false);
            stop[2].GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            stop[0].GetComponent<Fly>().enabled = false;
            stop[1].GetComponent<Move>().enabled = false;
            stop[2].GetComponent<Rigidbody2D>().gravityScale = 0;
            stop[2].GetComponent<Drop>().enabled = false;
            stop[3].GetComponent<Enemy>().enabled = false;
            spawn[0].SetActive(true);
            spawn[5].SetActive(true);
            platform[0].SetActive(false);
            platform[1].SetActive(false);
            platform[2].SetActive(false);
            if (coins == false)
            {
                window.SetActive(true);
                anima.Play("Window");
                float rnd = Random.Range(9 + lvs / 2, 13 + lvs / 2);
                coin += rnd;
                spawn[6].GetComponent<Text>().text = "+" + rnd.ToString("0");
                PlayerPrefs.SetFloat("Coin", coin);
                coins = true;
            }
            StopAllCoroutines();
            spawn[3].SetActive(false);
            cam.backgroundColor = new Color32(49, 77, 121, 0);
            nmtr = false;
            if (boss == 1)
            {
                level += 1;
                PlayerPrefs.SetFloat("Level_Defeat_1", level);
                boss = 0;
            }
            if (boss == 2)
            {
                level += 1;
                PlayerPrefs.SetFloat("Level_Defeat_2", level);
                boss = 0;
            }
            if (boss == 3)
            {
                level += 1;
                PlayerPrefs.SetFloat("Level_Defeat_3", level);
                boss = 0;
            }
            if (meteoru[0] != null && meteoru[1] != null && meteoru[2] != null && meteoru[3] != null)
            {
                meteoru[0].GetComponent<Rigidbody2D>().gravityScale = 0;
                meteoru[0].GetComponent<Drop>().enabled = false;
                meteoru[1].GetComponent<Rigidbody2D>().gravityScale = 0;
                meteoru[1].GetComponent<Drop>().enabled = false;
                meteoru[2].GetComponent<Rigidbody2D>().gravityScale = 0;
                meteoru[2].GetComponent<Drop>().enabled = false;
                meteoru[3].GetComponent<Rigidbody2D>().gravityScale = 0;
                meteoru[3].GetComponent<Drop>().enabled = false;
            }
        }
        if (wol == true)
        {
            if (PlayerPrefs.GetInt("Language") == 0 && continie == false)
            {
                txts.text = "You lose";
                btt[0].text = "Restart";
                btt[1].text = "Back to lobby";
                txts.font = ft[0];
                btt[0].font = ft[0];
                btt[1].font = ft[0];
            }
            if (PlayerPrefs.GetInt("Language") == 1 && continie == false)
            {
                txts.text = "Przegrałeś";
                btt[0].text = "Uruchom ponownie";
                btt[1].text = "Powrót do holu";
                txts.font = ft[1];
                btt[0].font = ft[1];
                btt[1].font = ft[1];
            }
            if (PlayerPrefs.GetInt("Language") == 2 && continie == false)
            {
                txts.text = "Ти програв";
                btt[0].text = "Перезавантажити";
                btt[1].text = "Назад до хабу";
                txts.font = ft[2];
                btt[0].font = ft[2];
                btt[1].font = ft[2];
            }
            TTO.gameObject.SetActive(false);
            if (PlayerPrefs.GetInt("Language") == 0 && continie == true)
            {
                txts.text = "Continue?";
                btt[0].text = "Yes";
                btt[1].text = "No";
                txts.font = ft[0];
                btt[0].font = ft[0];
                btt[1].font = ft[0];
            }
            if (PlayerPrefs.GetInt("Language") == 1 && continie == true)
            {
                txts.text = "Kontynuować?";
                btt[0].text = "Tak";
                btt[1].text = "NIE";
                txts.font = ft[1];
                btt[0].font = ft[1];
                btt[1].font = ft[1];
            }
            if (PlayerPrefs.GetInt("Language") == 2 && continie == true)
            {
                txts.text = "Продовжити?";
                btt[0].text = "Так";
                btt[1].text = "Ні";
                txts.font = ft[2];
                btt[0].font = ft[2];
                btt[1].font = ft[2];
            }
            if (continie == true)
            {
                spawn[2].GetComponent<Button>().onClick.RemoveAllListeners();
                spawn[2].GetComponent<Button>().onClick.AddListener(No);
                ad.SetActive(true);

            }
            if (continie == false)
            {
                spawn[1].GetComponent<Button>().onClick.RemoveAllListeners();
                spawn[2].GetComponent<Button>().onClick.RemoveAllListeners();
                spawn[1].GetComponent<Button>().onClick.AddListener(Restart);
                spawn[2].GetComponent<Button>().onClick.AddListener(Lobby);
                spawn[5].SetActive(true);
                if (coins == false)
                {
                    float rnd = Random.Range(1, 4);
                    coin += rnd;
                    spawn[6].GetComponent<Text>().text = "+" + rnd.ToString("0");
                    PlayerPrefs.SetFloat("Coin", coin);
                    coins = true;
                }
                ad.SetActive(false);
            }
            if(lnm == false)
            {
                window.SetActive(true);
                anima.Play("Window");
                lnm = true;
            }
            if (stop[3].GetComponent<Enemy>().im == true)
            {
                stop[3].GetComponent<Enemy>().rw.SetActive(true);
                DontDestroyOnLoad(stop[3].GetComponent<Enemy>().rw);
            }
            if (stop[1].GetComponent<Move>().im == true)
            {
                stop[1].GetComponent<Move>().rw.SetActive(true);
                DontDestroyOnLoad(stop[1].GetComponent<Move>().rw);
            }
            if (stop[2].GetComponent<Drop>().im == true)
            {
                stop[2].GetComponent<Drop>().rw.SetActive(true);
                DontDestroyOnLoad(stop[2].GetComponent<Drop>().rw);
            }
            stop[0].GetComponent<Fly>().enabled = false;
            stop[1].GetComponent<Move>().enabled = false;
            grvt[0] = stop[2].GetComponent<Rigidbody2D>().gravityScale;
            stop[2].GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            stop[2].GetComponent<Rigidbody2D>().gravityScale = 0;
            stop[2].GetComponent<Drop>().enabled = false;
            stop[3].GetComponent<Enemy>().enabled = false;
            stop[4].GetComponent<Concrete>().enabled = false;
            events[0].SetActive(false);
            spawn[0].SetActive(true);
            platform[0].SetActive(false);
            platform[1].SetActive(false);
            platform[2].SetActive(false);
            Lava.SetActive(false);
            StopAllCoroutines();
            spawn[3].SetActive(false);
            cam.backgroundColor = new Color32(49, 77, 121, 0);
            nmtr = false;
            if (boss == 1 && PlayerPrefs.GetInt("Pick") == 0)
            {
                best = PlayerPrefs.GetFloat("Best_Score_1");
                if (sec > best)
                {
                    PlayerPrefs.SetFloat("Best_Score_1", sec);
                    best = PlayerPrefs.GetFloat("Best_Score_1");
                }
            }
            if (boss == 2 && PlayerPrefs.GetInt("Pick") == 0)
            {
                best = PlayerPrefs.GetFloat("Best_Score_2");
                if (sec > best)
                {
                    PlayerPrefs.SetFloat("Best_Score_2", sec);
                    best = PlayerPrefs.GetFloat("Best_Score_1");
                }
            }
            if (boss == 3 && PlayerPrefs.GetInt("Pick") == 0)
            {
                best = PlayerPrefs.GetFloat("Best_Score_3");
                if (sec > best)
                {
                    PlayerPrefs.SetFloat("Best_Score_3", sec);
                    best = PlayerPrefs.GetFloat("Best_Score_1");
                }
            }
            if (meteoru[0] != null && meteoru[1] != null && meteoru[2] != null && meteoru[3] != null)
            {
                grvt[1] = meteoru[0].GetComponent<Rigidbody2D>().gravityScale;
                grvt[2] = meteoru[1].GetComponent<Rigidbody2D>().gravityScale;
                grvt[3] = meteoru[2].GetComponent<Rigidbody2D>().gravityScale;
                grvt[4] = meteoru[3].GetComponent<Rigidbody2D>().gravityScale;
                meteoru[0].GetComponent<Rigidbody2D>().gravityScale = 0;
                meteoru[0].GetComponent<Drop>().enabled = false;
                meteoru[1].GetComponent<Rigidbody2D>().gravityScale = 0;
                meteoru[1].GetComponent<Drop>().enabled = false;
                meteoru[2].GetComponent<Rigidbody2D>().gravityScale = 0;
                meteoru[2].GetComponent<Drop>().enabled = false;
                meteoru[3].GetComponent<Rigidbody2D>().gravityScale = 0;
                meteoru[3].GetComponent<Drop>().enabled = false;
            }
        }
        if (cont == true)
        {
            spawn[0].SetActive(false);
            spawn[5].SetActive(false);
            window.SetActive(false);
            Shield.SetActive(true);
            stop[1].GetComponent<Move>().enabled = true;
            stop[0].GetComponent<BoxCollider2D>().enabled = false;
            stop[2].GetComponent<BoxCollider2D>().enabled = false;
            wol = false;
            lnm = false;
            coins = false;
            cont = false;
            StartCoroutine(conti());
        }
    }
    public void No()
    {
        continie = false;
    }
    IEnumerator Buton()
    {
        spawn[4].SetActive(true);
        yield return new WaitForSeconds(4);
        otB += 20;
        DoB += 20;
        hs = true;
        ntr = true;
        spawn[4].SetActive(false);
    }
    public void Lobby()
    {
        if (wol == true)
        {
            SceneManager.LoadScene(1);
        }
        if (wol == false)
        {
            if (PlayerPrefs.GetInt("Pick") == 0)
            {
                lv = true;
            }
            SceneManager.LoadScene(1);
        }
    }
    public void Restart()
    {
        if (wol == true)
        {
            SceneManager.LoadScene(5);
        }
        if (wol == false)
        {
            if (PlayerPrefs.GetInt("Pick") == 0)
            {
                lv = true;
            }
            SceneManager.LoadScene(5);
        }
    }
    IEnumerator mtr()
    {
        yield return new WaitForSeconds(2);
        stop[3].GetComponent<Enemy>().Stra = false;
        stop[2].GetComponent<Drop>().meteor = true;
        spawn[3].SetActive(false);
        yield return new WaitForSeconds(5);
        ive = 0;
        iv = false;
        bg[0].GetComponent<Image>().sprite = bgb[0];
        nmtr = true;
        ot += btw[2];
        Do += btw[2];
        ivent = 1;
    }
    IEnumerator flip()
    {
        yield return new WaitForSeconds(2);
        bg[1].transform.rotation = Quaternion.Euler(0, 0, 180);
        stop[3].GetComponent<Enemy>().Stra = false;
        cam.transform.rotation = Quaternion.Euler(cam.transform.rotation.x, cam.transform.rotation.y, 180);
        spawn[3].SetActive(false);
        yield return new WaitForSeconds(5);
        bg[1].GetComponent<Image>().sprite = bgb[2];
        bg[1].transform.rotation = Quaternion.Euler(0, 0, -180);
        ive = 0;
        iv = false;
        stop[3].GetComponent<Enemy>().Rage = false;
        stop[2].GetComponent<Drop>().Rage = false;
        nmtr = true;
        ot += btw[2];
        Do += btw[2];
        cam.backgroundColor = new Color32(49, 77, 121, 0);
        cam.transform.rotation = Quaternion.Euler(cam.transform.rotation.x, cam.transform.rotation.y, 0);
        ivent = 2;
    }
    IEnumerator lava()
    {
        yield return new WaitForSeconds(2);
        stop[3].GetComponent<Enemy>().Stra = false;
        stop[2].GetComponent<Drop>().fly = true;
        stop[0].GetComponent<Fly>().ups = true;
        stop[2].transform.position = new Vector2(transform.position.x, 0);
        stop[2].GetComponent<Rigidbody2D>().gravityScale = -1f;
        spawn[3].SetActive(false);
        Lava.SetActive(true);
        Lava.GetComponent<Lava>().flood = true;
        yield return new WaitForSeconds(5);
        bg[2].GetComponent<Image>().sprite = bgb[4];
        ive = 0;
        iv = false;
        stop[3].GetComponent<Enemy>().Rage = false;
        cam.backgroundColor = new Color32(49, 77, 121, 0);
        stop[0].GetComponent<Fly>().ups = false;
        Lava.GetComponent<Lava>().flood = false;
        stop[2].GetComponent<Drop>().fly = false;
        stop[2].GetComponent<Rigidbody2D>().gravityScale = 1;
        yield return new WaitForSeconds(2);
        nmtr = true;
        ot += btw[2];
        Do += btw[2];
        platform[0].SetActive(false);
        platform[1].SetActive(false);
        platform[2].SetActive(false);
        ivent = 3;
    }
    IEnumerator conti()
    {
        TTO.gameObject.SetActive(true);
        TTO.GetComponent<Animator>().Play("Number");
        TTO.text = "3";
        yield return new WaitForSeconds(1);
        TTO.text = "2";
        yield return new WaitForSeconds(1);
        TTO.text = "1";
        yield return new WaitForSeconds(1);
        stop[0].GetComponent<BoxCollider2D>().enabled = true;
        stop[2].GetComponent<BoxCollider2D>().enabled = true;
        TTO.gameObject.SetActive(false);
        stop[0].GetComponent<Fly>().enabled = true;
        stop[2].GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        stop[2].GetComponent<Rigidbody2D>().gravityScale = grvt[0];
        stop[2].GetComponent<Drop>().enabled = true;
        stop[3].GetComponent<Enemy>().enabled = true;
        Shield.SetActive(false);
        otB += 20;
        DoB += 20;
        hs = true;
        ntr = true;
        if (sec >= 30 && boss == 1)
        {
            stop[4].GetComponent<Concrete>().enabled = true;
        }
        if (meteoru[0] != null && meteoru[1] != null && meteoru[2] != null && meteoru[3] != null)
        {
            meteoru[0].GetComponent<Rigidbody2D>().gravityScale = grvt[1];
            meteoru[0].GetComponent<Drop>().enabled = true;
            meteoru[1].GetComponent<Rigidbody2D>().gravityScale = grvt[2];
            meteoru[1].GetComponent<Drop>().enabled = true;
            meteoru[2].GetComponent<Rigidbody2D>().gravityScale = grvt[3];
            meteoru[2].GetComponent<Drop>().enabled = true;
            meteoru[3].GetComponent<Rigidbody2D>().gravityScale = grvt[4];
            meteoru[3].GetComponent<Drop>().enabled = true;
        }
        if (ive == 1)
        {
            StartCoroutine(mtr());
        }
        else if (ive == 2)
        {
            StartCoroutine(flip());
        }
        else if (ive == 3)
        {
            platform[0].SetActive(true);
            platform[1].SetActive(true);
            platform[2].SetActive(true);
            StartCoroutine(lava());
        }
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
        float ms = Random.Range(0, 123);
        au.time = ms;
        au.Play();
        yield return new WaitForSeconds(123 - ms);
        moffon = false;
    }
}
