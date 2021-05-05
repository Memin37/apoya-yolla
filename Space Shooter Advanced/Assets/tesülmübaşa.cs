using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tesülmübaşa : MonoBehaviour
{
    Rigidbody2D fizik;
    void Start()
    {
        fizik = GetComponent<Rigidbody2D>();
        fizik.AddForce(new Vector2(1, 0), ForceMode2D.Impulse);
    }





}
