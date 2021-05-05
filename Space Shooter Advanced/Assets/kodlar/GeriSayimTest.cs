using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeriSayimTest : MonoBehaviour
{
    GeriSayimAraci geriSayimAraci;
    float baslangicZamani;
    void Start()
    {
        geriSayimAraci = gameObject.AddComponent<GeriSayimAraci>();
        geriSayimAraci.ToplamSure = 3;
        geriSayimAraci.Calistir();
        baslangicZamani = Time.time;

    }

    
    void Update()
    {
        if (geriSayimAraci.Bitti) 
        {

            float gecenZaman = Time.time - baslangicZamani;
            print(gecenZaman);
            baslangicZamani = Time.time;
            geriSayimAraci.Calistir();
            
        
        }
    }
}
