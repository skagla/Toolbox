using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetLightIntensity : MonoBehaviour
{
    private Light localLight;

    void Setup()
    {
        localLight = GetComponent<Light>();
    }

    public void SetLightintensity(float intensity)
    {
        localLight.intensity = intensity;
    }

}
