using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class SceneManage : MonoBehaviour
{
    //private SceneManager sceneManager;

    private void Start() {
        //SceneManager.LoadScene("scene select", LoadSceneMode.Single);
    }
    public void LoadVideo(string name) {
        //sceneManager.UnloadSceneAsync(sceneManager.GetActiveScene());
        SceneManager.LoadScene(name, LoadSceneMode.Single);
    }
    public void LoadSelect() {
       // sceneManager.UnloadSceneAsync(sceneManager.GetActiveScene());
        SceneManager.LoadScene("scene select", LoadSceneMode.Single);
    }
    public void Unload()
    {
        SceneManager.UnloadSceneAsync("scene select");
    }

    
}
