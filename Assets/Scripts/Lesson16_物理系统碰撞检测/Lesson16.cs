using UnityEngine;
using UnityEngine.InputSystem;

public class Lesson16 : MonoBehaviour
{
    private PlayerController playerController;
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform muzzle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        playerController = new PlayerController();
        
    }

    private void OnEnable()
    {
        playerController.Enable();
        playerController.Player.Fire.performed += OnFire;
    }

    private void OnDisable()
    {
        playerController.Player.Fire.performed -= OnFire;
        playerController.Disable();
    }
    
    void Update()
    {
        /*老输入系统
         if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(bullet, muzzle.position, muzzle.rotation);
        }*/
    }

    private void OnFire(InputAction.CallbackContext context)
    {
        Instantiate(bullet, muzzle.position, muzzle.rotation);
    }
}
