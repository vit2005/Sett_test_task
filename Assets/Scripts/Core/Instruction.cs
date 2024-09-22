using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instruction : IUpdatable
{
    private Queue<ICommand> _commands;
    private ICommand _command;
    private IUpdatable _updatable;
    private Action _onFinish;

    public Instruction(IEnumerable<ICommand> commands, Action onFinish)
    {
        _commands = new Queue<ICommand>(commands);
        _onFinish = onFinish;
    }

    public void ApplyGameObject(GameObject target)
    {
        foreach (ICommand command in _commands)
        {
            if (command is IGameObjectCommand gameObjectCommand)
                gameObjectCommand.SetGameObject(target);
        }
    }

    public void Begin()
    {
        OnCompleted();
    }

    private void OnCompleted()
    {
        if (_commands.Count == 0)
        {
            Debug.Log("Done");
            _onFinish?.Invoke();
            return;
        }

        _command = _commands.Dequeue();
        _updatable = _command is IUpdatable ? _command as IUpdatable : null;
        if (_command != null) 
            _command.Execute(() => OnCompleted());
    }

    public void Update()
    {
        _updatable?.Update();
    }
}
