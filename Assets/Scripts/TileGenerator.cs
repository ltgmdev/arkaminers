using Packages.Rider.Editor.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGenerator : MonoBehaviour
{    
    public GameObject tileTypeA;
    public GameObject tileTypeQ;
    float positioningHor;
    float positioningVer;
    bool has8tiles;

    void Start()
    {
        positioningHor = 0f;
        positioningVer = 5f;

        //normal tiles (start)
        for (int i = 0; i < 9; i++)
        {
            if (i % 2 == 0)
            {
                positioningHor = (-2.81f);
                has8tiles = false;
            } else
            {
                positioningHor = (-2.46f);
                has8tiles = true;
            }

            if (has8tiles)
            {
                for (int j = 0; j < 8; j++)
                {
                    TileLineSpawner();
                }
            }
            else
            {
                for (int j = 0; j < 9; j++)
                {
                    TileLineSpawner();
                }
            }
            positioningVer -= 0.35f;           
        }

        // starting tiles only

        positioningHor = (-2.46f);
        positioningVer = 2.026f;

        for (int i = 0; i < 8; i++)
        {
            Instantiate(tileTypeQ, new Vector3(positioningHor, positioningVer, -4), Quaternion.identity);
            positioningHor += 0.7f;
        }

    }

    void Update()
    {
        
            
        
    }

    void TileLineSpawner() 
    {
        Instantiate(tileTypeA, new Vector3(positioningHor, positioningVer, -4), Quaternion.identity);
        positioningHor += 0.7f;
    }

}
