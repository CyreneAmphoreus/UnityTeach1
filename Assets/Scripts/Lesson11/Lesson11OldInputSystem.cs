using System;
using UnityEngine;

public class Lesson11OldInputSystem : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed=20f;
    [SerializeField]
    private float sensitivity=5f;
    private Transform tankHead;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tankHead = transform.Find("Tank_Head");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
        {
            transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed);
            transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed);
        }

        if (Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0)
        {
            tankHead.Rotate(Vector3.up * Input.GetAxis("Mouse X") * Time.deltaTime * sensitivity);
        }
    }
}
