using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManage : MonoBehaviour
{
    public GameObject tile;
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
    Vector2 sw = new Vector2(-1, -1);
    Vector2 se = new Vector2(1, -1);

    private int TileLayer;
    private bool CastRays = true;

    public Sprite[] phSprites;

    void Start()
    {
        tile = this.gameObject;
        rb = GetComponent<Rigidbody2D>();
        TileLayer = LayerMask.NameToLayer("TileLayer");        
    }

    void FixedUpdate()
    {
        
    }

    void Update()
    {
        RaycastHit2D hitNW = Physics2D.Raycast(this.transform.position, nw, .4f);
        RaycastHit2D hitNE = Physics2D.Raycast(this.transform.position, ne, .4f);
        RaycastHit2D hitSW = Physics2D.Raycast(this.transform.position, sw, .4f);
        RaycastHit2D hitSE = Physics2D.Raycast(this.transform.position, se, .4f);     
        
        if (hitNW.collider == null)
        {
            ChangeSprite(phSprites[1]);
        }

        if (hitNE.collider == null)
        {
            ChangeSprite(phSprites[2]);
        }

        if (hitSE.collider == null)
        {
            if (hitNW.collider == null)
            {
                ChangeSprite(phSprites[14]);
            } else {
                ChangeSprite(phSprites[3]);
            }        
        }   

        if (hitSW.collider == null)
        {
            if (hitNE.collider == null)
            {
                ChangeSprite(phSprites[15]);
            }
            else {
                ChangeSprite(phSprites[4]);
            }
        }

        if (hitNW.collider == null && hitNE.collider == null)
        {
            ChangeSprite(phSprites[5]);
        }

        if (hitNE.collider == null && hitSE.collider == null)
        {
            ChangeSprite(phSprites[6]);
        }

        if (hitSW.collider == null && hitSE.collider == null)
        {
            ChangeSprite(phSprites[7]);
        }

        if (hitNW.collider == null && hitSW.collider == null)
        {
            ChangeSprite(phSprites[8]);
        }

        if (hitNE.collider == null && hitSE.collider == null && hitNW.collider == null)
        {
            ChangeSprite(phSprites[9]);
        }

        if (hitNE.collider == null && hitSE.collider == null && hitSW.collider == null)
        {
            ChangeSprite(phSprites[10]);
        }
        if (hitNW.collider == null && hitSE.collider == null && hitSW.collider == null)
        {
            ChangeSprite(phSprites[11]);
        }
        if (hitNW.collider == null && hitNE.collider == null && hitSW.collider == null)
        {
            ChangeSprite(phSprites[12]);
        }

        if (hitNW.collider == null && hitSW.collider == null && hitNE.collider == null && hitSE.collider == null)
        {
            ChangeSprite(phSprites[13]);
        } 
           
    }

    void ChangeSprite (Sprite tileSprite)
    {
        tile.GetComponent<SpriteRenderer>().sprite = tileSprite;
    }

    void OnMouseDown()
    {
        Destroy(this.gameObject);
    }

   /* IEnumerator BorderManager()
    {
       /* switch (switch_on)
        {

            default:
        }*/

       // yield return Instantiate(placeholderTile[i], pos, Quaternion.identity) ;
    //}
}
