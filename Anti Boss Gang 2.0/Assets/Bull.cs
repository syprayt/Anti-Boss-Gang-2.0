using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bull : MonoBehaviour
{
    public GameObject lv;
    public GameObject en;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bull")
        {
            lv.GetComponent<Boss_Defeat>().hp -= 1;
            en.GetComponent<Enemy>().enabled = true;
            this.gameObject.transform.position = new Vector2(0, 0);
            this.gameObject.SetActive(false);
        }
    }
}
