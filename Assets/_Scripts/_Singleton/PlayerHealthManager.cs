using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealthManager : MonoBehaviour
{
    public static PlayerHealthManager instance;
    int health = 3;
    void Awake()
    {
        if (!instance)
            instance = this;
    }

    public void ChangeHealth(int increment)
    {
        health += increment;
        print("Health: " + health);
    }

    public int GetHealth()
    {
        return health;
    }
}
