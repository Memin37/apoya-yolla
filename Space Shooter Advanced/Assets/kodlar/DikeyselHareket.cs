using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DikeyselHareket : MonoBehaviour
{
    Rigidbody2D fizik; 
    Vector2 vec = new Vector2(0, 1); 
    void Start()
    {     
        fizik = GetComponent<Rigidbody2D>();
        fizik.AddForce(vec,ForceMode2D.Impulse);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && gameObject.tag=="Player"|| Input.GetButtonDown("Jump") && gameObject.tag == "Player") 
        {
            fizik.AddForce(-2 * vec, ForceMode2D.Impulse);
            vec = -vec;
        }
        if (Input.GetMouseButtonDown(1) && gameObject.tag=="Enemy")
        {
            fizik.AddForce(-2 * vec, ForceMode2D.Impulse);
            vec = -vec;
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "yöndegistirici") 
        {
            fizik.AddForce(-2*vec, ForceMode2D.Impulse);
            vec = -vec;
        }
    }
}
