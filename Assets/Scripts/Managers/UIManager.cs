using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] Platform platform;

    [SerializeField] private TextMeshProUGUI scoreUI;
    public bool isConnected;

    private void Update()
    {
        OnGUI();
    }

    private void OnGUI()
    {
        scoreUI.text = platform.cubesFound + " / 4";
    }

}
