using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spherelogic : MonoBehaviour
{
    float size = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (size > 0)
        {
            size -= Time.deltaTime;
            transform.localScale = Vector3.one * size;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
