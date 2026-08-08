using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    //Declare our SpriteRenderer component
    public SpriteRenderer theRenderer;

    // Declare a variable for a custom color
    public Color customColor;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Access the "color" property of the SpritRenderer component and change its value to green

        theRenderer.color = customColor; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
