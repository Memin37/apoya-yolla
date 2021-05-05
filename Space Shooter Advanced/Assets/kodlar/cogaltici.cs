using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cogaltici : MonoBehaviour
{ 
    public GameObject lazerasagi,düşmanlazerasagi;   
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "PlayerRay")
        {
            GameObject.FindGameObjectWithTag("Audio").GetComponent<SesKontrol>().TasPatlama();
            Instantiate(lazerasagi, transform.position, Quaternion.identity);
            Instantiate(lazerasagi, transform.position, Quaternion.identity);
            Instantiate(lazerasagi, transform.position, Quaternion.identity);
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
        if (col.tag == "dusmanlazeri")
        {
            GameObject.FindGameObjectWithTag("Audio").GetComponent<SesKontrol>().TasPatlama();      
            Instantiate(düşmanlazerasagi, transform.position, Quaternion.identity);
            Instantiate(düşmanlazerasagi, transform.position, Quaternion.identity);
            Instantiate(düşmanlazerasagi, transform.position, Quaternion.identity);
            Destroy(col.gameObject);
            Destroy(gameObject);  
        }  
    }
}
