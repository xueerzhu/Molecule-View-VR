using UnityEngine;
using VRStandardAssets.Utils;

namespace VRStandardAssets.Menu
{
    // This class 'rotates' each of the menu items out
    // when the user looks at them.
    public class MenuItemRotate : MonoBehaviour
    {
        [SerializeField]
        private Transform m_Transform;         // Used to control the movement whatever needs to rotate.
        [SerializeField]
        private VRInteractiveItem m_Item;      // The VRInteractiveItem of whatever should rotate.
        [SerializeField]
        private float m_RotSpeed = 20f;         // The speed at which the item should rotate.
        [SerializeField]
        private float m_RotAmount = 150f;    // The distance the item should rotate.
        


        private Quaternion m_StartRotation;                        // The position aimed for when the item should not be popped out.
        private Quaternion m_RotRotation;                       // The position aimed for when the item should be popped out.
        private Quaternion m_TargetRotation;                       // The current position being aimed for.



        private void Start()
        {
            // Store the original position as the one that is not rotate.
            m_StartRotation = m_Transform.rotation;

            // Calculate the position the item should be when it's rotate.
            m_RotRotation.eulerAngles = m_Transform.rotation.eulerAngles - new Vector3(0, m_RotAmount ,0) ;
        }


        private void Update()
        {
            
            // Set the target position based on whether the item is being looked at or not.
            m_TargetRotation = m_Item.IsOver ? m_RotRotation : m_StartRotation;
            
            //Rotate towards the target position.
            float step = m_RotSpeed * Time.deltaTime;
            m_Transform.rotation = Quaternion.RotateTowards(m_Transform.rotation, m_TargetRotation, step);



            //debug
            if (m_Item.IsOver)
            {
                Debug.Log("is over lol");
            }
            
        }
    }
}