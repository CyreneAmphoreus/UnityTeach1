using UnityEngine;

public class StarAction : MonoBehaviour
{
    public float speed = 10;
    public GameObject rotateTarget;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.RotateAround(rotateTarget.transform.position,rotateTarget.transform.up, speed * Time.deltaTime);
    }
}
