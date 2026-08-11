using UnityEngine;

public class StarShipPawn : pawn
{

    public float minX;
    public float minY;
    public float maxX;
    public float maxY;
    public float tX;

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

    public override void Teleport()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Vector3 newPosition = new Vector3(randomX, randomY, 0);

        tf.position = newPosition;
    }


    public override void EnableTurbo()
    {
        moveSpeed += tX;
    }

    public override void DisableTurbo()
    {
        moveSpeed -= tX;
    }
}
