using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private UIManager UIManager;
    [SerializeField] private Platform platform;


    [SerializeField] private GameObject box1;
    [SerializeField] private GameObject box2;
    [SerializeField] private GameObject box3;
    [SerializeField] private GameObject box4;
    [SerializeField] private GameObject player;

    public bool canMove;

    private Vector3 initialPosPL;
    private Vector3 initialPos1;
    private Vector3 initialPos2;
    private Vector3 initialPos3;
    private Vector3 initialPos4;

    void Awake()
    {
        canMove = true;
        //UIManager.StartMenuUI.SetActive(true);
       
        initialPosPL = player.transform.position;
        initialPos1 = box1.transform.position;
        initialPos2 = box2.transform.position;
        initialPos3 = box3.transform.position;
        initialPos4 = box4.transform.position;

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
        canMove = true;
        platform.ResetScore();

        player.transform.position = initialPosPL;
        box1.transform.position = initialPos1;
        box2.transform.position = initialPos2;
        box3.transform.position = initialPos3;
        box4.transform.position = initialPos4;
    }

    public void EndGame()
    {
        canMove = false;
        UIManager.EndMenuUI.SetActive(true);
    }
}
