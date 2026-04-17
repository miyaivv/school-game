using UnityEngine;
using UnityEngine.Events;

public enum InteractableType : byte //BETTER PERFORMANCE WHEN BYTE  
{
    Red = 0,
    Yellow = 1,
    Blue = 2
}

public class Interactable : MonoBehaviour
{
    Outline outline;
    [SerializeField] public string message;
    [SerializeField] public InteractableType Type;

    public UnityEvent onInteraction;


    void Start()
    {
        outline = GetComponent<Outline>();
        DisableOutline();
    }

    public void Interact()
    {
        onInteraction.Invoke();
    }


    public void DisableOutline()
    {
        outline.enabled = false;
    }


    public void EnableOutline()
    {
        outline.enabled = true;
    } 
}

//CODE FROM: https://www.youtube.com/watch?v=b7Yf6BFx6js