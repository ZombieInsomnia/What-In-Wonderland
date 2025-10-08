using NUnit.Framework;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Canvas Inventory;
    [SerializeField] InventoryManager inventoryManager;
    public GameObject itemChecker;
   
    
    void Start()
    {
       
        Inventory = GetComponent<Canvas>();
        Inventory.enabled = false;
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Open();
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Close();
        }

    }
    public void Open()
    {
        Inventory.enabled = true;
        Time.timeScale = 0f;
        Debug.Log("Yay");
    }
    public void Close()
    {
        Inventory.enabled = false;
        Time.timeScale = 1f;
        itemChecker.SetActive(false);
    }
  

}
