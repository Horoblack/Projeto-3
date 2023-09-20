using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItemController : MonoBehaviour
{
    public Items item;

    public Button RemoveButton;
    public void RemoveItem()
    {
        InventoryManager.Instance.Remove(item);
        Destroy(gameObject);
    }

    public void AddItem(Items newItem)
    {
      item = newItem;
    }

    public  void UseItem()
    {
        switch(item._itemType)
        {
            case Items.itemType.Munição:
                Debug.Log("Munição foi adicionada!");
                break;
            case Items.itemType.Bandagem:
              PlayerMove.instance.IncreaseHealth(item.value);
                break;
            default:
                break; 
        }

        RemoveItem();
    }

}
