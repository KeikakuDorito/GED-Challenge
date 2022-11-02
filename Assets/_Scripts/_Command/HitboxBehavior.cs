using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static UnityEditor.Progress;

public class HitboxBehavior : MonoBehaviour
{
    ICommand command;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Hitbox")
        {
            command = new DestroyBrickCommand(collision.transform.position, collision.transform);
            CommandInvoker.AddCommand(command);
        }
    }
}
