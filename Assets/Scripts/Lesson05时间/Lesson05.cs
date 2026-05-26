using UnityEngine;

public class Lesson05 : MonoBehaviour
{
    public GameObject insObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(insObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
