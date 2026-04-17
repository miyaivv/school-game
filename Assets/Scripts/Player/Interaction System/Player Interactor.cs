using System;
using UnityEngine;

public class PlayerInteractor : MonoBehaviour
{
    [SerializeField] public float playerReach;

    public static Action<Interactable> OnItemInteracted;

    Interactable currentInteractable;
    void Update()
    {
        CheckInteraction();

        if (Input.GetKeyDown(KeyCode.E) && currentInteractable != null)
        {
            //currentInteractable.Interact();
            OnItemInteracted?.Invoke(currentInteractable);
        }
    }

    void CheckInteraction()
    {
        RaycastHit hit;
        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);

        if (Physics.Raycast(ray, out hit, playerReach))
        {
            Interactable newInteractable = hit.collider.GetComponent<Interactable>();
            if (newInteractable != null)
            {
                if ((currentInteractable != null) && (newInteractable != currentInteractable))
                {
                    currentInteractable.DisableOutline();
                }

                if (newInteractable.enabled)
                {
                    SetNewCurrentInteractable(newInteractable);
                }
                else
                {
                    DisableCurrentInteractable();
                }
            }
            else
            {
                DisableCurrentInteractable();
            }
        }
        else
        {
            DisableCurrentInteractable();
        }
    }

    void SetNewCurrentInteractable(Interactable _newInteractable)
    {
        currentInteractable = _newInteractable;
        currentInteractable.EnableOutline();

        HUDController.instance.EnableInteractionText(currentInteractable.message);
    }

    void DisableCurrentInteractable()
    {
        HUDController.instance.DisableInteractionText();

        if (currentInteractable)
        {
            currentInteractable.DisableOutline();
            currentInteractable = null;
        }  
    }
}

//CODE FROM: https://www.youtube.com/watch?v=b7Yf6BFx6js