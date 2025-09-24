using UnityEngine;
using UnityEngine.UI;

public class ItemPickup : MonoBehaviour
{
    public Item Item;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PickUp()
    {
        InventoryManager.Instance.Add(Item);
        Sprite itemIcon = Item.icon;
        string itemName = Item.itemName;
        if(ItemPickupUiController.Instance != null)
        {
            ItemPickupUiController.Instance.ShowItemPickup(itemName, itemIcon, Item);
        }
        
       
        
    }

    public void PickUpButton()
    {
        Destroy(gameObject);
    }
}
