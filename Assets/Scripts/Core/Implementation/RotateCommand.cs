using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCommand : TimedGameObjectCommand
{
    private Quaternion _startRotation;
    private Quaternion _targetRotation;

    public RotateCommand(float duration, Vector3 targetPosition) : base(duration)
    {
        _targetRotation = Quaternion.Euler(targetPosition);
    }

    protected override void ExecuteLocal()
    {
        base.ExecuteLocal();
        _startRotation = gameObject.transform.rotation;
    }

    public override void Update()
    {
        base.Update();
        gameObject.transform.rotation = Quaternion.Lerp(_startRotation, _targetRotation, progress);
    }

    protected override void OnCompleted()
    {
        gameObject.transform.rotation = _targetRotation;
    }
}
