using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class Inventario : MonoBehaviour
{
    public GameObject inv;
    public bool isOpen;
    public GameObject manager;

    public void ButtonToggle()
    {
        isOpen = false;
    }

    public void AbreFecha()
    {


        if (!isOpen && Input.GetKeyDown(KeyCode.I))
        {
      
            inv.SetActive(true);
            InventoryManager _inventoryManager = manager.GetComponent<InventoryManager>();
            _inventoryManager.ListItems();
            isOpen = true;
        }
        else if (isOpen && Input.GetKeyDown(KeyCode.I))
        {
       
            inv.SetActive(false);
            isOpen = false;
        }
    }

private void Update()
    {
        AbreFecha();
    }


}
