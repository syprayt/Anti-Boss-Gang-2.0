using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Option : MonoBehaviour
{
    public RawImage[] img;
    public GameObject[] sa;
    public NativeGallery.MediaPickCallback mv;
    public GameObject[] hide;
    public GameObject seek;
    public Text[] txt;
    public float[] sec;
    public GameObject bg;
    public GameObject[] tm;
    public GameObject[] mode;
    public GameObject[] vkl;
    public bool settings = true;
    public int boss = 0;
    public int modes = 0;
    public GameObject error;
    public InputField[] ifs;
    public GameObject[] Imag;
    public bool images = true;
    public bool[] ib;
    public Text[] lng;
    public Font[] ft;
    public void Update()
    {
        if (PlayerPrefs.GetInt("Language") == 0)
        {
            lng[0].text = "Boss:";
            lng[1].text = "Builder";
            lng[2].text = "Scientist";
            lng[3].text = "Lava spirit";
            lng[4].text = "Mode:";
            lng[5].text = "Classic mode";
            lng[6].text = "Endless Level";
            lng[7].text = "Defeat Boss Level";
            lng[8].text = "Time between \n events:";
            lng[9].text = "From:";
            lng[9].transform.localPosition = new Vector2(-125, -75);
            lng[10].text = "Back";
            lng[11].text = "To:";
            lng[11].transform.localPosition = new Vector2(lng[11].transform.localPosition.x, -75);
            lng[12].text = "Play";
            lng[13].text = "Event:";
            lng[14].text = "Some parameter is \n too low";
            lng[15].text = "max: 7 letters";
            lng[16].text = "max: 7 letters";
            lng[17].text = "max: 7 letters";
            lng[18].text = "max: 7 letters";
            lng[19].text = "max: 7 letters";
            lng[20].text = "First words";
            lng[21].text = "Second words";
            lng[22].text = "Third words";
            lng[23].text = "Fourth words";
            lng[24].text = "Fifth words";
            lng[25].text = "You";
            lng[25].transform.localPosition = new Vector2(602, -10);
            lng[26].text = "Enemy";
            lng[26].transform.localPosition = new Vector2(585, 155);
            lng[27].text = "Drop item";
            lng[27].transform.localPosition = new Vector2(550, 330);
            lng[28].text = "Image:";
            lng[29].text = "Image";
            lng[30].text = "Image";
            lng[31].text = "Image";
            for (int i = 0; i < 32; i++)
            {
                lng[i].font = ft[0];
            }
        }
        if (PlayerPrefs.GetInt("Language") == 1)
        {
            lng[0].text = "Boss:";
            lng[1].text = "Budowniczy";
            lng[2].text = "Naukowiec";
            lng[3].text = "Duch lawy";
            lng[4].text = "Tryb:";
            lng[5].text = "Klasyczny";
            lng[6].text = "Niekończące się poziomy";
            lng[7].text = "Pokonaj bossa";
            lng[8].text = "Czas między \n wydarzeniami: ";
            lng[9].text = "Od:";
            lng[9].transform.localPosition = new Vector2(-50, -70);
            lng[10].text = "Z powrotem";
            lng[11].text = "Do:";
            lng[11].transform.localPosition = new Vector2(lng[11].transform.localPosition.x, -65);
            lng[12].text = "Bawić się";
            lng[13].text = "Wydarze \n nie:";
            lng[14].text = "Niektóre parametry są \n za niskie";
            lng[15].text = "maksymalnie: 7 liter";
            lng[16].text = "maksymalnie: 7 liter";
            lng[17].text = "maksymalnie: 7 liter";
            lng[18].text = "maksymalnie: 7 liter";
            lng[19].text = "maksymalnie: 7 liter";
            lng[20].text = "Pierwsze słowa";
            lng[21].text = "Drugie słowa";
            lng[22].text = "Trzecie słowa";
            lng[23].text = "Czwarte słowa";
            lng[24].text = "Piąte słowa";
            lng[25].text = "Ty";
            lng[25].transform.localPosition = new Vector2(620, -10);
            lng[26].text = "Wróg";
            lng[26].transform.localPosition = new Vector2(600, 165);
            lng[27].text = "Upuść przedmiot";
            lng[27].transform.localPosition = new Vector2(600, 330);
            lng[28].text = "Obraz:";
            lng[29].text = "Obraz";
            lng[30].text = "Obraz";
            lng[31].text = "Obraz";
            for (int i = 0; i < 32; i++)
            {
                lng[i].font = ft[1];
            }
        }
        if (PlayerPrefs.GetInt("Language") == 2)
        {
            lng[0].text = "Босс:";
            lng[1].text = "Будівельник";
            lng[2].text = "Вчений";
            lng[3].text = "Лавовий дух";
            lng[4].text = "Режим:";
            lng[5].text = "Класичний режим";
            lng[6].text = "Нескінченний рівень";
            lng[7].text = "Переможи босса";
            lng[8].text = "Час між \n подіями:";
            lng[9].text = "Від:";
            lng[9].transform.localPosition = new Vector2(-125, -75);
            lng[10].text = "Назад";
            lng[11].text = "До:";
            lng[11].transform.localPosition = new Vector2(lng[11].transform.localPosition.x, -75);
            lng[12].text = "Грати";
            lng[13].text = "Події:";
            lng[14].text = "Якість параметри \n низькі";
            lng[15].text = "максимум: 7 букв";
            lng[16].text = "максимум: 7 букв";
            lng[17].text = "максимум: 7 букв";
            lng[18].text = "максимум: 7 букв";
            lng[19].text = "максимум: 7 букв";
            lng[20].text = "Перше слово";
            lng[21].text = "Друге слово";
            lng[22].text = "Третє слово";
            lng[23].text = "Четверте слово";
            lng[24].text = "П'яте слово";
            lng[25].text = "Ти";
            lng[25].transform.localPosition = new Vector2(620, -10);
            lng[26].text = "Ворог";
            lng[26].transform.localPosition = new Vector2(600, 155);
            lng[27].text = "Предмет";
            lng[27].transform.localPosition = new Vector2(580, 330);
            lng[28].text = "Мал:";
            lng[29].text = "Малюнок";
            lng[30].text = "Малюнок";
            lng[31].text = "Малюнок";
            for (int i = 0; i < 32; i++)
            {
                lng[i].font = ft[2];
            }
        }
    }
    public void Photo_1()
    {
        NativeGallery.Permission permission = NativeGallery.GetImageFromGallery((path) =>
        {
            Debug.Log("Image path: " + path);
            if (path != null)
            {
                Texture2D texture = NativeGallery.LoadImageAtPath(path, 300);
                if (texture == null)
                {
                    Debug.Log("Couldn't load texture from " + path);
                    return;
                }
                else
                {
                    img[0].texture = texture;
                    sa[0].gameObject.GetComponent<SpriteRenderer>().sprite = Sprite.Create(texture, new Rect(0, 0, 100, 100), new Vector2());
                }
            }
        }, "Select a PNG image", "image/png");
        ib[0] = true;
    }
    public void Photo_2()
    {
        NativeGallery.Permission permission = NativeGallery.GetImageFromGallery((path) =>
        {
            Debug.Log("Image path: " + path);
            if (path != null)
            {
                Texture2D texture = NativeGallery.LoadImageAtPath(path, 300);
                if (texture == null)
                {
                    Debug.Log("Couldn't load texture from " + path);
                    return;
                }
                else
                {
                    img[1].texture = texture;
                    sa[1].gameObject.GetComponent<SpriteRenderer>().sprite = Sprite.Create(texture, new Rect(0, 0, 150, 200), new Vector2());
                }
            }
        }, "Select a PNG image", "image/png");
        ib[1] = true;
    }
    public void Photo_3()
    {
        NativeGallery.Permission permission = NativeGallery.GetImageFromGallery((path) =>
        {
            Debug.Log("Image path: " + path);
            if (path != null)
            {
                Texture2D texture = NativeGallery.LoadImageAtPath(path, 300);
                if (texture == null)
                {
                    Debug.Log("Couldn't load texture from " + path);
                    return;
                }
                else
                {
                    img[2].texture = texture;
                    sa[2].gameObject.GetComponent<SpriteRenderer>().sprite = Sprite.Create(texture, new Rect(0, 0, 150, 300), new Vector2());
                }
            }
        }, "Select a PNG image", "image/png");
        ib[2] = true;
    }
    public void Backs()
    {
        hide[0].transform.position = new Vector3(hide[0].transform.position.x, hide[0].transform.position.y, 0);
        hide[1].SetActive(true);
        hide[2].SetActive(true);
        hide[3].SetActive(true);
        hide[4].SetActive(true);
        hide[5].SetActive(true);
        hide[6].SetActive(true);
        hide[7].SetActive(true);
        if(PlayerPrefs.GetInt("Easter") >= 1)
        {
            hide[8].SetActive(true);
            hide[9].SetActive(true);
        }
        seek.SetActive(false);
        vkl[25].transform.position = new Vector3(50, 4, 0);
    }
    public void Plus()
    {
        sec[0] += 1;
        txt[0].text = "" + sec[0];
    }
    public void Plus_1()
    {
        sec[1] += 1;
        txt[1].text = "" + sec[1];
    }
    public void Plus_2()
    {
        sec[2] += 1;
        txt[2].text = "" + sec[2];
    }
    public void Plus_3()
    {
        sec[3] += 1;
        txt[3].text = "" + sec[3];
    }
    public void Minus()
    {
        sec[0] -= 1;
        txt[0].text = "" + sec[0];
    }
    public void Minus_1()
    {
        sec[1] -= 1;
        txt[1].text = "" + sec[1];
    }
    public void Minus_2()
    {
        sec[2] -= 1;
        txt[2].text = "" + sec[2];
    }
    public void Minus_3()
    {
        sec[3] -= 1;
        txt[3].text = "" + sec[3];
    }
    public void Meteor()
    {
        bg.transform.localPosition = new Vector2(-300, 322);
        boss = 1;
    }
    public void Flip()
    {
        bg.transform.localPosition = new Vector2(0, 322);
        boss = 2;
    }
    public void Lava()
    {
        bg.transform.localPosition = new Vector2(300, 322);
        boss = 3;
    }
    public void LOT()
    {
        tm[0].SetActive(true);
        tm[1].SetActive(true);
        tm[2].SetActive(true);
        tm[3].SetActive(true);
        tm[4].SetActive(true);
        tm[5].SetActive(false);
        tm[6].SetActive(false);
        tm[7].SetActive(false);
        tm[8].SetActive(false);
        tm[9].SetActive(false);
        mode[0].GetComponent<Image>().color = Color.black;
        mode[1].GetComponent<Text>().color = Color.green;
        mode[2].GetComponent<Image>().color = Color.white;
        mode[3].GetComponent<Text>().color = Color.black;
        mode[4].GetComponent<Image>().color = Color.white;
        mode[5].GetComponent<Text>().color = Color.black;
        modes = 1;
    }
    public void EL()
    {
        tm[0].SetActive(false);
        tm[1].SetActive(false);
        tm[2].SetActive(false);
        tm[3].SetActive(false);
        tm[4].SetActive(false);
        tm[5].SetActive(false);
        tm[6].SetActive(false);
        tm[7].SetActive(false);
        tm[8].SetActive(false);
        tm[9].SetActive(false);
        mode[0].GetComponent<Image>().color = Color.white;
        mode[1].GetComponent<Text>().color = Color.black;
        mode[2].GetComponent<Image>().color = Color.black;
        mode[3].GetComponent<Text>().color = Color.green;
        mode[4].GetComponent<Image>().color = Color.white;
        mode[5].GetComponent<Text>().color = Color.black;
        modes = 2;
    }
    public void DBL()
    {
        tm[0].SetActive(false);
        tm[1].SetActive(false);
        tm[2].SetActive(false);
        tm[3].SetActive(false);
        tm[4].SetActive(false);
        tm[5].SetActive(true);
        tm[6].SetActive(true);
        tm[7].SetActive(true);
        tm[8].SetActive(true);
        tm[9].SetActive(true);
        mode[0].GetComponent<Image>().color = Color.white;
        mode[1].GetComponent<Text>().color = Color.black;
        mode[2].GetComponent<Image>().color = Color.white;
        mode[3].GetComponent<Text>().color = Color.black;
        mode[4].GetComponent<Image>().color = Color.black;
        mode[5].GetComponent<Text>().color = Color.green;
        modes = 3;
    }
    public void OFF()
    {
        vkl[0].SetActive(false);
        vkl[1].SetActive(false);
        vkl[2].SetActive(false);
        vkl[3].SetActive(false);
        vkl[4].SetActive(false);
        vkl[5].SetActive(false);
        vkl[6].SetActive(false);
        vkl[7].SetActive(false);
        vkl[8].SetActive(false);
        vkl[9].SetActive(false);
        vkl[10].SetActive(false);
        vkl[11].SetActive(false);
        vkl[12].SetActive(false);
        vkl[13].SetActive(false);
        vkl[14].SetActive(false);
        vkl[15].SetActive(false);
        vkl[16].SetActive(false);
        vkl[17].SetActive(false);
        vkl[18].SetActive(false);
        vkl[19].SetActive(false);
        vkl[20].SetActive(false);
        vkl[21].GetComponent<Image>().color = Color.black;
        vkl[22].GetComponent<Text>().color = Color.green;
        vkl[23].GetComponent<Image>().color = Color.white;
        vkl[24].GetComponent<Text>().color = Color.black;
        settings = false;
    }

    public void ON()
    {
        vkl[0].SetActive(true);
        vkl[1].SetActive(true);
        vkl[2].SetActive(true);
        vkl[3].SetActive(true);
        vkl[4].SetActive(true);
        vkl[5].SetActive(true);
        vkl[6].SetActive(true);
        vkl[7].SetActive(true);
        vkl[8].SetActive(true);
        vkl[9].SetActive(true);
        vkl[10].SetActive(true);
        vkl[11].SetActive(true);
        vkl[12].SetActive(true);
        vkl[13].SetActive(true);
        vkl[14].SetActive(true);
        vkl[15].SetActive(true);
        vkl[16].SetActive(true);
        vkl[17].SetActive(true);
        vkl[18].SetActive(true);
        vkl[19].SetActive(true);
        vkl[20].SetActive(true);
        vkl[21].GetComponent<Image>().color = Color.white;
        vkl[22].GetComponent<Text>().color = Color.black;
        vkl[23].GetComponent<Image>().color = Color.black;
        vkl[24].GetComponent<Text>().color = Color.green;
        settings = true;
    }
    public void OnI()
    {
        Imag[0].SetActive(true);
        Imag[1].SetActive(true);
        Imag[2].SetActive(true);
        Imag[3].SetActive(true);
        Imag[4].SetActive(true);
        Imag[5].SetActive(true);
        Imag[6].SetActive(true);
        Imag[7].SetActive(true);
        Imag[8].SetActive(true);
        Imag[9].GetComponent<Image>().color = Color.black;
        Imag[10].GetComponent<Text>().color = Color.green;
        Imag[11].GetComponent<Image>().color = Color.white;
        Imag[12].GetComponent<Text>().color = Color.black;
        images = true;
    }
    public void OffI()
    {
        Imag[0].SetActive(false);
        Imag[1].SetActive(false);
        Imag[2].SetActive(false);
        Imag[3].SetActive(false);
        Imag[4].SetActive(false);
        Imag[5].SetActive(false);
        Imag[6].SetActive(false);
        Imag[7].SetActive(false);
        Imag[8].SetActive(false);
        Imag[9].GetComponent<Image>().color = Color.white;
        Imag[10].GetComponent<Text>().color = Color.black;
        Imag[11].GetComponent<Image>().color = Color.black;
        Imag[12].GetComponent<Text>().color = Color.green;
        images = false;
    }
    public void Play()
    {
        if (settings == true)
        {
            if (ifs[0].text.Length >= 1 && ifs[1].text.Length >= 1 && ifs[2].text.Length >= 1 && ifs[3].text.Length >= 1 && ifs[4].text.Length >= 1)
            {
                if (ifs[0].text.Length <= 7 && ifs[1].text.Length <= 7 && ifs[2].text.Length <= 7 && ifs[3].text.Length <= 7 && ifs[4].text.Length <= 7)
                {
                    PlayerPrefs.SetString("txt1", ifs[0].text);
                    PlayerPrefs.SetString("txt2", ifs[1].text);
                    PlayerPrefs.SetString("txt3", ifs[2].text);
                    PlayerPrefs.SetString("txt4", ifs[3].text);
                    PlayerPrefs.SetString("txt5", ifs[4].text);
                    if (sec[2] > 2 && sec[3] >= 10)
                    {
                        PlayerPrefs.SetFloat("ot", sec[2]);
                        PlayerPrefs.SetFloat("do", sec[3]);
                        if (boss == 1)
                        {
                            PlayerPrefs.SetInt("Selection", 1);
                            if (modes == 1)
                            {
                                if (sec[0] >= 20)
                                {
                                    PlayerPrefs.SetFloat("Timer", sec[0]);
                                    PlayerPrefs.SetInt("Pick", 1);
                                    if (images == true && ib[0] == true) DontDestroyOnLoad(sa[0]);
                                    if (images == true && ib[1] == true) DontDestroyOnLoad(sa[1]);
                                    if (images == true && ib[2] == true) DontDestroyOnLoad(sa[2]);
                                    SceneManager.LoadScene(2);
                                }
                            }
                            else if (modes == 2)
                            {
                                PlayerPrefs.SetInt("Pick", 2);
                                if (images == true && ib[0] == true) DontDestroyOnLoad(sa[0]);
                                if (images == true && ib[1] == true) DontDestroyOnLoad(sa[1]);
                                if (images == true && ib[2] == true) DontDestroyOnLoad(sa[2]);
                                SceneManager.LoadScene(4);
                            }
                            else if (modes == 3)
                            {
                                if (sec[1] >= 2)
                                {
                                    PlayerPrefs.SetInt("Pick", 3);
                                    if (images == true && ib[0] == true) DontDestroyOnLoad(sa[0]);
                                    if (images == true && ib[1] == true) DontDestroyOnLoad(sa[1]);
                                    if (images == true && ib[2] == true) DontDestroyOnLoad(sa[2]);
                                    PlayerPrefs.SetFloat("Healbar", sec[1]);
                                    SceneManager.LoadScene(5);
                                }
                            }
                            else
                            {
                                StartCoroutine(er());
                            }
                        }
                        else if (boss == 2)
                        {
                            PlayerPrefs.SetInt("Selection", 2);
                            if (modes == 1)
                            {
                                if (sec[0] >= 20)
                                {
                                    PlayerPrefs.SetFloat("Timer", sec[0]);
                                    PlayerPrefs.SetInt("Pick", 1);
                                    if (images == true && ib[0] == true) DontDestroyOnLoad(sa[0]);
                                    if (images == true && ib[1] == true) DontDestroyOnLoad(sa[1]);
                                    if (images == true && ib[2] == true) DontDestroyOnLoad(sa[2]);
                                    SceneManager.LoadScene(2);
                                }
                            }
                            else if (modes == 2)
                            {
                                PlayerPrefs.SetInt("Pick", 2);
                                if (images == true && ib[0] == true) DontDestroyOnLoad(sa[0]);
                                if (images == true && ib[1] == true) DontDestroyOnLoad(sa[1]);
                                if (images == true && ib[2] == true) DontDestroyOnLoad(sa[2]);
                                SceneManager.LoadScene(4);
                            }
                            else if (modes == 3)
                            {
                                if (sec[1] >= 2)
                                {
                                    PlayerPrefs.SetInt("Pick", 3);
                                    PlayerPrefs.SetFloat("Healbar", sec[1]);
                                    if (images == true && ib[0] == true) DontDestroyOnLoad(sa[0]);
                                    if (images == true && ib[1] == true) DontDestroyOnLoad(sa[1]);
                                    if (images == true && ib[2] == true) DontDestroyOnLoad(sa[2]);
                                    SceneManager.LoadScene(5);
                                }
                            }
                            else
                            {
                                StartCoroutine(er());
                            }
                        }
                        else if (boss == 3)
                        {
                            PlayerPrefs.SetInt("Selection", 3);
                            if (modes == 1)
                            {
                                if (sec[0] >= 20)
                                {
                                    PlayerPrefs.SetFloat("Timer", sec[0]);
                                    PlayerPrefs.SetInt("Pick", 1);
                                    if (images == true && ib[0] == true) DontDestroyOnLoad(sa[0]);
                                    if (images == true && ib[1] == true) DontDestroyOnLoad(sa[1]);
                                    if (images == true && ib[2] == true) DontDestroyOnLoad(sa[2]);
                                    SceneManager.LoadScene(2);
                                }
                            }
                            else if (modes == 2)
                            {
                                PlayerPrefs.SetInt("Pick", 2);
                                if (images == true && ib[0] == true) DontDestroyOnLoad(sa[0]);
                                if (images == true && ib[1] == true) DontDestroyOnLoad(sa[1]);
                                if (images == true && ib[2] == true) DontDestroyOnLoad(sa[2]);
                                SceneManager.LoadScene(4);
                            }
                            else if (modes == 3)
                            {
                                if (sec[1] >= 2)
                                {
                                    PlayerPrefs.SetInt("Pick", 3);
                                    if (images == true && ib[0] == true) DontDestroyOnLoad(sa[0]);
                                    if (images == true && ib[1] == true) DontDestroyOnLoad(sa[1]);
                                    if (images == true && ib[2] == true) DontDestroyOnLoad(sa[2]);
                                    PlayerPrefs.SetFloat("Healbar", sec[1]);
                                    SceneManager.LoadScene(5);
                                }
                            }
                            else
                            {
                                StartCoroutine(er());
                            }
                        }
                        else
                        {
                            StartCoroutine(er());
                        }
                    }
                    else
                    {
                        StartCoroutine(er());
                    }
                }
                else
                {
                    StartCoroutine(er());
                }
            }
            else
            {
                StartCoroutine(er());
            }
        }
        else if (settings == false)
        {
            PlayerPrefs.SetInt("Selection", 4);
            if (ifs[0].text.Length >= 1 && ifs[1].text.Length >= 1 && ifs[2].text.Length >= 1 && ifs[3].text.Length >= 1 && ifs[4].text.Length >= 1)
            {
                if (ifs[0].text.Length <= 7 && ifs[1].text.Length <= 7 && ifs[2].text.Length <= 7 && ifs[3].text.Length <= 7 && ifs[4].text.Length <= 7)
                {
                    if (modes == 1)
                    {
                        if (sec[0] >= 20)
                        {
                            PlayerPrefs.SetFloat("Timer", sec[0]);
                            PlayerPrefs.SetInt("Pick", 1);
                            if (images == true && ib[0] == true) DontDestroyOnLoad(sa[0]);
                            if (images == true && ib[1] == true) DontDestroyOnLoad(sa[1]);
                            if (images == true && ib[2] == true) DontDestroyOnLoad(sa[2]);
                            SceneManager.LoadScene(2);
                        }
                    }
                    else if (modes == 2)
                    {
                        PlayerPrefs.SetInt("Pick", 2);
                        if (images == true && ib[0] == true) DontDestroyOnLoad(sa[0]);
                        if (images == true && ib[1] == true) DontDestroyOnLoad(sa[1]);
                        if (images == true && ib[2] == true) DontDestroyOnLoad(sa[2]);
                        SceneManager.LoadScene(4);
                    }
                    else if (modes == 3)
                    {
                        if (sec[1] >= 2)
                        {
                            PlayerPrefs.SetInt("Pick", 3);
                            PlayerPrefs.SetFloat("Healbar", sec[1]);
                            if (images == true && ib[0] == true) DontDestroyOnLoad(sa[0]);
                            if (images == true && ib[1] == true) DontDestroyOnLoad(sa[1]);
                            if (images == true && ib[2] == true) DontDestroyOnLoad(sa[2]);
                            SceneManager.LoadScene(5);
                        }
                    }
                    else
                    {
                        StartCoroutine(er());
                    }
                }
                else
                {
                    StartCoroutine(er());
                }
            }
            else
            {
                StartCoroutine(er());
            }
        }
        else
        {
            StartCoroutine(er());
        }
    }
    IEnumerator er()
    {
        error.SetActive(true);
        yield return new WaitForSeconds(2);
        error.SetActive(false);
    }
}
