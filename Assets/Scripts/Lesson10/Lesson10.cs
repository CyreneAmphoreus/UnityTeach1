using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Lesson10 : MonoBehaviour
{
    PlayerController playerController;

    private void Awake()
    {
        playerController = new PlayerController();
        
    }

    private void OnEnable()
    {
        playerController.Enable();
        playerController.Player.Interact.performed += OnInteract;
        
    }

    private void OnDisable()
    {
        playerController.Disable();
        playerController.Player.Interact.performed -= OnInteract;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnInteract(InputAction.CallbackContext context)
    {
        Debug.Log(context.control.name);
        if (context.control.name == "f")
        {
            OnSkill();
        }

        if (context.control.name == "v")
        {
            OnCreateSphere();
        }
    }
    void OnSkill()
    {
        Vector3 itemPos = new Vector3(-1, 0, 1);
        new GameObject().transform.position = transform.TransformPoint(itemPos);
    }

    void OnCreateSphere()
    {
        for (int i = 1; i <= 3; i++)
        {
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere.transform.position = transform.TransformPoint(new Vector3(0, 0, i));
        }
    }
}
