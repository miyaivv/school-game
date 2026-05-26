using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private UIManager UIManager;
    [SerializeField] private Platform Platform;


    [SerializeField] private GameObject box1;
    [SerializeField] private GameObject box2;
    [SerializeField] private GameObject box3;
    [SerializeField] private GameObject player;

    public bool canMove = true;

    void Awake()
    {
       
    }
    
    void Update()
    {
        UIManager.isConnected = true;
    }

    public void StartGame ()
    {
        canMove = true;
        Platform.ResetScore();
    }

    public void EndGame()
    {
        canMove = false;
    }
}
