using System;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] Platform platform;

    [SerializeField] private TextMeshProUGUI scoreUI;

    [SerializeField] public GameObject StartMenuUI;
    [SerializeField] public GameObject EndMenuUI;


    private void Update()
    {
        OnGUI();
    }

    private void OnGUI()
    {
        scoreUI.text = platform.cubesFound + " / 4";
    }

}
