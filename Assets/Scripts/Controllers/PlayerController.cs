using UnityEngine;

public class PlayerController : Controller
{
    public KeyCode teleportKey;

    public KeyCode quitKey;

    public KeyCode upLocal;
    public KeyCode downLocal;
    public KeyCode leftLocal;
    public KeyCode rightLocal;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void Start()
    {
      
    }

    // Update is called once per frame
    public override void Update()
    {
        MakeDecisions(); 
    }

    public void MakeDecisions()
    {
        if (Input.GetKey(upLocal))
        {
            // Tell the pawn to move up
            pawn.MoveUp();
        }

        if (Input.GetKey(downLocal))
        {
            // Tell the pawn to move down
            pawn.MoveDown();
        }

        if (Input.GetKey(leftLocal))
        {
            // Tell the pawn to rotate counterclockwise
            pawn.RotateCounterclockwise();
        }

        if (Input.GetKey(rightLocal))
        {
            // Tell the pawn to rotate clockwise
            pawn.RotateClockwise();
        }
    }
}
