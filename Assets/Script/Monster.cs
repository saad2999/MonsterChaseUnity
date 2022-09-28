using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [HideInInspector]
    public float speed;
    Rigidbody2D mybody2d;

   
    void Awake()
    {
        mybody2d = GetComponent<Rigidbody2D>();
       
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        mybody2d.velocity = new Vector2(speed, mybody2d.velocity.y);
        
    }
}
