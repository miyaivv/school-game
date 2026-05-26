using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private UIManager UIManager;

    [SerializeField] public bool canMove = true;

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
    }

    public void EndGame()
    {
        canMove = false;
    }
}
