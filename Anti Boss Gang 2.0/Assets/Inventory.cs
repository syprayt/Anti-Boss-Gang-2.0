using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Inventory : MonoBehaviour
{
    public Button[] skins;
    public GameObject[] locks;
    public void Start()
    {
        if (PlayerPrefs.GetInt("Purple") == 1)
        {
            locks[0].SetActive(false);
            skins[1].GetComponent<Image>().color = Color.white;
        }
        if (PlayerPrefs.GetInt("Black") == 1)
        {
            locks[1].SetActive(false);
            skins[2].GetComponent<Image>().color = Color.white;
        }
        if (PlayerPrefs.GetInt("Blue") == 1)
        {
            locks[2].SetActive(false);
            skins[3].GetComponent<Image>().color = Color.white;
        }
        if (PlayerPrefs.GetInt("Easter") == 1)
        {
            locks[3].SetActive(false);
            skins[4].GetComponent<Image>().color = Color.white;
        }
        if (PlayerPrefs.GetInt("Emo") == 1)
        {
            locks[4].SetActive(false);
            skins[5].GetComponent<Image>().color = Color.white;
        }
        if (PlayerPrefs.GetFloat("Skin") == 0)
        {
            skins[0].transform.localPosition = new Vector3(-315, 0, 0);
            skins[0].transform.localScale = new Vector3(3, 3, 1);
        }
        if (PlayerPrefs.GetFloat("Skin") == 1)
        {
            skins[1].transform.localPosition = new Vector3(-315, 0, 0);
            skins[1].transform.localScale = new Vector3(3, 3, 1);
        }
        if (PlayerPrefs.GetFloat("Skin") == 2)
        {
            skins[2].transform.localPosition = new Vector3(-315, 0, 0);
            skins[2].transform.localScale = new Vector3(3, 3, 1);
        }
        if (PlayerPrefs.GetFloat("Skin") == 3)
        {
            skins[3].transform.localPosition = new Vector3(-315, 0, 0);
            skins[3].transform.localScale = new Vector3(3, 3, 1);
        }
        if (PlayerPrefs.GetFloat("Skin") == 4)
        {
            skins[4].transform.localPosition = new Vector3(-315, 0, 0);
            skins[4].transform.localScale = new Vector3(3, 3, 1);
        }
        if (PlayerPrefs.GetFloat("Skin") == 5)
        {
            skins[5].transform.localPosition = new Vector3(-315, 0, 0);
            skins[5].transform.localScale = new Vector3(3, 3, 1);
        }
    }
    public void Back()
    {
        SceneManager.LoadScene(1);
    }
    private void Reset_0()
    {
        skins[0].transform.localPosition = new Vector3(80, 230, 0);
        skins[0].transform.localScale = new Vector3(1.5f, 1.5f, 1);
    }
    private void Reset_1()
    {
        skins[1].transform.localPosition = new Vector3(270, 230, 0);
        skins[1].transform.localScale = new Vector3(1.5f, 1.5f, 1);
    }
    private void Reset_2()
    {
        skins[2].transform.localPosition = new Vector3(500, 230, 0);
        skins[2].transform.localScale = new Vector3(1.5f, 1.5f, 1);
    }
    private void Reset_3()
    {
        skins[3].transform.localPosition = new Vector3(80, 70, 0);
        skins[3].transform.localScale = new Vector3(1.5f, 1.5f, 1);
    }
    private void Reset_4()
    {
        skins[4].transform.localPosition = new Vector3(270, 70, 0);
        skins[4].transform.localScale = new Vector3(1.5f, 1.5f, 1);
    }
    private void Reset_5()
    {
        skins[5].transform.localPosition = new Vector3(500, 70, 0);
        skins[5].transform.localScale = new Vector3(1.5f, 1.5f, 1);
    }
    public void MainCharacter()
    {
        skins[0].transform.localPosition = new Vector3(-315, 0, 0);
        skins[0].transform.localScale = new Vector3(3, 3, 1);
        PlayerPrefs.SetFloat("Skin", 0);
        Reset_1();
        Reset_2();
        Reset_3();
        Reset_4();
        Reset_5();
    }
    public void Ice()
    {
        if (PlayerPrefs.GetInt("Purple") == 1)
        { 
            skins[1].transform.localPosition = new Vector3(-315, 0, 0);
            skins[1].transform.localScale = new Vector3(3, 3, 1);
            PlayerPrefs.SetFloat("Skin", 1);
            Reset_0();
            Reset_2();
            Reset_3();
            Reset_4();
            Reset_5();
        }
    }
    public void Cyborg()
    {
        if (PlayerPrefs.GetInt("Black") == 1)
        {
            skins[2].transform.localPosition = new Vector3(-315, 0, 0);
            skins[2].transform.localScale = new Vector3(3, 3, 1);
            PlayerPrefs.SetFloat("Skin", 2);
            Reset_1();
            Reset_0();
            Reset_3();
            Reset_4();
            Reset_5();
        }
    }
    public void Robot()
    {
        if (PlayerPrefs.GetInt("Blue") == 1)
        {
            skins[3].transform.localPosition = new Vector3(-315, 0, 0);
            skins[3].transform.localScale = new Vector3(3, 3, 1);
            PlayerPrefs.SetFloat("Skin", 3);
            Reset_1();
            Reset_2();
            Reset_0();
            Reset_4();
            Reset_5();
        }
    }
    public void Easter()
    {
        if (PlayerPrefs.GetInt("Easter") == 1)
        {
            skins[4].transform.localPosition = new Vector3(-315, 0, 0);
            skins[4].transform.localScale = new Vector3(3, 3, 1);
            PlayerPrefs.SetFloat("Skin", 4);
            Reset_1();
            Reset_2();
            Reset_3();
            Reset_0();
            Reset_5();
        }
    }
    public void Emo()
    {
        if (PlayerPrefs.GetInt("Emo") == 1)
        {
            skins[5].transform.localPosition = new Vector3(-315, 0, 0);
            skins[5].transform.localScale = new Vector3(3, 3, 1);
            PlayerPrefs.SetFloat("Skin", 5);
            Reset_1();
            Reset_2();
            Reset_3();
            Reset_0();
            Reset_4();
        }
    }
}
