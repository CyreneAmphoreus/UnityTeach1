using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Lesson12 : MonoBehaviour
{
    [SerializeField] private Transform gun;
    private PlayerController playerController;
    private float finalX;
    private Vector2 inputPitch;
    [SerializeField]
    private float nowGunPitchX;
    [SerializeField] private float gunPitchSpeed = 0.1f;
    private void Awake()
    {
        playerController = new PlayerController();
        playerController.Enable();
    }

    private void OnEnable()
    {
        playerController.Player.GunPitch.performed += OnGunPitch;
        playerController.Player.GunPitch.canceled += OnGunPitch;
    }

    private void OnDisable()
    {
        playerController.Player.GunPitch.performed -= OnGunPitch;
        playerController.Player.GunPitch.canceled -= OnGunPitch;
        playerController.Disable();
    }

    private void Update()
    {
        /*
         
         Math.Clamp(gun.transform.rotation.eulerAngles.x, -20, 20);
         gun.Rotate(new Vector3(inputPitch.y,0,0));
        */

        #region 新输入系统
        
        
        gun.localEulerAngles=new Vector3(Mathf.Clamp(finalX, -20, 20), 0, 0);
        
        #endregion

        #region 老输入系统
        /*nowGunPitchX = gun.localEulerAngles.x;
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (nowGunPitchX >180)
        {
            nowGunPitchX -= 360;    
        }
        if (scroll != 0)
        {
            gun.localEulerAngles=new Vector3(Mathf.Clamp(nowGunPitchX+scroll, -20, 20), 0, 0);
        }*/

        #endregion
        
        
        
    }

    private void OnGunPitch(InputAction.CallbackContext context)
    {
        Debug.Log($"当前值:{context.ReadValue<Vector2>()}");
        inputPitch = context.ReadValue<Vector2>();
        if (context.performed)
        {
            nowGunPitchX = gun.localEulerAngles.x;
            if (nowGunPitchX >180)
            {
                nowGunPitchX -= 360;    
            }
            finalX = nowGunPitchX + inputPitch.y * gunPitchSpeed;
        }
    }
}
