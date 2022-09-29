using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFlow : MonoBehaviour
{
    private Transform player;
    Vector3 tempPos;
    public float minX, maxX;

    private void Awake()
    {
        minX = -53f;
        maxX = 41f;
    }

    // Start is called before the first frame update
    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player").transform;
        
       
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (!player)
            return;
        tempPos = transform.position;
        tempPos.x = player.position.x;
        if(tempPos.x>maxX)
        {
            tempPos.x = maxX;
        }
        if(tempPos.x<minX)
        {
            tempPos.x = minX;
        }
        transform.position = tempPos;
        
    }
}
