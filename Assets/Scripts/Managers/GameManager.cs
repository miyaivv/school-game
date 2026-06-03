using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private UIManager UIManager;
    [SerializeField] private Platform platform;

    public bool canMove;

    void Awake()
    {
        canMove = false;
    }
    
    void Update()
    {
        if (platform.cubesFound == 4)
        {
            EndGame();
        }
    }

    public void RestartGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void StartGame()
    {
        canMove=true;
        UIManager.StartMenuUI.SetActive(false);
    }


    public void EndGame()
    {
        canMove = false;
        UIManager.EndMenuUI.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
