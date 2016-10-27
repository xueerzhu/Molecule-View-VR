using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneManage : MonoBehaviour {

    static SceneManager instance;
    public static int currentScene;

    void Update()
    {
        Debug.Log(Input.GetKey("d"));
        Debug.Log("current is " + currentScene);


        if (Input.GetButtonDown("Next"))
        {
            currentScene++;
            SceneManager.LoadScene(currentScene);
        } 

        if (Input.GetButtonDown("Previous") )
        {
            //Debug.Log("Left Trigger button is down");
            currentScene--;
            SceneManager.LoadScene(currentScene);
        }
        if (Input.GetButtonDown("Fire2"))
        {
            //Debug.Log("Fire2 button is down");
            currentScene = 2;
            SceneManager.LoadScene(currentScene);

        }


    }
}
