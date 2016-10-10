using UnityEngine;
using System.Collections;

public class ShipHandler : MonoBehaviour {

    public Vector3 posInput;
    public Vector3 rotInput;

    public float speed = 50;

	//[RequireComponent]
    public Rigidbody rb;

    float z;

    void start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        Debug.Log(rb);
        z = gameObject.transform.rotation.eulerAngles.z;


    }

    // Rigidbody rb = new GameObject.getcomponent<Rigidbody>();

    public void MoveInput (Vector3 movement, Vector3 rotation)
    {
        posInput = movement;
        rotInput = rotation;

        rb.AddForce(posInput * speed);
        rb.AddRelativeTorque(rotInput);
        z = 0;
      
    }

}
