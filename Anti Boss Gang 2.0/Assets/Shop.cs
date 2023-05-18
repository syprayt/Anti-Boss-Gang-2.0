using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Shop : MonoBehaviour
{
    public float coin;
    public Text txt;
    public Text[] names;
    public AudioSource au;
    public AudioClip sound;
    public bool moffon;
    public Text[] lng;
    public Font[] ft;
    public GameObject[] skins;
    public GameObject[] skins_button;
    public bool rw;
    public GameObject window;
    public GameObject[] Event;
    public void Update()
    {
        coin = PlayerPrefs.GetFloat("Coin");
        if (rw == true)
        {
            coin += Random.Range(9, 20);
            PlayerPrefs.SetFloat("Coin", coin);
            rw = false;
        }
        txt.text = "" + coin.ToString("0");
        if (PlayerPrefs.GetInt("Emo") == 1)
        {
            skins_button[0].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Egg") >= 1)
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
        if (PlayerPrefs.GetInt("Purple") == 1)
        {
            skins_button[1].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Black") == 1)
        {
            skins_button[2].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Blue") == 1)
        {
            skins_button[3].SetActive(false);
        }
        if (moffon == false && PlayerPrefs.GetInt("Sound") == 0)
        {
            StartCoroutine(wait());
        }
        if (PlayerPrefs.GetInt("Language") == 0)
        {
            lng[0].text = "Back";
            lng[1].text = "Free coin";
            lng[1].fontSize = 20;
            lng[2].text = "Buy for";
            for (int i = 0; i < 3; i++)
            {
                lng[i].font = ft[0];
            }
        }
        if (PlayerPrefs.GetInt("Language") == 1)
        {
            lng[0].text = "Z powrotem";
            lng[1].text = "Darmowe monety";
            lng[1].fontSize = 15;
            lng[2].text = "kupić dla";
            for (int i = 0; i < 3; i++)
            {
                lng[i].font = ft[1];
            }
        }
        if (PlayerPrefs.GetInt("Language") == 2)
        {
            lng[0].text = "Назад";
            lng[1].text = "Дарові монети";
            lng[1].fontSize = 17;
            lng[2].text = "Купити для";
            for (int i = 0; i < 3; i++)
            {
                lng[i].font = ft[2];
            }
        }
    }
    public void Easter()
    {
        window.SetActive(true);
    }
    public void Easter_coin()
    {
        if (coin >= 150 && PlayerPrefs.GetInt("Easter") == 0)
        {
            coin -= 150;
            PlayerPrefs.SetInt("Easter", 1);
            PlayerPrefs.SetFloat("Coin", coin);
            window.SetActive(false);
        }
    }
    public void Easter_egg()
    {
        if (PlayerPrefs.GetInt("Egg") >= 1 && PlayerPrefs.GetInt("Easter") == 0)
        {
            PlayerPrefs.SetInt("Egg", PlayerPrefs.GetInt("Egg") - 1);
            PlayerPrefs.SetInt("Easter", 1);
            window.SetActive(false);
        }
    }
    public void Cross()
    {
        window.SetActive(false);
    }
    public void Ice()
    {
        if (coin >= 300 && PlayerPrefs.GetInt("Purple") == 0)
        {
            coin -= 300;
            PlayerPrefs.SetInt("Purple", 1);
            PlayerPrefs.SetFloat("Coin", coin);
        }
    }
    public void Emo()
    {
        if (coin >= 300 && PlayerPrefs.GetInt("Emo") == 0)
        {
            coin -= 300;
            PlayerPrefs.SetInt("Emo", 1);
            PlayerPrefs.SetFloat("Coin", coin);
        }
    }
    public void Cyborg()
    {
        if (coin >= 500 && PlayerPrefs.GetInt("Black") == 0)
        {
            coin -= 500;
            PlayerPrefs.SetInt("Black", 1);
            PlayerPrefs.SetFloat("Coin", coin);
        }
    }
    public void Robot()
    {
        if (coin >= 1000 && PlayerPrefs.GetInt("Blue") == 0)
        {
            coin -= 1000;
            PlayerPrefs.SetInt("Blue", 1);
            PlayerPrefs.SetFloat("Coin", coin);
        }
    }
    public void Back()
    {
        SceneManager.LoadScene(1);
    }
    IEnumerator wait()
    {
        moffon = true;
        au.clip = sound;
        float ms = Random.Range(0, 106);
        au.time = ms;
        au.Play();
        yield return new WaitForSeconds(106 - ms);
        moffon = false;
    }
}
