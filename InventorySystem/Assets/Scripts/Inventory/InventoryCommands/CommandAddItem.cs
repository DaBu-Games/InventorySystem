using UnityEngine;

public class CommandAddItem : ICommand
{
    private Item _item;
    private Inventory _inventory;

    public CommandAddItem(Item item, Inventory inventory)
    {
        _item = item;
        _inventory = inventory;
    }

    public void Execute()
    {
        _inventory.AddItem(_item);
    }
}
