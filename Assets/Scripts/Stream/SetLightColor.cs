using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetLightColor : MonoBehaviour
{
    private Light localLight;

    void Setup()
    {
        localLight = GetComponent<Light>();
    }

    public void SetLightColorR(float r)
    {
        Color lightColor = localLight.color;
        lightColor.r = r;
        localLight.color = lightColor;
    }

    public void SetLightColorG(float g)
    {
        Color lightColor = localLight.color;
        lightColor.g = g;
        localLight.color = lightColor;
    }

    public void SetLightColorB(float b)
    {
        Color lightColor = localLight.color;
        lightColor.b = b;
        localLight.color = lightColor;
    }

    public void SetLightColorAlpha(float a)
    {
        Color lightColor = localLight.color;
        lightColor.a = a;
        localLight.color = lightColor;
    }

}
