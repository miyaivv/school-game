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
    public Button endBtn;

    void Awake()
    {
        Button startbtn = startBnt.GetComponent<Button>();
        startbtn.onClick.AddListener(gameManager.StartGame);

        Button endbtn = endBtn.GetComponent<Button>();
        endbtn.onClick.AddListener(gameManager.RestartGame);
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
