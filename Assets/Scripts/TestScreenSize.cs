using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScreenSize : MonoBehaviour
{
    public Camera cam;
    [SerializeField] GameObject testObject;
    float widthTile;
    float heightTile;

    float posHor;
    float posVer;
    float spacer;


    void Start()
    {
        cam = Camera.main;
        Vector3 upperLeftScreen = new Vector3(0, Screen.height, -4);
        Vector3 initPos = cam.ScreenToWorldPoint(upperLeftScreen);

        SpriteRenderer tile = testObject.GetComponent<SpriteRenderer>();
        Debug.Log(tile);
        widthTile = tile.bounds.size.x;
        heightTile = tile.bounds.size.y;

        posVer = initPos.y;

        Debug.Log("Width tile: " + widthTile);
        Debug.Log("Height tile: " + heightTile);

        bool has8Tiles = true;

        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                spacer = initPos.x;
                if (i % 2 == 0)
                {
                    //posHor = spacer;
                    //Instantiate(testObject, new Vector3(posHor, posVer, -4), Quaternion.identity);
                    // (has8tiles);
                }
                else
                {
                    //posHor = spacer;
                    //Instantiate(testObject, new Vector3((posHor + widthTile), posVer, -4), Quaternion.identity);                    
                }
                spacer = posHor + widthTile;
            }
            posVer -= heightTile / 2;
        }       
    }

    void Update()
    {
        
    }
}
