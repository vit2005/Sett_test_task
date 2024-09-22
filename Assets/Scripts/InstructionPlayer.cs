using Mono.Reflection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionPlayer : MonoBehaviour
{
    [SerializeField] private InstructionData data;
    private Instruction _instruction;

    void Start()
    {
        List<ICommand> commands = new List<ICommand>();
        foreach (var commandUI in data.commands)
        {
            commands.Add(CommandsUIToCommandsConverter.Convert(commandUI));
        }

        _instruction = new Instruction(commands, () => OnFinish());
        _instruction.ApplyGameObject(gameObject);
        _instruction.Begin();
    }

    private void OnFinish()
    {
        enabled = false;
    }

    void Update()
    {
        _instruction?.Update();
    }
}
