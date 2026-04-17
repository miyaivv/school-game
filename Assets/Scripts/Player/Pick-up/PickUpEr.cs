using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SearchService;

public class PickUpEr : MonoBehaviour
{
    [SerializeField] private Transform[] inventory;
    /* [SerializeField] private GameObject CubeMini;
    [SerializeField] private GameObject Cube1Mini;
    [SerializeField] private GameObject Cube2Mini; */

    private bool isFree = true;
    private bool isAllowed;
    private Interactable holding;
    

    private void OnEnable()
    {
        PlayerInteractor.OnItemInteracted += ItemPickedUp;
        holding = null;
    }

    private void OnDisable()
    {
        PlayerInteractor.OnItemInteracted -= ItemPickedUp;
    }

    //The List
    string[] pickupables = {"Cube", "Cube1", "Cube2"};

    /*private void Update()
    {
        PickUp();
        CheckAllowed();
    }*/

    private void ItemPickedUp(Interactable interactable)
    {
        if (holding == null)
        {
            InteractableType itemType = interactable.Type;
            inventory[(int)itemType].gameObject.SetActive(true);
        }
    }
    /*
    private void PickUp()
    {
        if ()  //if Interacted
        {
            if ((isFree = true) && (isAllowed = true))
            {
                
                

            } 
        }
    }


    private void CheckAllowed()
    {

        foreach (string i in pickupables)
        {
            if (i == objTag)
            {
                break;
                isAllowed = true;
            }
            else
            {
                isAllowed = false;
            }
        }

    }

    private void GetTag()
    {
        //ADD Code that gets the tag of the interacted with object that has a name objTag

    }

    private void ShowCube()
    {
        if (objTag = "Cube")
        {
            CubeMini.SetActive(true);
        }
    }

    private void ShowCube1()
    {
        if (objTag = "Cube1")
        {
            Cube1Mini.SetActive(true);
        }
    }

    private void ShowCube2()
    {
        if (objTag = "Cube2")
        {
            Cube2Mini.SetActive(true);
        }
    }*/

}

//  If the player interacted with an object, see if the object has a tag from a list of allowed pickupables, if yes check if the player has already picked up smth else, if player hand is free then
//  turn on the pickedupobject corresponding to the given tag, if no to any of the ifs ,nothing happens.

// For now im going to use Cube, Cube1 and Cube2 for testing