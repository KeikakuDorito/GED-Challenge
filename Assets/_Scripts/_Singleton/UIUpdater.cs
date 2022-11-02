using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using TMPro;

public class UIUpdater : MonoBehaviour
{
    TextMeshProUGUI livesUI;

    private void Start()
    {
        livesUI = GetComponent<TextMeshProUGUI>();
    }
    // Update is called once per frame
    void Update()
    {
        livesUI.text = "Health: " + PlayerHealthManager.instance.GetHealth();
    }
}
