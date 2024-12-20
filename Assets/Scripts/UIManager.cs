using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    
    public GameObject uiManager;
    
    // Start is called before the first frame update
    void Start()
    {
        hideUI();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (DestroyBlock.currentDestroy >= DestroyBlock.maxDestroy)
        {
            showUI();

        }
    }
    

    void hideUI()
    {
        uiManager.SetActive(false);
        
    }
    void showUI()
    {
        uiManager.SetActive(true);
    }
}
