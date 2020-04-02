using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword_logic : MonoBehaviour
{
    Animator m_animator;
    // Start is called before the first frame update
    void Start()
    {
        m_animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        startattack(Input.GetButtonDown("Fire2"));
       
        /*if(Input.GetButtonDown("Fire2"))
        {
            m_animator.SetBool("isattacking", true);
      
        }
        else
        {
            m_animator.SetBool("isattacking", false);
        }*/
/*        or simply we can do like this
        m_animator.SetBool("isattacking", Input.GetButtonDown("Fire1"));*/
    }
    public void underattack()
    {
       /* Debug.Log("you are under attack");*/
    }
    public void startattack(bool isattacking)
    {
        m_animator.SetBool("isattacking", isattacking);
    }

}
