using UnityEngine;


public static class Tools 
{
    public static void sortChild( this Transform transform)
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
    }

    public static Transform customFind(this Transform father, string childName)
    {
        Transform target = null;
        target = father.Find(childName);
        if (target != null)
            return target;
        for (int i = 0; i < father.childCount; i++)
        {
            /*if (father.GetChild(i).Find(childName))
            {
                target = father.GetChild(i);
            }*/
            target = father.GetChild(i).customFind(childName);
            if (target !=null)
            {
                return target;
            }
        }
        return target;
    }
}
