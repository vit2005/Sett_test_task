using System;
using UnityEngine;

public abstract class BaseGameObjectCommand : BaseCommand, IGameObjectCommand
{
    protected GameObject gameObject;

    public void SetGameObject(GameObject gameObject)
    {
        this.gameObject = gameObject;
    }
}
