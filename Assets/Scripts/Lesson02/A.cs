using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A : MonoBehaviour
{
    private B bScript;
    // Start is called before the first frame update
    void Start()
    {
        bScript = this.GetComponent<B>();
        bScript.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
