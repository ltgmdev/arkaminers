using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManageTris : MonoBehaviour
{

    public GameObject tile;
    Vector3 pos;
    Rigidbody2D rb;

    /*
          NW        NE
            \      /
              \  /
              /  \
            /      \
          SW        SE
    */

    Vector2 nw = new Vector2(-1, 1);
    Vector2 ne = new Vector2(1, 1);


    public Sprite[] phSprites;

    void Start()
    {
        tile = this.gameObject;
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        RaycastHit2D hitNW = Physics2D.Raycast(this.transform.position, nw, .3f);
        RaycastHit2D hitNE = Physics2D.Raycast(this.transform.position, ne, .3f);      

        if (hitNW.collider == null)
        { 
            ChangeSprite(phSprites[1]);
        } else if (hitNE.collider == null)
            {
                ChangeSprite(phSprites[2]);
            }

        if (hitNE.collider == null && hitNW.collider == null)
        {
            ChangeSprite(phSprites[3]);
        }

        
    }

    void ChangeSprite(Sprite tileSprite)
    {
        tile.GetComponent<SpriteRenderer>().sprite = tileSprite;
    }

    void OnMouseDown()
    {
        Destroy(this.gameObject);
    }
}
