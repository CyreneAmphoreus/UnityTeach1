using UnityEngine;
using UnityEngine.InputSystem;

public class Lesson14_2 : MonoBehaviour
{
    private PlayerController player;

    private void Awake()
    {
        player = new PlayerController();
    }

    private void OnEnable()
    {
        player.Enable();
        player.Player.Fire.performed += OnCreateCube;
    }

    private void OnDisable()
    {
        player.Player.Fire.performed -= OnCreateCube;
        player.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        #region 老输入系统
        /*if (Input.GetMouseButtonDown(0))
        {
            

            GameObject newCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = 10;
            Vector3 newCubePos = Camera.main.ScreenToWorldPoint(mousePosition);
            newCube.transform.position = newCubePos;

            
        }*/
        #endregion
    }

    private void OnCreateCube(InputAction.CallbackContext context)
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 10;
        Vector3 newCubePos = Camera.main.ScreenToWorldPoint(mousePosition);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = newCubePos;
    }
}
