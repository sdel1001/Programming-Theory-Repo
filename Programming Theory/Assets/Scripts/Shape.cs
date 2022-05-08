using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    // Start is called before the first frame update
    string m_Name;
    Color m_Color;

    public string Name   // property
    {
        get { return m_Name; }   // get method
        set { m_Name = value; }  // set method
    }

    public Color Color
    {
        get { return m_Color; }   // get method
        set { m_Color = value; }  // set method
    }

    public Shape()
    {
    }

    public Shape(string name, Color color)
    {
        SetProperties(name, color);
    }

    protected void SetProperties(string name, Color color)
    {
        Name = name;
        Color = color;
    }

    protected virtual void OnClick()
    {
        Debug.Log("You clicked on " + m_Name);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        OnClick();
    }
}
