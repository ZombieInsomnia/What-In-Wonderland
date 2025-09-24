using UnityEngine;

public class OvenScript : MonoBehaviour
    
{
    [SerializeField] InventoryManager inventoryManager;
    public bool hasBakingTray = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Oven()
    {
        if (hasBakingTray == true)
        {
            inventoryManager.QuestItemGiven();
        }
        else
        {
            Debug.Log("Nothing Happened");
        }
    }

    
}
