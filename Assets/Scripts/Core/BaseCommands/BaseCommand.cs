using System;

public abstract class BaseCommand : ICommand
{
    protected Action onComplete;

    public void Execute(Action onComplete)
    {
        this.onComplete = onComplete;
        ExecuteLocal();
    }

    protected abstract void ExecuteLocal();
}