using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item/Create New Item")]
public class Item : ScriptableObject 
{
    public int id;
    public string itemName;
    public Sprite icon;
    public enum ItemType
    {
        Misc,
        Ingredient,
    }
    public Sprite itemImage;
    [TextArea]
    public string itemDescription;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
