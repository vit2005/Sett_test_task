using UnityEngine;

[System.Serializable]
public class MoveCommandUI : CommandUI
{
    [HideInInspector] public string name = "MoveCommand";
    public Vector3 targetPosition;
    public float duration;
}