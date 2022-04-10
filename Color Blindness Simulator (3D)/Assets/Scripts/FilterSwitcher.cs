using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class FilterSwitcher : MonoBehaviour
{
    private ColorGrading colorGrading;
    public PostProcessVolume danomaly;
    public PostProcessVolume panomaly;
    public PostProcessVolume danopia;
    public PostProcessVolume panopia;
    public PostProcessVolume tanomaly;
    public PostProcessVolume tanopia;
    public PostProcessVolume complete;

    void Deuteranomaly()
    {
        colorGrading.active = true;
    }

    void Protanomaly()
    {
        colorGrading.active = true;
    }

    void Deuteranopia()
    {
        colorGrading.active = true;
    }

    void Protanopia()
    {
        colorGrading.active = true;
    }

    void Tritanomaly()
    {
        colorGrading.active = true;
    }

    void Tritanopia()
    {
        colorGrading.active = true;
    }

    public void Complete()
    {
        colorGrading.active = true;
    }

    public void Reset()
    {
        colorGrading.active = false;
    }
}
