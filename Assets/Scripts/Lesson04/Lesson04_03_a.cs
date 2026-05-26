using System.Diagnostics.Contracts;
using UnityEngine;

public class Lesson04_03_a : MonoBehaviour
{
    public GameObject b;
    public enum E_Do_Type
    {
        ChangeName,
        ActiveFlase,
        DelayDes,
        Des
    }
    public E_Do_Type nowType = E_Do_Type.ChangeName;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        switch (nowType)
        {
            case E_Do_Type.ChangeName:
                b.name = "改名后的B对象";
                break;
            case E_Do_Type.ActiveFlase:
                b.SetActive(false);
                break;
            case E_Do_Type.DelayDes:
                Destroy(b,5);
                break;
            case E_Do_Type.Des:
                Destroy(b);
                break;
            default:
                break;
        }
    }
}
