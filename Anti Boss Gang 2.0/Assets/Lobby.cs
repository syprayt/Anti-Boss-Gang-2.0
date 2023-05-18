using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Lobby : MonoBehaviour
{
    public Text txt;
    public float lv;
    public float[] best;
    public GameObject[] bt;
    public GameObject[] txts;
    public Text[] texts;
    public Text coin;
    public GameObject shop;
    public int lvs = 0;
    public GameObject opt;
    public AudioSource au;
    public AudioClip sound;
    public bool moffon;
    public bool apl;
    public bool apl2;
    public GameObject[] cbais;
    public Sprite[] Skins;
    public GameObject Characters;
    public Text[] lng;
    public Font[] ft;
    public GameObject[] Event;
    public void Start()
    {
        if(PlayerPrefs.GetInt("Egg") >= 1)
        {
            Event[0].SetActive(true);
            Event[1].SetActive(true);
            Event[1].GetComponent<Text>().text = PlayerPrefs.GetInt("Egg").ToString("0");
        }
        if (PlayerPrefs.GetInt("Egg") == 0)
        {
            Event[0].SetActive(false);
            Event[1].SetActive(false);
        }
        if (PlayerPrefs.GetFloat("JBX") == 0 && PlayerPrefs.GetFloat("JBY") == 0)
        {
            PlayerPrefs.SetFloat("JBX", 520);
            PlayerPrefs.SetFloat("JBY", -240);
        }
        if (PlayerPrefs.GetFloat("FJX") == 0 && PlayerPrefs.GetFloat("FJY") == 0)
        {
            PlayerPrefs.SetFloat("FJX", -520);
            PlayerPrefs.SetFloat("FJY", -240);
        }
        bt[24].transform.localPosition = new Vector3(PlayerPrefs.GetFloat("JBX"), PlayerPrefs.GetFloat("JBY"), 0);
        bt[23].transform.localPosition = new Vector3(PlayerPrefs.GetFloat("FJX"), PlayerPrefs.GetFloat("FJY"), 0);
        if (PlayerPrefs.GetInt("Language") == 0)
        {
            bt[29].GetComponent<Image>().color = Color.black;
            bt[31].GetComponent<Text>().color = Color.green;
            bt[30].GetComponent<Image>().color = Color.white;
            bt[32].GetComponent<Text>().color = Color.black;
            bt[34].GetComponent<Image>().color = Color.white;
            bt[35].GetComponent<Text>().color = Color.black;
            lng[6].text = "Seconds: ";
            lng[6].transform.localPosition = new Vector2(23, 70);
            lng[7].text = "Seconds: ";
            lng[7].transform.localPosition = new Vector2(23, -30);
            lng[8].text = "Seconds: ";
            lng[8].transform.localPosition = new Vector2(23, -130);
            lng[13].text = "Level: ";
            lng[13].transform.localPosition = new Vector2(lng[13].transform.localPosition.x, 70);
            lng[14].text = "Level: ";
            lng[14].transform.localPosition = new Vector2(lng[14].transform.localPosition.x, -30);
            lng[15].text = "Level: ";
            lng[15].transform.localPosition = new Vector2(lng[15].transform.localPosition.x, -130);
            lng[19].text = "Level: ";
        }
        if (PlayerPrefs.GetInt("Language") == 1)
        {
            bt[29].GetComponent<Image>().color = Color.white;
            bt[31].GetComponent<Text>().color = Color.black;
            bt[30].GetComponent<Image>().color = Color.black;
            bt[32].GetComponent<Text>().color = Color.green;
            bt[34].GetComponent<Image>().color = Color.white;
            bt[35].GetComponent<Text>().color = Color.black;
            lng[6].text = "Wniosek: ";
            lng[6].transform.localPosition = new Vector2(23, 76);
            lng[7].text = "Wniosek: ";
            lng[7].transform.localPosition = new Vector2(23, -24);
            lng[8].text = "Wniosek: ";
            lng[8].transform.localPosition = new Vector2(23, -124);
            lng[13].text = "Poziom: ";
            lng[13].transform.localPosition = new Vector2(lng[13].transform.localPosition.x, 76);
            lng[14].text = "Poziom: ";
            lng[14].transform.localPosition = new Vector2(lng[14].transform.localPosition.x, - 24);
            lng[15].text = "Poziom: ";
            lng[15].transform.localPosition = new Vector2(lng[15].transform.localPosition.x, -124);
            lng[19].text = "Poziom: ";
        }
        if (PlayerPrefs.GetInt("Language") == 2)
        {
            bt[29].GetComponent<Image>().color = Color.white;
            bt[31].GetComponent<Text>().color = Color.black;
            bt[30].GetComponent<Image>().color = Color.white;
            bt[32].GetComponent<Text>().color = Color.black;
            bt[34].GetComponent<Image>().color = Color.black;
            bt[35].GetComponent<Text>().color = Color.green;
            lng[6].text = "Секунд: ";
            lng[6].transform.localPosition = new Vector2(60, 73);
            lng[7].text = "Секунд: ";
            lng[7].transform.localPosition = new Vector2(60, -27);
            lng[8].text = "Секунд: ";
            lng[8].transform.localPosition = new Vector2(60, -127);
            lng[13].text = "Рівень: ";
            lng[13].transform.localPosition = new Vector2(lng[13].transform.localPosition.x + 5, 73);
            lng[14].text = "Рівень: ";
            lng[14].transform.localPosition = new Vector2(lng[14].transform.localPosition.x + 5, -27);
            lng[15].text = "Рівень: ";
            lng[15].transform.localPosition = new Vector2(lng[15].transform.localPosition.x + 5, -127);
            lng[19].text = "Рівень: ";
        }
        lv = PlayerPrefs.GetFloat("Level");
        txt.text = txt.text + lv;
        best[0] = PlayerPrefs.GetFloat("Best_Score_1");
        best[1] = PlayerPrefs.GetFloat("Best_Score_2");
        best[2] = PlayerPrefs.GetFloat("Best_Score_3");
        best[3] = PlayerPrefs.GetFloat("Level_Defeat_1");
        best[4] = PlayerPrefs.GetFloat("Level_Defeat_2");
        best[5] = PlayerPrefs.GetFloat("Level_Defeat_3");
        texts[0].text = texts[0].text + best[0].ToString("0");
        texts[1].text = texts[1].text + best[1].ToString("0");
        texts[2].text = texts[2].text + best[2].ToString("0");
        texts[3].text = texts[3].text + best[3].ToString("0");
        texts[4].text = texts[4].text + best[4].ToString("0");
        texts[5].text = texts[5].text + best[5].ToString("0");
    }
    public void Update()
    {
        coin.text = "" + PlayerPrefs.GetFloat("Coin").ToString("0");
        if (PlayerPrefs.GetFloat("Skin") == 0)
        {
            Characters.GetComponent<Image>().sprite = Skins[0];
        }
        if (PlayerPrefs.GetFloat("Skin") == 1)
        {
            Characters.GetComponent<Image>().sprite = Skins[1];
        }
        if (PlayerPrefs.GetFloat("Skin") == 2)
        {
            Characters.GetComponent<Image>().sprite = Skins[2];
        }
        if (PlayerPrefs.GetFloat("Skin") == 3)
        {
            Characters.GetComponent<Image>().sprite = Skins[3];
        }
        if (PlayerPrefs.GetFloat("Skin") == 4)
        {
            Characters.GetComponent<Image>().sprite = Skins[4];
        }
        if (PlayerPrefs.GetFloat("Skin") == 5)
        {
            Characters.GetComponent<Image>().sprite = Skins[5];
        }
        if (moffon == false && PlayerPrefs.GetInt("Sound") == 0)
        {
            StartCoroutine(wait());
        }
        if (PlayerPrefs.GetInt("Sound") == 0)
        {
            bt[20].GetComponent<Image>().color = Color.black;
            bt[21].GetComponent<Image>().color = Color.white;
            texts[6].color = Color.green;
            texts[7].color = Color.black;
        }
        if (PlayerPrefs.GetInt("Sound") == 1)
        {
            bt[21].GetComponent<Image>().color = Color.black;
            bt[20].GetComponent<Image>().color = Color.white;
            texts[7].color = Color.green;
            texts[6].color = Color.black;
        }
        if (PlayerPrefs.GetInt("Language") == 0)
        {
            lng[0].text = "Begin to play";
            lng[1].text = "Tutorial";
            lng[2].text = "Endless Levels";
            lng[3].text = "Builder";
            lng[3].transform.localPosition = new Vector2(0, 0);
            lng[4].text = "Scientist";
            lng[4].transform.localPosition = new Vector2(0, 0);
            lng[5].text = "Lava Spirit";
            lng[5].transform.localPosition = new Vector2(0, 0);
            lng[9].text = "Defeat the boss";
            lng[10].text = "Builder";
            lng[10].transform.localPosition = new Vector2(0, 0);
            lng[11].text = "Scientist";
            lng[11].transform.localPosition = new Vector2(0, 0);
            lng[12].text = "Lava Spirit";
            lng[12].transform.localPosition = new Vector2(0, 0);
            lng[16].text = "Shop";
            lng[17].text = "Create your game";
            lng[18].text = "Classic mode";
            lng[20].text = "Select mode";
            lng[21].text = "On";
            lng[22].text = "Off";
            lng[23].text = "Change button layouts";
            lng[24].text = "Reset";
            lng[25].text = "Language";
            lng[26].text = "Apply";
            lng[27].text = "Inventory";
            for (int i = 0; i < 28; i++)
            {
                lng[i].font = ft[0];
            }
        }
        if (PlayerPrefs.GetInt("Language") == 1)
        {
            lng[0].text = "Zacząć grać";
            lng[1].text = "Instruktaż";
            lng[2].text = "Niekończące się poziomy";
            lng[3].text = "Budowniczy";
            lng[3].transform.localPosition = new Vector2(0, 4);
            lng[4].text = "Naukowiec";
            lng[4].transform.localPosition = new Vector2(0, 4);
            lng[5].text = "Duch lawy";
            lng[5].transform.localPosition = new Vector2(0, 4);
            lng[9].text = "Pokonaj bossa";
            lng[10].text = "Budowniczy";
            lng[10].transform.localPosition = new Vector2(0, 4);
            lng[11].text = "Naukowiec";
            lng[11].transform.localPosition = new Vector2(0, 4);
            lng[12].text = "Duch lawy";
            lng[12].transform.localPosition = new Vector2(0, 4);
            lng[16].text = "Sklep";
            lng[17].text = "Stwórz swoją grę";
            lng[18].text = "Klasyczny";
            lng[20].text = "Wybierz tryb";
            lng[21].text = "On";
            lng[22].text = "Off";
            lng[23].text = "Zmień układy przycisków";
            lng[24].text = "Resetowanie";
            lng[25].text = "Język";
            lng[26].text = "Zapisz";
            lng[27].text = "Spis";
            for (int i = 0; i < 28; i++)
            {
                lng[i].font = ft[1];
            }
        }
        if (PlayerPrefs.GetInt("Language") == 2)
        {
            lng[0].text = "Почати гру";
            lng[1].text = "Інструктаж";
            lng[2].text = "Нескінченний рівень";
            lng[3].text = "Будівельник";
            lng[3].transform.localPosition = new Vector2(0, 0);
            lng[4].text = "Вчений";
            lng[4].transform.localPosition = new Vector2(0, 0);
            lng[5].text = "Лавовий дух";
            lng[5].transform.localPosition = new Vector2(0, 0);
            lng[9].text = "Переможи боса";
            lng[10].text = "Будівельник";
            lng[10].transform.localPosition = new Vector2(0, 0);
            lng[11].text = "Вчений";
            lng[11].transform.localPosition = new Vector2(0, 0);
            lng[12].text = "Лавовий дух";
            lng[12].transform.localPosition = new Vector2(0, 0);
            lng[16].text = "Магазин";
            lng[17].text = "Створити свою гру";
            lng[18].text = "Класична гра";
            lng[20].text = "Вибрати режим";
            lng[21].text = "Вкл";
            lng[22].text = "Викл";
            lng[23].text = "Змінити положення кнопок";
            lng[24].text = "Повернути звичайне";
            lng[25].text = "Мова";
            lng[26].text = "Підтвердити";
            lng[27].text = "Кишеня";
            for (int i = 0; i < 28; i++)
            {
                lng[i].font = ft[2];
            }
        }
    }
    public void Levels()
    {
        lvs = 2;
        for (int i = 0; i < 25; i++)
        {
            if (i == 0 || i == 2 || i == 4 || i == 6 || i == 11 || i == 13 || i == 15 || i == 20)
            {
                cbais[i].GetComponent<Image>().color = Color.white;
            }
            else
            {
                if (i == 22 || i == 23 || i == 24)
                {
                    cbais[22].GetComponent<Image>().color = Color.black;
                    cbais[23].GetComponent<Text>().color = Color.green;
                    cbais[24].GetComponent<Text>().color = Color.green;
                }
                else
                {
                    cbais[i].GetComponent<Text>().color = Color.black;
                }
            }
        }
    }
    public void Tutorial()
    {
        lvs = 1;
        for (int i = 0; i < 25; i++)
        {
            if (i == 22 || i == 2 || i == 4 || i == 6 || i == 11 || i == 13 || i == 15 || i == 20)
            {
                cbais[i].GetComponent<Image>().color = Color.white;
            }
            else
            {
                if (i == 0 || i == 1)
                {
                    cbais[0].GetComponent<Image>().color = Color.black;
                    cbais[1].GetComponent<Text>().color = Color.green;
                }
                else
                {
                    cbais[i].GetComponent<Text>().color = Color.black;
                }
            }
        }
    }
    public void Choice()
    {
        bt[12].transform.position = new Vector3(transform.position.x, transform.position.y, 10000);
        bt[3].SetActive(true);
        bt[4].SetActive(true);
        bt[5].SetActive(true);
        txts[0].SetActive(true);
        txts[1].SetActive(true);
        txts[2].SetActive(true);
    }
    public void DTBChoice()
    {
        bt[12].transform.position = new Vector3(transform.position.x, transform.position.y, 10000);
        bt[6].SetActive(true);
        bt[7].SetActive(true);
        bt[8].SetActive(true);
        txts[3].SetActive(true);
        txts[4].SetActive(true);
        txts[5].SetActive(true);
    }
    public void Rain_Boss()
    {
        lvs = 3;
        for (int i = 0; i < 25; i++)
        {
            if (i == 0 || i == 22 || i == 4 || i == 6 || i == 11 || i == 13 || i == 15 || i == 20)
            {
                cbais[i].GetComponent<Image>().color = Color.white;
            }
            else
            {
                if (i == 2 || i == 3 || i == 8)
                {
                    cbais[2].GetComponent<Image>().color = Color.black;
                    cbais[3].GetComponent<Text>().color = Color.green;
                    cbais[8].GetComponent<Text>().color = Color.green;
                }
                else
                {
                    cbais[i].GetComponent<Text>().color = Color.black;
                }
            }
        }
    }
    public void Flip_Boss()
    {
        lvs = 4;
        for (int i = 0; i < 25; i++)
        {
            if (i == 0 || i == 2 || i == 22 || i == 6 || i == 11 || i == 13 || i == 15 || i == 20)
            {
                cbais[i].GetComponent<Image>().color = Color.white;
            }
            else
            {
                if (i == 4 || i == 5 || i == 9)
                {
                    cbais[4].GetComponent<Image>().color = Color.black;
                    cbais[5].GetComponent<Text>().color = Color.green;
                    cbais[9].GetComponent<Text>().color = Color.green;
                }
                else
                {
                    cbais[i].GetComponent<Text>().color = Color.black;
                }
            }
        }
    }
    public void Lava_Boss()
    {
        lvs = 5;
        for (int i = 0; i < 25; i++)
        {
            if (i == 0 || i == 2 || i == 4 || i == 22 || i == 11 || i == 13 || i == 15 || i == 20)
            {
                cbais[i].GetComponent<Image>().color = Color.white;
            }
            else
            {
                if (i == 6 || i == 7 || i == 10)
                {
                    cbais[6].GetComponent<Image>().color = Color.black;
                    cbais[7].GetComponent<Text>().color = Color.green;
                    cbais[10].GetComponent<Text>().color = Color.green;
                }
                else
                {
                    cbais[i].GetComponent<Text>().color = Color.black;
                }
            }
        }
    }
    public void Rain_Boss_Defeat()
    {
        lvs = 6;
        for (int i = 0; i < 25; i++)
        {
            if (i == 0 || i == 2 || i == 4 || i == 6 || i == 22 || i == 13 || i == 15 || i == 20)
            {
                cbais[i].GetComponent<Image>().color = Color.white;
            }
            else
            {
                if (i == 11 || i == 12 || i == 17)
                {
                    cbais[11].GetComponent<Image>().color = Color.black;
                    cbais[12].GetComponent<Text>().color = Color.green;
                    cbais[17].GetComponent<Text>().color = Color.green;
                }
                else
                {
                    cbais[i].GetComponent<Text>().color = Color.black;
                }
            }
        }
    }
    public void Flip_Boss_Defeat()
    {
        lvs = 7;
        for (int i = 0; i < 25; i++)
        {
            if (i == 0 || i == 2 || i == 4 || i == 6 || i == 11 || i == 22 || i == 15 || i == 20)
            {
                cbais[i].GetComponent<Image>().color = Color.white;
            }
            else
            {
                if (i == 13 || i == 14 || i == 18)
                {
                    cbais[13].GetComponent<Image>().color = Color.black;
                    cbais[14].GetComponent<Text>().color = Color.green;
                    cbais[18].GetComponent<Text>().color = Color.green;
                }
                else
                {
                    cbais[i].GetComponent<Text>().color = Color.black;
                }
            }
        }
    }
    public void Lava_Boss_Defeat()
    {
        lvs = 8;
        for (int i = 0; i < 25; i++)
        {
            if (i == 0 || i == 2 || i == 4 || i == 6 || i == 11 || i == 13 || i == 22 || i == 20)
            {
                cbais[i].GetComponent<Image>().color = Color.white;
            }
            else
            {
                if (i == 15 || i == 16 || i == 19)
                {
                    cbais[15].GetComponent<Image>().color = Color.black;
                    cbais[16].GetComponent<Text>().color = Color.green;
                    cbais[19].GetComponent<Text>().color = Color.green;
                }
                else
                {
                    cbais[i].GetComponent<Text>().color = Color.black;
                }
            }
        }
    }
    public void Op()
    {
        lvs = 9;
        for (int i = 0; i < 25; i++)
        {
            if (i == 0 || i == 2 || i == 4 || i == 6 || i == 11 || i == 13 || i == 15 || i == 22)
            {
                cbais[i].GetComponent<Image>().color = Color.white;
            }
            else
            {
                if (i == 20 || i == 21)
                {
                    cbais[20].GetComponent<Image>().color = Color.black;
                    cbais[21].GetComponent<Text>().color = Color.green;
                }
                else
                {
                    cbais[i].GetComponent<Text>().color = Color.black;
                }
            }
        }
    }
    public void Shop()
    {
        SceneManager.LoadScene(6);
    }
    public void Inventory()
    {
        SceneManager.LoadScene(7);
    }
    public void SM()
    {
        bt[0].SetActive(true);
        bt[1].SetActive(true);
        bt[2].SetActive(true);
        bt[9].SetActive(true);
        bt[10].SetActive(true);
        bt[11].SetActive(true);
        bt[14].SetActive(true);
        bt[12].transform.position = new Vector3(transform.position.x, transform.position.y, 10000);
        bt[13].SetActive(false);
        bt[15].SetActive(false);
        bt[16].SetActive(false);
        bt[17].SetActive(false);
        bt[18].SetActive(false);
        bt[22].SetActive(false);
        bt[33].SetActive(false);
        Event[0].SetActive(false);
        Event[1].SetActive(false);
    }
    public void Back()
    {
        bt[0].SetActive(false);
        bt[1].SetActive(false);
        bt[2].SetActive(false);
        bt[3].SetActive(false);
        bt[4].SetActive(false);
        bt[5].SetActive(false);
        bt[6].SetActive(false);
        bt[7].SetActive(false);
        bt[8].SetActive(false);
        bt[9].SetActive(false);
        bt[10].SetActive(false);
        bt[11].SetActive(false);
        bt[14].SetActive(false);
        txts[0].SetActive(false);
        txts[1].SetActive(false);
        txts[2].SetActive(false);
        txts[3].SetActive(false);
        txts[4].SetActive(false);
        txts[5].SetActive(false);
        bt[19].SetActive(false);
        bt[20].SetActive(false);
        bt[21].SetActive(false);
        bt[12].transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        bt[13].SetActive(true);
        bt[15].SetActive(true);
        bt[16].SetActive(true);
        bt[17].SetActive(true);
        bt[18].SetActive(true);
        bt[22].SetActive(true);
        bt[33].SetActive(true);
        if(PlayerPrefs.GetInt("Egg") >= 1)
        {
            Event[0].SetActive(true);
            Event[1].SetActive(true);
        }
        bt[25].SetActive(false);
        bt[28].SetActive(false);
        bt[29].SetActive(false);
        bt[30].SetActive(false);
        bt[34].SetActive(false);
    }
    public void Setting()
    {
        bt[12].transform.position = new Vector3(transform.position.x, transform.position.y, 10000);
        bt[13].SetActive(false);
        bt[15].SetActive(false);
        bt[16].SetActive(false);
        bt[17].SetActive(false);
        bt[18].SetActive(false);
        bt[22].SetActive(false);
        bt[33].SetActive(false);
        bt[14].SetActive(true);
        bt[19].SetActive(true);
        bt[20].SetActive(true);
        bt[21].SetActive(true);
        bt[25].SetActive(true);
        bt[28].SetActive(true);
        Event[0].SetActive(false);
        Event[1].SetActive(false);
    }
    public void Language()
    {
        bt[29].SetActive(true);
        bt[30].SetActive(true);
        bt[34].SetActive(true);
    }
    public void English()
    {
        PlayerPrefs.SetInt("Language", 0);
        bt[29].GetComponent<Image>().color = Color.black;
        bt[31].GetComponent<Text>().color = Color.green;
        bt[30].GetComponent<Image>().color = Color.white;
        bt[32].GetComponent<Text>().color = Color.black;
        bt[34].GetComponent<Image>().color = Color.white;
        bt[35].GetComponent<Text>().color = Color.black;
        lng[6].text = "Seconds: ";
        lng[6].transform.localPosition = new Vector2(23, 70);
        lng[7].text = "Seconds: ";
        lng[7].transform.localPosition = new Vector2(23, -30);
        lng[8].text = "Seconds: ";
        lng[8].transform.localPosition = new Vector2(23, -130);
        lng[13].text = "Level: ";
        lng[13].transform.localPosition = new Vector2(lng[13].transform.localPosition.x, 70);
        lng[14].text = "Level: ";
        lng[14].transform.localPosition = new Vector2(lng[14].transform.localPosition.x, -30);
        lng[15].text = "Level: ";
        lng[15].transform.localPosition = new Vector2(lng[15].transform.localPosition.x, -130);
        lng[19].text = "Level: ";
        lv = PlayerPrefs.GetFloat("Level");
        txt.text = txt.text + lv;
        best[0] = PlayerPrefs.GetFloat("Best_Score_1");
        best[1] = PlayerPrefs.GetFloat("Best_Score_2");
        best[2] = PlayerPrefs.GetFloat("Best_Score_3");
        best[3] = PlayerPrefs.GetFloat("Level_Defeat_1");
        best[4] = PlayerPrefs.GetFloat("Level_Defeat_2");
        best[5] = PlayerPrefs.GetFloat("Level_Defeat_3");
        texts[0].text = texts[0].text + best[0].ToString("0");
        texts[1].text = texts[1].text + best[1].ToString("0");
        texts[2].text = texts[2].text + best[2].ToString("0");
        texts[3].text = texts[3].text + best[3].ToString("0");
        texts[4].text = texts[4].text + best[4].ToString("0");
        texts[5].text = texts[5].text + best[5].ToString("0");
    }
    public void Polish()
    {
        PlayerPrefs.SetInt("Language", 1);
        bt[29].GetComponent<Image>().color = Color.white;
        bt[31].GetComponent<Text>().color = Color.black;
        bt[30].GetComponent<Image>().color = Color.black;
        bt[32].GetComponent<Text>().color = Color.green;
        bt[34].GetComponent<Image>().color = Color.white;
        bt[35].GetComponent<Text>().color = Color.black;
        lng[6].text = "Wniosek: ";
        lng[6].transform.localPosition = new Vector2(23, 76);
        lng[7].text = "Wniosek: ";
        lng[7].transform.localPosition = new Vector2(23, -24);
        lng[8].text = "Wniosek: ";
        lng[8].transform.localPosition = new Vector2(23, -124);
        lng[13].text = "Poziom: ";
        lng[13].transform.localPosition = new Vector2(lng[13].transform.localPosition.x, 76);
        lng[14].text = "Poziom: ";
        lng[14].transform.localPosition = new Vector2(lng[14].transform.localPosition.x, -24);
        lng[15].text = "Poziom: ";
        lng[15].transform.localPosition = new Vector2(lng[15].transform.localPosition.x, -124);
        lng[19].text = "Poziom: ";
        lv = PlayerPrefs.GetFloat("Level");
        txt.text = txt.text + lv;
        best[0] = PlayerPrefs.GetFloat("Best_Score_1");
        best[1] = PlayerPrefs.GetFloat("Best_Score_2");
        best[2] = PlayerPrefs.GetFloat("Best_Score_3");
        best[3] = PlayerPrefs.GetFloat("Level_Defeat_1");
        best[4] = PlayerPrefs.GetFloat("Level_Defeat_2");
        best[5] = PlayerPrefs.GetFloat("Level_Defeat_3");
        texts[0].text = texts[0].text + best[0].ToString("0");
        texts[1].text = texts[1].text + best[1].ToString("0");
        texts[2].text = texts[2].text + best[2].ToString("0");
        texts[3].text = texts[3].text + best[3].ToString("0");
        texts[4].text = texts[4].text + best[4].ToString("0");
        texts[5].text = texts[5].text + best[5].ToString("0");
    }
    public void Ukrainian()
    {
        PlayerPrefs.SetInt("Language", 2);
        bt[29].GetComponent<Image>().color = Color.white;
        bt[31].GetComponent<Text>().color = Color.black;
        bt[30].GetComponent<Image>().color = Color.white;
        bt[32].GetComponent<Text>().color = Color.black;
        bt[34].GetComponent<Image>().color = Color.black;
        bt[35].GetComponent<Text>().color = Color.green;
        lng[6].text = "Секунд: ";
        lng[6].transform.localPosition = new Vector2(60, 73);
        lng[7].text = "Секунд: ";
        lng[7].transform.localPosition = new Vector2(60, -27);
        lng[8].text = "Секунд: ";
        lng[8].transform.localPosition = new Vector2(60, -127);
        lng[13].text = "Рівень: ";
        lng[13].transform.localPosition = new Vector2(lng[13].transform.localPosition.x + 5, 73);
        lng[14].text = "Рівень: ";
        lng[14].transform.localPosition = new Vector2(lng[14].transform.localPosition.x + 5, -27);
        lng[15].text = "Рівень: ";
        lng[15].transform.localPosition = new Vector2(lng[15].transform.localPosition.x + 5, -127);
        lng[19].text = "Рівень: ";
        lv = PlayerPrefs.GetFloat("Level");
        txt.text = txt.text + lv;
        best[0] = PlayerPrefs.GetFloat("Best_Score_1");
        best[1] = PlayerPrefs.GetFloat("Best_Score_2");
        best[2] = PlayerPrefs.GetFloat("Best_Score_3");
        best[3] = PlayerPrefs.GetFloat("Level_Defeat_1");
        best[4] = PlayerPrefs.GetFloat("Level_Defeat_2");
        best[5] = PlayerPrefs.GetFloat("Level_Defeat_3");
        texts[0].text = texts[0].text + best[0].ToString("0");
        texts[1].text = texts[1].text + best[1].ToString("0");
        texts[2].text = texts[2].text + best[2].ToString("0");
        texts[3].text = texts[3].text + best[3].ToString("0");
        texts[4].text = texts[4].text + best[4].ToString("0");
        texts[5].text = texts[5].text + best[5].ToString("0");
    }
    public void CBL()
    {
        apl2 = true;
        if (apl == false && apl2 == true)
        {
            bt[23].SetActive(true);
            bt[24].SetActive(true);
            bt[21].SetActive(false);
            bt[20].SetActive(false);
            bt[19].SetActive(false);
            bt[14].SetActive(false);
            bt[25].SetActive(false);
            bt[26].SetActive(true);
            bt[27].SetActive(true);
            bt[28].SetActive(false);
            bt[29].SetActive(false);
            bt[30].SetActive(false);
            bt[34].SetActive(false);
            apl = true;
            apl2 = false;
        }
        if (apl == true && apl2 == true)
        {
            bt[23].SetActive(false);
            bt[24].SetActive(false);
            bt[21].SetActive(true);
            bt[20].SetActive(true);
            bt[19].SetActive(true);
            bt[14].SetActive(true);
            bt[25].SetActive(true);
            bt[26].SetActive(false);
            bt[27].SetActive(false);
            bt[28].SetActive(true);
            bt[29].SetActive(true);
            bt[30].SetActive(true);
            bt[34].SetActive(true);
            apl = false;
            apl2 = false;
        }
    }
    public void Play()
    {
        if (lvs == 1)
        {
            SceneManager.LoadScene(3);
        }
        if (lvs == 2)
        {
            PlayerPrefs.SetInt("Pick", 0);
            PlayerPrefs.SetInt("Selection", 0);
            SceneManager.LoadScene(2);
        }
        if (lvs == 3)
        {
            PlayerPrefs.SetInt("Pick", 0);
            PlayerPrefs.SetInt("Selection", 0);
            PlayerPrefs.SetInt("WB", 1);
            SceneManager.LoadScene(4);
        }
        if (lvs == 4)
        {
            PlayerPrefs.SetInt("Pick", 0);
            PlayerPrefs.SetInt("Selection", 0);
            PlayerPrefs.SetInt("WB", 2);
            SceneManager.LoadScene(4);
        }
        if (lvs == 5)
        {
            PlayerPrefs.SetInt("Pick", 0);
            PlayerPrefs.SetInt("Selection", 0);
            PlayerPrefs.SetInt("WB", 3);
            SceneManager.LoadScene(4);
        }
        if (lvs == 6)
        {
            PlayerPrefs.SetInt("Pick", 0);
            PlayerPrefs.SetInt("Selection", 0);
            PlayerPrefs.SetInt("WBD", 1);
            SceneManager.LoadScene(5);
        }
        if (lvs == 7)
        {
            PlayerPrefs.SetInt("Pick", 0);
            PlayerPrefs.SetInt("Selection", 0);
            PlayerPrefs.SetInt("WBD", 2);
            SceneManager.LoadScene(5);
        }
        if (lvs == 8)
        {
            PlayerPrefs.SetInt("Pick", 0);
            PlayerPrefs.SetInt("Selection", 0);
            PlayerPrefs.SetInt("WBD", 3);
            SceneManager.LoadScene(5);
        }
        if (lvs == 9)
        {
            opt.SetActive(true);
            bt[12].transform.position = new Vector3(transform.position.x, transform.position.y, 10000);
            bt[13].SetActive(false);
            bt[15].SetActive(false);
            bt[16].SetActive(false);
            bt[17].SetActive(false);
            bt[18].SetActive(false);
            bt[22].SetActive(false);
            bt[33].SetActive(false);
            Event[0].SetActive(false);
            Event[1].SetActive(false);
        }
    }
    public void Ons()
    {
        au.Play();
        bt[20].GetComponent<Image>().color = Color.black;
        bt[21].GetComponent<Image>().color = Color.white;
        texts[6].color = Color.green;
        texts[7].color = Color.black;
        PlayerPrefs.SetInt("Sound", 0);
    }
    public void Offs()
    {
        au.Stop();
        bt[21].GetComponent<Image>().color = Color.black;
        bt[20].GetComponent<Image>().color = Color.white;
        texts[7].color = Color.green;
        texts[6].color = Color.black;
        PlayerPrefs.SetInt("Sound", 1);
    }
    public void Resets()
    {
        PlayerPrefs.SetFloat("JBX", 520);
        PlayerPrefs.SetFloat("JBY", -240);
        bt[24].transform.localPosition = new Vector3(PlayerPrefs.GetFloat("JBX"), PlayerPrefs.GetFloat("JBY"), 0);
        PlayerPrefs.SetFloat("FJX", -520);
        PlayerPrefs.SetFloat("FJY", -240);
        bt[23].transform.localPosition = new Vector3(PlayerPrefs.GetFloat("FJX"), PlayerPrefs.GetFloat("FJY"), 0);
    }
    IEnumerator wait()
    {
        moffon = true;
        au.clip = sound;
        float ms = Random.Range(0, 106);
        au.time = ms;
        Debug.Log(ms);
        au.Play();
        yield return new WaitForSeconds(106 - ms);
        moffon = false;
    }
}
