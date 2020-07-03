﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManage : MonoBehaviour
{
    public GameObject tile;
    private GameObject[] placeholderTile;
    Vector3 pos;

    Vector3 nw = new Vector3(-0.5f, .5f, 0);
    Vector3 ne = new Vector3(0.5f, .5f, 0);
    Vector3 sw = new Vector3(0.5f, -.5f, 0);
    Vector3 se = new Vector3(0.5f, -.5f, 0);

    void Start()
    {
        tile = this.gameObject;

    }

    void FixedUpdate()
    {
        
    }

    void Update()
    {
        int layerMask = 1 << 8;
        RaycastHit hit;

        if (Physics.Raycast(this.transform.position, transform.TransformDirection(nw), out hit, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            Debug.Log("Did Hit");
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            Debug.Log("Did not Hit");
        }
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
