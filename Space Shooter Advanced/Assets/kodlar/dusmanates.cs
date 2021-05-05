using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusmanates : MonoBehaviour
{
    [SerializeField]
    GameObject dusmanlazerprefab;
    GeriSayimAraci geriSayimAraci;
    void Start()
    {
        geriSayimAraci = gameObject.AddComponent<GeriSayimAraci>();
        geriSayimAraci.ToplamSure = 3; 
        geriSayimAraci.Calistir();
    }                  
    void Update()
    {
        if (geriSayimAraci.Bitti) 
        {  
            if (Input.GetButtonDown("Fire2"))
            {
                geriSayimAraci.Calistir();
                Vector2 vec = new Vector2(transform.position.x - 1.25f, transform.position.y - 0.1f);
                Instantiate(dusmanlazerprefab, vec, Quaternion.identity);
                GameObject.FindGameObjectWithTag("Audio").GetComponent<SesKontrol>().Ates();
                GameObject.FindGameObjectWithTag("Audio").GetComponent<SesKontrol>().YenidenDoldur();
            }
        }     
    }
}
