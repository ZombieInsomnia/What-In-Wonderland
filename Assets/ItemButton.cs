using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ItemButton : MonoBehaviour
{

    Item currentItem;
    public TextMeshProUGUI itemName;
    public Image sprite;

    public void SetItem(Item i)
    {

        currentItem = i;
        itemName.text = i.itemName;
        sprite.sprite = i.icon;
    }

    public void CheckItem()
    {
        InventoryManager.Instance.CheckItems(currentItem);
    }
}
