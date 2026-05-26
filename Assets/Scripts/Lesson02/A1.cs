using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A1 : MonoBehaviour
{
    public B b;
    // Start is called before the first frame update
    void Start()
    {
        if (b!=null)
        {
            b.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
