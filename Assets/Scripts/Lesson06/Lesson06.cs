using UnityEngine;

public class Lesson06 : MonoBehaviour
{
    public GameObject insObject;
    public GameObject tankPrefab;
    GameObject tankObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(insObject);
        tankObject = Instantiate(tankPrefab);
    }

    // Update is called once per frame
    void Update()
    {
        tankObject.transform.Translate(Vector3.forward*1*Time.deltaTime,Space.Self);
    }
}
