using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCommand : TimedGameObjectCommand
{
    private Vector3 _targetPosition;
    private Vector3 _startPosition;

    public MoveCommand(float duration, Vector3 targetPosition) : base(duration)
    {
        _targetPosition = targetPosition;
    }

    protected override void ExecuteLocal()
    {
        base.ExecuteLocal();
        _startPosition = gameObject.transform.position;
    }

    public override void Update()
    {
        base.Update();
        gameObject.transform.position = Vector3.Lerp(_startPosition, _targetPosition, progress);
    }

    protected override void OnCompleted()
    {
        gameObject.transform.position = _targetPosition;
    }
}
