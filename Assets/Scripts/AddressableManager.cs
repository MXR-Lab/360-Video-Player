using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.ResourceManagement.AsyncOperations;

public class AddressableManager : MonoBehaviour

{
    //Level Loading

    private bool clearPreviousScene = false;
    private SceneInstance previousLoadedScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadAddressableLevel(string addressableKey)
    {
        /*if (clearPreviousScene)
        {
            Addressables.UnloadSceneAsync(previousLoadedScene).Completed += (asyncHandle) =>
            {
                clearPreviousScene = true;
                previousLoadedScene = new SceneInstance();
            };
        }*/
        Addressables.LoadSceneAsync(addressableKey, UnityEngine.SceneManagement.LoadSceneMode.Single)/*.Completed += (asyncHandle) =>
        {
            clearPreviousScene = true;
            previousLoadedScene = asyncHandle.Result;
        }*/;
    }
}
