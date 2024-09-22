using System;

public interface ICommand
{
    void Execute(Action onComplete);
}
