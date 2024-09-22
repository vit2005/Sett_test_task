using UnityEngine;

[System.Serializable]
public class RotateCommandUI : CommandUI
{
    [HideInInspector] public string name = "RotateCommand";
    public Vector3 targetRotation;
    public float duration;
}