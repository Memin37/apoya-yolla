using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lazer : MonoBehaviour
{
    [SerializeField]
    GameObject dusmanpatlama;
    Vector2 vec = new Vector2(0.5f, 0);
    UIKontrol uiKontrol;
    Rigidbody2D fizik;
    void Start()
    {
        uiKontrol = Camera.main.GetComponent<UIKontrol>();
        fizik = GetComponent<Rigidbody2D>();
        fizik.AddForce(vec, ForceMode2D.Impulse);      
    }
    void OnTriggerEnter2D(Collider2D col)
    {       
        if (col.tag == ("Enemy")) 
        {
            Destroy(gameObject);
            GameObject.FindGameObjectWithTag("Audio").GetComponent<SesKontrol>().VurulmaSesi();
            if (uiKontrol.DusmanCaniGuncelle()==0) 
            {
                Destroy(col.gameObject);
                Instantiate(dusmanpatlama, transform.position, Quaternion.identity);
                uiKontrol.OyunBitti();
            }
        }
        if(col.tag== "Yavaslatici") 
        {
            GameObject.FindGameObjectWithTag("Audio").GetComponent<SesKontrol>().FiciPatlama();
            fizik.AddForce(new Vector2(-0.25f,0),ForceMode2D.Impulse);
            if (fizik.velocity == Vector2.zero)
            {
                Destroy(gameObject);
            }
            Destroy(col.gameObject);
        }
        if (col.tag=="sise")
        {
            uiKontrol.PuaniGuncelle();
            Destroy(col.gameObject);
        }
        if (col.tag=="dusmanlazeri")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);    
        }       
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag== "sektirici") 
        {
            Vector2 konum = col.transform.position;
        }
    }
}
