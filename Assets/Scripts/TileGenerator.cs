using Packages.Rider.Editor.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGenerator : MonoBehaviour
{    
    public GameObject tileTypeLos;
    public GameObject tileTypeTri;
    float positioningHor;
    float positioningVer;
    bool has8tiles;

    void Start()
    {
        /* OLD GENERATOR
        positioningHor = 0f;
        positioningVer = 5f;

        //normal tiles (start)
        for (int i = 0; i < 7; i++)
        {
            if (i % 2 == 0)
            {
                positioningHor = (-2.815f);
                has8tiles = false;
            } else
            {
                positioningHor = (-2.413f);
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
            positioningVer -= 0.425f;           
        }

        // starting tiles only

        positioningHor = (-2.46f);
        positioningVer = 2.026f;

        for (int i = 0; i < 8; i++)
        {
            Instantiate(tileTypeTri, new Vector3(positioningHor, positioningVer, -4), Quaternion.identity);
            positioningHor += 0.804f;
        }

        OLD GENERATOR*/



    }

    void Update()
    {
        
            
        
    }

    void LosTileLineSpawner() 
    {
        Instantiate(tileTypeLos, new Vector3(positioningHor, positioningVer, -4), Quaternion.identity);
        positioningHor += 0.7f;
    }

}
