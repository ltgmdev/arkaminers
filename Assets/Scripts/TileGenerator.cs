using Packages.Rider.Editor.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGenerator : MonoBehaviour
{
    public GameObject tileTypeLos;
    public GameObject tileTypeTri;
    public GameObject tilingGameObject;
    public GameObject tritilingGameObject;

    //GameObject line1, line2, line3, line4, line5, line6, line7, line8;
    [SerializeField] GameObject[] lines;

    public Camera cam;

    float posHor;
    float posVer;
    bool has7tiles;
    bool control = true;

    void Start()
    {
        cam = Camera.main;
        Vector3 upperLeftScreen = new Vector3(0, Screen.height, -4);
        Vector3 initialPos = cam.ScreenToWorldPoint(upperLeftScreen);

        SpriteRenderer tileLos = tileTypeLos.GetComponent<SpriteRenderer>();
        float widthTileLos = tileLos.bounds.size.x;
        float heightTileLos = tileLos.bounds.size.y;

        SpriteRenderer tileTri = tileTypeTri.GetComponent<SpriteRenderer>();
        float widthTileTri = tileTri.bounds.size.x;
        //float heightTileTri = tileTri.bounds.size.y;      

        //normal tiles (start)

        posVer = initialPos.y;
        for (int i = 0; i < 7; i++)
        {
            
            if (i % 2 == 0)
            {
                has7tiles = false;
            }
            else
            {
                has7tiles = true;
            }

            if (has7tiles)
            {   //lines 2, 4, 6...
                posHor = initialPos.x + (widthTileLos / 2) ;               
                for (int j = 0; j < 7; j++)
                {
                    Instantiate(tileTypeLos, new Vector3(posHor, posVer, -4), Quaternion.identity, lines[i].transform);
                    posHor += widthTileLos;
                }
            }
            else
            {   //lines 1, 3, 5...
                posHor = initialPos.x;
                for (int j = 0; j < 8; j++)
                {
                    Instantiate(tileTypeLos, new Vector3(posHor, posVer, -4), Quaternion.identity, lines[i].transform);
                    posHor += widthTileLos;
                }
            }
            posVer -= heightTileLos / 2;
        }

        // start only, triangles
        posHor = initialPos.x + (widthTileLos / 2);
        for (int i = 0; i < 7; i++)
        {
            Instantiate(tileTypeTri, new Vector3(posHor, 2.4f, -4), Quaternion.identity, lines[8].transform);
            posHor += widthTileTri;
        }
    }

    private void FixedUpdate()
    {
        SpriteRenderer tileLos = tileTypeLos.GetComponent<SpriteRenderer>();
        float heightTileLos = tileLos.bounds.size.y;


        if (lines[8].transform.childCount == 0)
        {
            while (control)
            {
                tilingGameObject.transform.position -= Vector3.up * heightTileLos;
                control = false;
            }
            

        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}

