using UnityEngine;

public class Lesson04_02_a : MonoBehaviour
{
    //public GameObject otherGameObject;
    void Start()
    {
        //otherGameObject.GetComponent<Lesson04_02_b>() .enabled = false;
        GameObject b = GameObject.Find("Lesson04_02_B");  
        Lesson04_02_b lb = b.GetComponent<Lesson04_02_b>();
        lb.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
