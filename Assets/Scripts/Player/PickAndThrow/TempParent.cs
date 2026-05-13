using UnityEngine;

public class TempParent : MonoBehaviour
{
   public static TempParent Inatance { get; private set; }

   private void Awake()
    {
        if(Inatance == null)
        {
            Inatance = this;
        }
        else
        {
            Destroy(this);
        }
    }

}
