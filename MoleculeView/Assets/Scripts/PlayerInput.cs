using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour {
    ShipHandler sHandler;
    bool powered = false;
    Vector3 moveInput;
    Vector3 rotInput;


    void Start () {
        sHandler = gameObject.GetComponent<ShipHandler>();
	}
	
	void Update()
    {
        // receive input

        Vector2 h2 = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);
        Debug.Log(h2);
        bool up = OVRInput.Get(OVRInput.Button.DpadUp);
        bool down = OVRInput.Get(OVRInput.Button.DpadDown);
        float y;
        float ry;
        if (up)
        {
			y = 1;
        } 
		else if (down)
        {
            y= -1;
        }
        else
        {
            y = 0;
        }

        bool rl = OVRInput.Get(OVRInput.Button.DpadLeft);
        bool rr = OVRInput.Get(OVRInput.Button.DpadRight);
        float power = OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger);
        if (rr)
        {
            ry = 1;
        }
        else if (rl)
        {
            ry = -1;
        }
        else
        {
            ry = 0;
        }

        // regulate input to vector forces
        Vector2 rh2 = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick);

        moveInput = new Vector3(h2.x, h2.y, y);
        rotInput = new Vector3(rh2.x, rh2.y, ry);
        if (power > 0.5)
        {
            powered = true;
        }


    }

    void FixedUpdate()
    {
        // send input
        sHandler.MoveInput(moveInput, rotInput, powered);
    }
    
}
