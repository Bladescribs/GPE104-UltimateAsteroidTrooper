using UnityEngine;

public abstract class pawn : MonoBehaviour
{
    public float moveSpeed;

    public float rotateSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public abstract void MoveUp();

    public abstract void MoveDown();

    public abstract void RotateCounterclockwise();

    public abstract void RotateClockwise();

}
