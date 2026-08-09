using UnityEngine;

public class StarShipPawn : pawn
{
    private Transform tf;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tf = transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void MoveDown()
    {
        tf.position = tf.position + (-tf.up * moveSpeed * Time.deltaTime);
    }

    public override void MoveUp()
    {
        tf.position = tf.position + (tf.up * moveSpeed * Time.deltaTime);
    }

    public override void RotateClockwise()
    {
        tf.Rotate(0f, 0f, -rotateSpeed * Time.deltaTime);
    }

    public override void RotateCounterclockwise()
    {
        tf.Rotate(0f, 0f, rotateSpeed * Time.deltaTime);
    }
}
