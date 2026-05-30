using UnityEngine;

public class Lesson15 : MonoBehaviour
{
    [SerializeField] private Light candleLight;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float flashSpeed;
    [SerializeField] private Light directionalLight;
    private void Update()
    {
        //蜡烛 : 左右轻微来回摆动、光源亮度波动
        candleLight.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        if (candleLight.transform.position.x >= 1)
        {
            moveSpeed = -moveSpeed;
        }
        else if (candleLight.transform.position.x <= 0.6)
        {
            moveSpeed = -moveSpeed;
        }
        
        candleLight.intensity += flashSpeed * Time.deltaTime;
        if (candleLight.intensity >= 1)
        {
            flashSpeed = -flashSpeed;
        }else if (candleLight.intensity <= 0.6)
        {
            flashSpeed = -flashSpeed;
        }
        
        //方向光旋转 来实现昼夜更替
        directionalLight.transform.Rotate(Vector3.right, 30 * Time.deltaTime);
    }
}
