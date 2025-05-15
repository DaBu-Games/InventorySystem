using System;
using UnityEngine;
using UnityEngine.Events;

public class AddItem : MonoBehaviour
{
    [SerializeField]public Inventory inventory;
    private ICommand _command;

    private void Start()
    {
        GameObject swordObject = new GameObject("Sword");
        Item sword = swordObject.AddComponent<Sword>();
        sword.Initialize("Sword", "strong sword with big dmg", new NonStackableBehavior(), this.gameObject);
        _command = new CommandAddItem(sword, inventory);
    }

    private void Update()
    {
        if ( Input.GetKeyDown(KeyCode.Space) )
        {
            _command.Execute();
        }
    }
}
