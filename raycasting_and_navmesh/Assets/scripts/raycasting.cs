using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycasting : MonoBehaviour
{
    player_movement playermove;
    // Start is called before the first frame update
    void Start()
    {
        playermove = GameObject.Find("Capsule").GetComponent<player_movement>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray,out hit,100f))
            {
                Debug.Log("Name : " + hit.transform.name);
                Debug.Log(hit.point);
                playermove.Moveplayer(hit.point);
            }
        }
    }
}
