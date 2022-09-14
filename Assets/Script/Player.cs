using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float moveForce = 22f;
    [SerializeField]
    private float jumpForce = 11f;
    private float moveX;
    private Rigidbody2D mybody2d;
    private Animator anim;
    private string WalkAnimation="Walk";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
