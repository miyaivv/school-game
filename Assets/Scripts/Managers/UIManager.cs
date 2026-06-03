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
    public Button quitBtn;

    void Awake()
    {
        Button startbtn = startBnt.GetComponent<Button>();
        startbtn.onClick.AddListener(gameManager.StartGame);

        Button endbtn = endBtn.GetComponent<Button>();
        endbtn.onClick.AddListener(gameManager.RestartGame);

        Button quitbtn = quitBtn.GetComponent<Button>();
        quitbtn.onClick.AddListener(gameManager.QuitGame);
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
