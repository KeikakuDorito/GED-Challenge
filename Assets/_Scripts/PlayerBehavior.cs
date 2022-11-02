using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    Rigidbody body;
    public float m_force = 20f;

    private void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            body.transform.position = body.transform.up * m_force;
            Debug.Log("jumped");
        }
        if (Input.GetKeyDown("w"))
        {
            print("space key was pressed");
        }
        if (Input.GetKeyDown("a"))
        {
            print("space key was pressed");
        }
        if (Input.GetKeyDown("s"))
        {
            print("space key was pressed");
        }
        if (Input.GetKeyDown("d"))
        {
            print("space key was pressed");
        }
    }
}
