﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverObjeto : MonoBehaviour
{
    public GameObject tempParent;
    public Transform guide;

    GameObject item;

    // Start is called before the first frame update
    void Start()
    {
        item = gameObject;
        item.GetComponent<Rigidbody>().useGravity = true;
    }

    void OnMouseDown()
    {
        item.GetComponent<Rigidbody>().useGravity = false;
        item.GetComponent<Rigidbody>().isKinematic = true;
        item.transform.position = guide.transform.position;
        //item.transform.rotation= guide.transform.rotation;
        item.transform.parent = tempParent.transform;

        Debug.Log("-------------------Llevando: " + gameObject.name+"-------------------");
    }

    void OnMouseUp()
    {
        item.GetComponent<Rigidbody>().useGravity = true;
        item.GetComponent<Rigidbody>().isKinematic = false;
        item.transform.parent = null;
        item.transform.position = guide.transform.position;
    }

}
