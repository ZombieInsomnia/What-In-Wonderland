using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;
    public List<Item> Items = new List<Item>();

    public Transform ItemContent;
    public GameObject InventoryItem;
    public Item initialItem;
    public Item questItem;
    [SerializeField] MixingBowlScript ingredientCheck;
    public TextMeshProUGUI itemName, itemDescription;
    public Image itemDetailedImage;
    public GameObject checkItemPanel;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
        Items.Add(initialItem);
    }

    // Update is called once per frame
    void Update()
    {
        if (Items.Count == 8)
        {
            ingredientCheck.recipeItems = true;
        }
        else if (Items.Count <= 7) 
        {
            ingredientCheck.recipeItems = false;
        }
        ListItems();

    }
    private void Awake()
    {
        Instance = this;
    }

    public void Add(Item item)
    {
        Items.Add(item);
        
        


    }
    public void ListItems()
    {

        foreach (Transform item in ItemContent)
        {
            Destroy(item.gameObject);
        }
        foreach (var item in Items) 
        {
            GameObject obj = Instantiate(InventoryItem, ItemContent);
            var itemName = obj.transform.Find("ItemName").GetComponent<TextMeshProUGUI>();
            var itemIcon = obj.transform.Find("ItemImage").GetComponent<Image>();

            itemName.text = item.itemName;
            itemIcon.sprite = item.icon;
            if (Input.GetMouseButtonDown(0)) 
            {
                CheckItems(item);
              
            }
            

        }
       
    }

   
    public void CheckItems(Item item)
    {
        Debug.Log("check item");
        checkItemPanel.SetActive(true);
        itemName.text = item.itemName;
        itemDescription.text = item.itemDescription;
        itemDetailedImage.sprite = item.itemImage;
    }

   
    public void Remove()
    {
        Items.RemoveRange(1, 7);
    }

    public void QuestItemGiven()
    {
        Items.Remove(questItem);
    }

    
}
