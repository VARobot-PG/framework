﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoordinatePositionFixer : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.eulerAngles = new Vector3(0, 0, 0);
        this.transform.position = this.transform.parent.transform.parent.transform.position+new Vector3(0,0.05f,0);
    }
}
