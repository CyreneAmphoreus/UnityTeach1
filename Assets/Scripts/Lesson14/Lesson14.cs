using UnityEngine;

public class Lesson14 : MonoBehaviour
{
    private Vector3 pos;
    private void Start()
    {
        pos = Camera.main.WorldToScreenPoint(transform.position);
        Debug.Log(pos);
    }
}
