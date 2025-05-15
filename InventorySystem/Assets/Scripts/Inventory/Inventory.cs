using System.Collections.Generic;
using UnityEngine;


public class Inventory : MonoBehaviour
{
    private List<InventorySlot> _inventory = new List<InventorySlot>();
    private InventorySubject _subject;

    private void Awake()
    {
        _subject = new InventorySubject();

        foreach (Transform child in this.transform)
        {
            InventorySlot slot = new InventorySlot(child.gameObject);
            _inventory.Add(slot);
        } 
        
        Debug.Log(_inventory.Count);
    }

    public void AddItem(Item item)
    {
        InventorySlot slot = null;
        
        // check if the item is stackable and if the item is not already in the inventory
        // or if the item is not stackable 
        if ( ( item.behaviour.GetType() == typeof(StackableBehaviour) && HasItemInInventory(item) == null ) || item.behaviour.GetType() == typeof(NonStackableBehavior) )
        { 
            slot = GetEmptySlot();
        }
        
        if (slot == null)
            return;
        
        item.behaviour.OnPickUp();
        _inventory[_inventory.IndexOf(slot)].AddItem(item);
        Debug.Log(_inventory.IndexOf(slot));
        NotifySlotChanged(slot);
    }
    
    public void RemoveItem(Item item)
    {
        InventorySlot slot = HasItemInInventory(item);
        
        if (slot == null)
            return;
        
        _inventory[_inventory.IndexOf(slot)].RemoveItem();
        NotifySlotChanged(slot);
    }

    private InventorySlot HasItemInInventory(Item item)
    {
        foreach (InventorySlot slot in _inventory)
        {
            if (slot.GetItem() == item)
            {
                return slot;
            }
        }
        
        return null;
    }

    private InventorySlot GetEmptySlot()
    {
        foreach (InventorySlot slot in _inventory)
        {
            if (slot.GetItem() == null)
            {
                return slot;
            }
        }
        
        Debug.Log("Inventory full!");
        
        return null;
    }
    
    private void NotifySlotChanged(InventorySlot slot)
    {
        _subject.AddObserver(slot);
        _subject.NotifyObservers();
    }
}
