using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class player_movement : MonoBehaviour
{
    NavMeshAgent m_navmeshagent;
    public GameObject visual;
    // Start is called before the first frame update
    void Start()
    {
        m_navmeshagent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {      
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100f))
            {
                Debug.Log("Name : " + hit.transform.name);
                Debug.Log(hit.point);
                m_navmeshagent.SetDestination(hit.point);
                Instantiate(visual, hit.point, Quaternion.identity);
            
            }
        }
    }
}
