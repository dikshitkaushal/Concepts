using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
enum playerstate
{
    idle,
    moving,
    attackmoving
}

public class player_movement : MonoBehaviour
{
    playerstate player;
    NavMeshAgent m_navmeshagent;
    public GameObject visual;
    sword_logic sword;
    bool isattacking = false;
    float melle_range = 4.5f;
    Color collor;
    // Start is called before the first frame update
    void Start()
    {
        player = playerstate.idle;
        sword = GetComponentInChildren<sword_logic>();
        collor = new Vector4(1, 0, 0, 1);
        m_navmeshagent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {

        checkattackrange();
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100f))
            {

                m_navmeshagent.isStopped = false;
                m_navmeshagent.SetDestination(hit.point);
                Instantiate(visual, hit.point, Quaternion.identity);
            
            }
        }
    }
    public void checkattackrange()
    {
        /*if(isattacking)
        {
            return;
        }*/
        Debug.DrawRay(transform.position, transform.forward * melle_range, collor);
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);
        if(Physics.Raycast(ray,out hit,melle_range))
        {
            if(hit.collider.gameObject.transform.tag=="Enemy")
            {
                isattacking = true;
                m_navmeshagent.isStopped = true;
                Debug.Log("Continuous_Attack");
                sword.startattack(true);
            }
        }
        if(hit.distance>melle_range)
        {
            isattacking = false;
        }
    }
}
