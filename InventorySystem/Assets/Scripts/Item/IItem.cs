using UnityEngine;

public interface IItem
{
    string itemName { get; }
    string description { get; }
    IItemBehaviour behaviour { get; }
    GameObject itemObject { get; }
}
