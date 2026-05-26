using UnityEngine;
using static UnityEditor.Tools;

namespace Lesson09
{
    public class Lesson09 : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        private void Start()
        {
            transform.sortChild();
            //想复杂了其实根本不用自己写算法 api提供了对应查找的方法 而且自己写的还不能查找重儿子
            // isChilds("a1");
            
            // 直接使用Transform的Find性能损耗比较大 因为是全局查找
            // isChildsAlpha("a3");

            if (transform.customFind("a3"))
            {
                print($"找到了{transform.customFind("a3").name}");
            }
        }

        // Update is called once per frame
        private void Update()
        {
        
        }

        /*
         搬运至Tools静态工具类中
         public void sortChild()
        {
            for (int i = 0; i < transform.childCount-1; i++)
            {
                Transform max = transform.GetChild(0);
                for (int j = 0; j < transform.childCount-i; j++)
                {
                    if (max.name.Length < transform.GetChild(j).name.Length)
                    {
                        max = transform.GetChild(j);
                    }
                }
                max.SetSiblingIndex(transform.childCount - i-1);
            }
        }*/

        public void isChilds(string childName)
        {
            for (int i = 0; i < transform.childCount-1; i++)
            {
                if (transform.GetChild(i).name.ToString()==childName)
                {
                    print("是子类");
                    break;
                }
            }
        }

        public void isChildsAlpha(string childName)
        {
            if (transform.Find(childName))
            {
                print("是子类");
            }
        }
    }
}
