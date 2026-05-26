using UnityEngine;

public class Lesson07 : MonoBehaviour
{
    public float rotateSpeed = 10;
    public float tankTaiRotateSpeed = 10;
    public GameObject tankTai;
    public GameObject tankKou;
    public GameObject showPlane;
    public GameObject tankRotateAround;
    private bool isAdd = true;
    private float angle = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        showPlane.transform.Rotate(showPlane.transform.up, rotateSpeed * Time.deltaTime, Space.World);
        if ((tankTai.transform.localEulerAngles.y >= 45) && (tankTai.transform.localEulerAngles.y <=315)
            &&(tankTaiRotateSpeed>0))
            tankTaiRotateSpeed = -tankTaiRotateSpeed;
        else if ((tankTai.transform.localEulerAngles.y >= 45) && (tankTai.transform.localEulerAngles.y <= 315)
            && (tankTaiRotateSpeed < 0))
            tankTaiRotateSpeed = -tankTaiRotateSpeed;
        tankTai.transform.Rotate(tankTai.transform.up, tankTaiRotateSpeed * Time.deltaTime, Space.World);
        #region 错误版1
        //for (int i = 0; i >= -30; i--)
        //{
        //    tankKou.transform.eulerAngles=new Vector3(tankKou.transform.eulerAngles.x, tankKou.transform.eulerAngles.x, i);
        //    if (i <= -30)
        //    {
        //        for (; i >= 0; i++)
        //        {
        //            tankKou.transform.eulerAngles = new Vector3(tankKou.transform.eulerAngles.x, tankKou.transform.eulerAngles.x, i);
        //        }
        //    }
        //}
        //
        #endregion
        #region 直接使用炮筒旋转
        //直接使用炮筒进行旋转
        //旋转看起来很怪
        /*if (isAdd)
        {
            angle += 10 * Time.deltaTime;
            tankKou.transform.Rotate(tankKou.transform.forward, 10 * Time.deltaTime, Space.World);
        }
        else
        {
            angle += -(10 * Time.deltaTime);
            tankKou.transform.Rotate(tankKou.transform.forward, -(10 * Time.deltaTime), Space.World);
        }

        if (angle >= 20)
        {
            isAdd = false;
            print("自加结束 开始自减");
        }
        if (angle <= -30)
        {
            isAdd = true;
            print("自减结束 开始自加");
        }*/
        #endregion

        #region 改良版 使用了空对象作为父对象并旋转父对象

        if (isAdd)
        {
            angle += rotateSpeed * Time.deltaTime;
            tankRotateAround.gameObject.transform.Rotate(Vector3.right, rotateSpeed*Time.deltaTime);
        }else
        {
            angle += -(rotateSpeed * Time.deltaTime);
            tankRotateAround.gameObject.transform.Rotate(Vector3.right, -rotateSpeed*Time.deltaTime);
        }
        if (angle >= 20)
        {
            isAdd = false;
        }
        else if (angle <=-20)
        {
            isAdd = true;
        }
        #endregion

    }
}
