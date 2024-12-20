using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DestroyBlock : MonoBehaviour
{
    public static int maxDestroy = 10;
    public static int currentDestroy = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (currentDestroy < maxDestroy)
        {
            Destroy(gameObject);
            currentDestroy++;
        }
        else
        {
            Debug.Log("Out of Destroy");
        }
    }


}
