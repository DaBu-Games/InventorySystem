using UnityEngine;

public class NonStackableBehavior : IItemBehaviour
{
    public void OnPickUp()
    {
        Debug.Log("Pick up item but not stackable");
    }
}
