using UnityEngine;

public class SpriteScaler : MonoBehaviour
{
    private Transform tf;

    public float moveSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tf = transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            tf.position = tf.position + Vector3.up * moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            tf.position = tf.position - Vector3.up * moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            tf.position = tf.position + Vector3.right * moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            tf.position = tf.position + Vector3.left * moveSpeed * Time.deltaTime;
        }
    }
}
