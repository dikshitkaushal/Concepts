using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class player_movement : MonoBehaviour
{
    NavMeshAgent m_navmeshagent;
    // Start is called before the first frame update
    void Start()
    {
        m_navmeshagent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Moveplayer(Vector3 hitpos)
    {
        m_navmeshagent.SetDestination(hitpos);
    }
}
