using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    // Start is called before the first frame update
    void Start()
    {
        SetProperties("Cube", Color.red);
    }

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
