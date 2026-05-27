using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] Platform platform;
    [SerializeField] GameManager gameManager;

    [SerializeField] private TextMeshProUGUI scoreUI;

    [SerializeField] public GameObject StartMenuUI;
    [SerializeField] public GameObject EndMenuUI;

    public Button startBnt;

    void Awake()
    {
        Button btn = startBnt.GetComponent<Button>();
        btn.onClick.AddListener(gameManager.RestartGame);
    }

    private void Update()
    {
        OnGUI();
    }

    private void OnGUI()
    {
        scoreUI.text = platform.cubesFound + " / 4";
    }

}
