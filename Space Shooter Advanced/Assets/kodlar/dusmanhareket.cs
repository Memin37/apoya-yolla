using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusmanhareket : MonoBehaviour
{
   
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(-2, 0),ForceMode2D.Impulse);
    }


   
}
