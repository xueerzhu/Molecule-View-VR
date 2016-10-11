using UnityEngine;
using System.Collections;

public class PlayerInputManager : MonoBehaviour {
    ShipHandler shipHandler;
    Vector3 posInput;
    Vector3 rotInput;

	void Start () {
        shipHandler = gameObject.GetComponent<ShipHandler>();
	}
	
	void Update () {

        //get input 
        float movement_horizontal = Input.GetAxis("Oculus_GearVR_LThumbstickX");
        float movement_forward = Input.GetAxis("Oculus_GearVR_LThumbstickY");
        float rotation_horizontal = Input.GetAxis("Oculus_GearVR_RThumbstickX");
        //Vector2 rotation_horizontal = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick);
        Debug.Log(rotation_horizontal);

        float movement_vertical = Input.GetAxis("Oculus_GearVR_RThumbstickY");
        Debug.Log("Y is "+ movement_vertical + "X is " + rotation_horizontal);



        posInput = new Vector3(movement_horizontal, movement_vertical, movement_forward);
        rotInput = new Vector3(0, rotation_horizontal, 0);




    }

    void FixedUpdate()
    {
        // Send Input
        shipHandler.MoveInput(posInput, rotInput);


    }
}
