using UnityEngine;

public class Found : MonoBehaviour
{
   bool isFound = false;

    void Update()
    {
        Found();
    }

    private void Found()
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            gameObject.SetActive(false);
        }
    }
}
