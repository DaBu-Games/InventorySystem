using UnityEngine;

public class StackableBehaviour : IItemBehaviour
{
    private float _amount;

    public StackableBehaviour(float initialAmount)
    {
        _amount = initialAmount;
    }
    
    public void OnPickUp()
    {
        _amount++;
        Debug.Log("Pick up item this is stackable. Item amount:" + _amount);
    }
    
    
}
