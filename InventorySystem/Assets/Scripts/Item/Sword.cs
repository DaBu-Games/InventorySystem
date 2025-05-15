using UnityEngine;

public class Sword : Item
{
    public override void PickUp()
    {
        behaviour?.OnPickUp();
    }
}
