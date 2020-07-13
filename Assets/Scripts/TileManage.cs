using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManage : MonoBehaviour
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
        RaycastHit2D hitNW = Physics2D.Raycast(this.transform.position, nw);
        RaycastHit2D hitNE = Physics2D.Raycast(this.transform.position, ne);
        RaycastHit2D hitSW = Physics2D.Raycast(this.transform.position, sw);
        RaycastHit2D hitSE = Physics2D.Raycast(this.transform.position, se);

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
            ChangeSprite(phSprites[3]);
        }

        if (hitSW.collider == null)
        {
            ChangeSprite(phSprites[4]);
        }

        if (hitSE.collider == null)
        {
            ChangeSprite(phSprites[3]);
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

        if (hitNE.collider == null && hitSE.collider == null)
        {
            ChangeSprite(phSprites[9]);
        }



        if (hitNW.collider == null && hitSW.collider == null && hitNE.collider == null && hitSE.collider == null)
        {
            ChangeSprite(phSprites[13]);
        }

        

        /*
        RaycastHit hit;

        if (Physics2D.Raycast(this.transform.position, nw, out hit, 1))
        {

        }*/


    }

    void ChangeSprite (Sprite tileSprite)
    {
        tile.GetComponent<SpriteRenderer>().sprite = tileSprite;
    }

    void OnMouseDown()
    {
        Destroy(this.gameObject);
        pos = this.transform.position;
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
