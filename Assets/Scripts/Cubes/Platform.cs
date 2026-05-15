using UnityEngine;

public class Platform : MonoBehaviour
{

    public LayerMask cubeMask;
    
    [SerializeField] float cubesFound = 0;
   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 6)
        {
            collision.gameObject.SetActive(false);

            cubesFound ++;
        } 
    }
}
