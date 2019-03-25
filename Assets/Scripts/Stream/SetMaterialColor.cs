using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMaterialColor : MonoBehaviour
{
    private  Renderer render;

    void Setup()
    {
        render = GetComponent<Renderer>();
    }

    public void SetMaterialColorR(float r)
    {
        Color materialColor = render.material.color;
        materialColor.r = r;
        render.material.color = materialColor;
    }

    public void SetMaterialColorG(float g)
    {
        Color materialColor = render.material.color;
        materialColor.g = g;
        render.material.color = materialColor;
    }

    public void SetMaterialColorB(float b)
    {
        Color materialColor = render.material.color;
        materialColor.b = b;
        render.material.color = materialColor;
    }

    public void SetMaterialColorAlpha(float a)
    {
        Color materialColor = render.material.color;
        materialColor.a = a;
        render.material.color = materialColor;
    }



}
