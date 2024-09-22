using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCommand : BaseGameObjectCommand
{
    private Color color;

    public ColorCommand(Color color)
    {
        this.color = color;
    }

    protected override void ExecuteLocal()
    {
        gameObject.GetComponent<Renderer>().material.color = color;
        onComplete?.Invoke();
    }
}
