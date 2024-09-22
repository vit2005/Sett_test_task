using UnityEngine;

public abstract class TimedCommand : BaseCommand, IUpdatable
{
    protected float duration;
    protected float elapsedTime;

    public float progress => elapsedTime / duration;

    public TimedCommand(float duration)
    {
        this.duration = duration;
    }

    protected override void ExecuteLocal()
    {
        elapsedTime = 0f;
    }

    public virtual void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= duration)
        {
            OnCompleted();
            onComplete?.Invoke();
        }
    }

    protected abstract void OnCompleted();
}
