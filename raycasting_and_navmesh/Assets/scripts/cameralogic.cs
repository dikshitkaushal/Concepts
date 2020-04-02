using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameralogic : MonoBehaviour
{
    float m_cameraoffset = 0.225f;
    float y_offset = 5.0f;
    float z_offset = -9.0f;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        updatecamera();
        if(Input.GetKey(KeyCode.Space))
        {
            allignwithplayer();
        }
    }

    private void allignwithplayer()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y + y_offset, player.transform.position.z + z_offset);
    
    }

    private void updatecamera()
    {
        if(Input.mousePosition.x>Screen.width)
        {
            //move the camera right
            transform.position = new Vector3(transform.position.x + m_cameraoffset, transform.position.y, transform.position.z);
        }
        else if(Input.mousePosition.x<0)
        {
            //move the camera left
            transform.position = new Vector3(transform.position.x - m_cameraoffset, transform.position.y, transform.position.z);
        }
        if(Input.mousePosition.y>Screen.height)
        {
            //move the camera up
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + m_cameraoffset);
        }
        else if(Input.mousePosition.y<0)
        {
            //move the camera down
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - m_cameraoffset);
        }
    }
}
