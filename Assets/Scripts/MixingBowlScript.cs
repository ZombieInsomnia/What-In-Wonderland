using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class MixingBowlScript : MonoBehaviour
{
    public bool recipeItems = false;
    bool itemsHaveBeenUsed = false;
    [SerializeField] InventoryManager inventoryManager;
    [SerializeField] OvenScript Oven;
    [SerializeField] ItemPickup itemPickup;
    public Interactable Interactable;
    

    public Dialogue dialogueA;
    public Dialogue dialogueB;
    public Dialogue dialogueC;

    List<int> test = new List<int>();

    public void Mix()
    {
        //interact event sets this function off 
        if (recipeItems == true)
        {
            inventoryManager.Remove();
            itemPickup.PickUp();
            Oven.hasBakingTray = true;
            itemsHaveBeenUsed = true;
            DialogueManager.instance.StartDialogue(dialogueA);
            

        }
        if (recipeItems == false)
        {
            if (itemsHaveBeenUsed == false)
            {
                DialogueManager.instance.StartDialogue(dialogueB);
                //calls the trigger dialogue function in the dialogue script
                Debug.Log("Nothing Happened");
                
            }
            if (itemsHaveBeenUsed == true) 
            {
                DialogueManager.instance.StartDialogue(dialogueC);
                Debug.Log("The bowl is dirty we can't use it");
                
                

            }
        }
    }
    

    
}
