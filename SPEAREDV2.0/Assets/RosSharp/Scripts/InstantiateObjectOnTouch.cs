﻿using UnityEngine;
using System.Collections;

public class InstantiateObjectOnTouch : MonoBehaviour
{
    public GameObject target;

    private bool placedStuff = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && !placedStuff)
        {

            Vector3 fingerPos = Input.GetTouch(0).position;
            fingerPos.z = 3;
            Vector3 objPos = Camera.main.ScreenToWorldPoint(fingerPos);

            Instantiate(target, objPos, Quaternion.identity);

            placedStuff = true;

        }

    }

}
