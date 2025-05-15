using UnityEngine;

public class InventorySlot : IObserver
{
   private GameObject _slot;
   private Item _item;

   public InventorySlot(GameObject slot)
   {
      _slot = slot;
   }

   public GameObject GetSlot()
   {
      return _slot;
   }
   
   public Item GetItem()
   {
      return _item;
   }

   public void AddItem(Item item)
   {
      _item = item;
   }
   
   public void RemoveItem()
   {
      _item = null;
   }

   public void Update()
   {
      Debug.Log("Update UI");
   }
}
