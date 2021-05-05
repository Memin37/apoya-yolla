using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class düşmanlazeri : MonoBehaviour
{
    [SerializeField]
    GameObject patlama;
    Rigidbody2D fizik;
    UIKontrol uiKontrol;
    void Start()
    {
        fizik = GetComponent<Rigidbody2D>();
        fizik.AddForce(new Vector2(-0.5f, 0), ForceMode2D.Impulse);
        uiKontrol = Camera.main.GetComponent<UIKontrol>();
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        { 
            Destroy(gameObject);
            GameObject.FindGameObjectWithTag("Audio").GetComponent<SesKontrol>().VurulmaSesi();
            if (uiKontrol.CaniGuncelle() == 0)
            {
                Instantiate(patlama, transform.position, Quaternion.identity);
                Destroy(col.gameObject);
                uiKontrol.OyunBitti();
            }
        }
        if (col.tag == "Yavaslatici")
        {
            GameObject.FindGameObjectWithTag("Audio").GetComponent<SesKontrol>().FiciPatlama();
            fizik.AddForce(new Vector2(0.25f, 0), ForceMode2D.Impulse); 
            if (fizik.velocity == Vector2.zero)
            {
                Destroy(gameObject);
            }
            Destroy(col.gameObject);
        }
        if (col.tag == "sise")
        {
            uiKontrol.PuaniGuncelle();
            Destroy(col.gameObject);
        }
        if (col.tag == "PlayerRay")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}
