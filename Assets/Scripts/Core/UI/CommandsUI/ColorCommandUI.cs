using UnityEngine;

[System.Serializable]
public class ColorCommandUI : CommandUI
{
    [HideInInspector] public string name = "ColorCommand";
    public Color targetColor;
}