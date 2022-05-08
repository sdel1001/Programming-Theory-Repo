using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// INHERITANCE
public class Cylinder : Shape
{
    // Start is called before the first frame update
    void Start()
    {
        SetProperties("Cylinder", Color.green);
    }

    // POLYMORPHISM”
    protected override void OnClick()
    {
        base.OnClick();
        GetComponent<Renderer>().material.color = Color;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
