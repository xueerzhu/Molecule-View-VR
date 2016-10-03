using UnityEngine;
using System.Collections;

public class ShipHandler : MonoBehaviour {

    public Vector3 posInput;
    public Vector3 rotInput;

    public bool powered = true;
    public float speed = 10;

	//[RequireComponent]
    Rigidbody rb;

    void start()
    {
        rb = gameObject.GetComponent<Rigidbody>();

    }

   // Rigidbody rb = new GameObject.getcomponent<Rigidbody>();

    public void MoveInput (Vector3 move, Vector3 rote, bool power)
    {
        posInput = move;
        rotInput = rote;
        powered = power;

        ActuallyMove();
    }

    void ActuallyMove()
    {
        Debug.Log("AM was run");

        if (rb)
        {
            Debug.Log("Rigidbody exists");
        }
        else
        {
            Debug.Log("No rigidbody!");
        }


        if (powered)
        {
            speed = 150;
        }
        else
        {
            speed = 0;
        }

        rb.AddRelativeForce(posInput * speed);
        rb.AddRelativeTorque(rotInput);
    }
}
