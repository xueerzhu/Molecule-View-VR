using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneManage : MonoBehaviour {

    static SceneManager instance;
    public static int currentScene;

    void Update()
    {
        Debug.Log(Input.GetKey("d"));
        Debug.Log("current is " + currentScene);


        if (Input.GetKey("d"))
        {
            currentScene++;
            SceneManager.LoadScene(currentScene);
        } 

        if (Input.GetKey("a"))
        {
            currentScene--;
            SceneManager.LoadScene(currentScene);
        }


    }
}
