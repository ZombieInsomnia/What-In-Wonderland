using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MixingBowlScript : MonoBehaviour
{
    public bool recipeItems = false;
    bool itemsHaveBeenUsed = false;
    [SerializeField] InventoryManager inventoryManager;
    [SerializeField] OvenScript Oven;
    [SerializeField] ItemPickup itemPickup;
    

    public Dialogue dialogueA;
    public Dialogue dialogueB;
    public Dialogue dialogueC;  
    

    

    public void Mix()
    {
        //interact event sets this function off 
        if (recipeItems == true)
        {
            inventoryManager.Remove();
            itemPickup.PickUp();
            Oven.hasBakingTray = true;
            itemsHaveBeenUsed = true;
            
        }
        if (recipeItems == false)
        {
            if (itemsHaveBeenUsed == false)
            {
                //checks if you have the recipe items in inventory, and if you've used them
                dialogueB.TriggerDialogue();
                //calls the trigger dialogue function in the dialogue script
                Debug.Log("Nothing Happened");
            }
            if (itemsHaveBeenUsed == true) 
            {
                
                Debug.Log("The bowl is dirty we can't use it");
            }
        }
    }
    

    
}
