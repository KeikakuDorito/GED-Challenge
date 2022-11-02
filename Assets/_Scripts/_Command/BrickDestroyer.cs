using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static UnityEditor.Progress;

public class BrickDestroyer : MonoBehaviour
{
    static List<Transform> items;

    public static void DestroyItem(Vector3 position)
    {
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i].position == position)
            {
                GameObject.Destroy(items[i].gameObject);
                items.RemoveAt(i);
                break;
            }
        }
    }
}   
