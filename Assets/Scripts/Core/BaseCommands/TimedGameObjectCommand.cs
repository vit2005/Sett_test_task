using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TimedGameObjectCommand : TimedCommand, IGameObjectCommand
{
    protected GameObject gameObject;

    public TimedGameObjectCommand(float duration) : base(duration) { }

    public void SetGameObject(GameObject gameObject)
    {
        this.gameObject = gameObject;
    }
}
