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
      
        Add(initialItem);
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

    }
    private void Awake()
    {
        Debug.Log("This should only happen once");
        Instance = this;
    }

    public void Add(Item item)
    {
        Items.Add(item);
        GameObject obj = Instantiate(InventoryItem, ItemContent);
        obj.GetComponent<ItemButton>().SetItem(item);
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
