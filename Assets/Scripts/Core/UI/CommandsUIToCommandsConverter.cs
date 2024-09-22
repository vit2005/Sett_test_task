using System.Collections.Generic;
using System;
using UnityEngine;

public static class CommandsUIToCommandsConverter
{
    private static Dictionary<Type, IConverter> _conversionMap = new Dictionary<Type, IConverter>()
    {
        { typeof(MoveCommandUI), new MoveCommandConverter() },
        { typeof(RotateCommandUI), new RotateCommandConverter() },
        { typeof(ColorCommandUI), new ColorCommandConverter() },

    };

    public static ICommand Convert(CommandUI commandUI)
    {
        var commandType = commandUI.GetType();
        if (_conversionMap.TryGetValue(commandType, out var converter))
        {
            return converter.Convert(commandUI);
        }
        else
        {
            Debug.LogError($"No converter found for command type: {commandType}");
            return null;
        }
    }
}