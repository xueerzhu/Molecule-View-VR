using UnityEngine;
using VRStandardAssets.Utils;

namespace VRStandardAssets.Examples
{
    // This script is a simple example of how an interactive item can
    // be used to change things on gameobjects by handling events.
    public class ModelInteractiveItem : MonoBehaviour
    {
        [SerializeField]
        private VRInteractiveItem m_InteractiveItem;



        private void OnEnable()
        {
            //m_InteractiveItem.OnOver += HandleOver;
            
            //m_InteractiveItem.OnOut += HandleOut;
            m_InteractiveItem.OnClick += HandleClick;            
        }


        private void OnDisable()
        {
            //m_InteractiveItem.OnOver -= HandleOver;
            /*
            m_InteractiveItem.OnOut -= HandleOut;
            m_InteractiveItem.OnClick -= HandleClick;
            m_InteractiveItem.OnDoubleClick -= HandleDoubleClick;
            */
        }


        //Handle the Over event
        /*
        private void HandleOver()
        {
            Debug.Log("Show over state");
            gameObject.transform.localScale = gameObject.transform.localScale * 2;
        }
        

       
        //Handle the Out event
        private void HandleOut()
        {
            Debug.Log("Show out state");
            m_Renderer.material = m_NormalMaterial;
        }
        */


        //Handle the Click event
        private void HandleClick()
        {
            Debug.Log("Show click state");
            // transit scene code here
        }
    }

}