using UnityEngine;

public abstract class Item : MonoBehaviour, IItem
{
    public string itemName { get; protected set; }
    public string description { get; protected set; }
    public IItemBehaviour behaviour { get; protected set; }
    public GameObject itemObject { get; protected set; }

    public void Initialize(string itemName, string description, IItemBehaviour behaviour, GameObject itemObject)
    {
        this.itemName = itemName;
        this.description = description;
        this.behaviour = behaviour;
        this.itemObject = itemObject;
    }
    
    public abstract void PickUp();
}
