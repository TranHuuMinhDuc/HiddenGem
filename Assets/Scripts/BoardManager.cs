using System;
using System.Collections.Generic;
using UnityEngine;



public class BoardManager : MonoBehaviour
{
    public int rows = 5;
    public int columns = 5;

    public GameObject tilePrefab;
    public Transform boardParent;

    public GameObject gemPrefab;
    public Transform gemParent;

    public float tileSpacing = 1.1f;

    [SerializeField] private Transform _camera;

   

    // Start is called before the first frame update
    void Start()
    {
        generateGem();  
        generateBoard();
        moveCamera();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void generateBoard()
    {
        for (int x = 0; x < rows; x++)
        {
            for (int y = 0; y < columns; y++)
            {
                Vector3 position =  new Vector3(x * tileSpacing, y * tileSpacing, 0);
                GameObject tile = Instantiate(tilePrefab, position, Quaternion.identity, boardParent);

                

            }
        }

    }

    void generateGem()
    {
        int totalGems = UnityEngine.Random.Range(1,3);

        for (int i = 0;i < totalGems; i++)
        {
            int randomX = UnityEngine.Random.Range(0, rows);
            int randomY = UnityEngine.Random.Range(0, columns);

            Vector3 position = new Vector3(randomX * tileSpacing, randomY * tileSpacing, 0);

            GameObject gem = Instantiate(gemPrefab, position, Quaternion.identity, gemParent);
        }
    }


    void moveCamera()
    {
        float centerX = (rows - 1) * tileSpacing / 2; 
        float centerY = (columns - 1) * tileSpacing / 2;
        Vector3 centerPosition = new Vector3(centerX, centerY, _camera.position.z);

        _camera.position = centerPosition;
    }

    
}
