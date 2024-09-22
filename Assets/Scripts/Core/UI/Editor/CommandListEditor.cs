using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(InstructionData))]
public class CommandListEditor : Editor
{
    private CommandType selectedCommandType;

    private enum CommandType
    {
        MoveCommandUI,
        RotateCommandUI,
        ColorCommandUI
    }

    public override void OnInspectorGUI()
    {
        // Отримуємо оновлену версію SerializedObject
        serializedObject.Update();

        SerializedProperty commandsProperty = serializedObject.FindProperty("commands");

        // Виводимо список команд
        EditorGUILayout.PropertyField(commandsProperty, new GUIContent("Commands"), true);

        // Dropdown для вибору типу команди
        selectedCommandType = (CommandType)EditorGUILayout.EnumPopup("Command Type", selectedCommandType);

        // Кнопка "Add", щоб додати команду
        if (GUILayout.Button("Add"))
        {
            AddCommand(selectedCommandType);
        }

        // Застосовуємо зміни в SerializedObject
        serializedObject.ApplyModifiedProperties();
    }

    private void AddCommand(CommandType type)
    {
        InstructionData commandList = (InstructionData)target;

        // Додаємо об'єкт відповідного типу до списку команд
        switch (type)
        {
            case CommandType.MoveCommandUI:
                commandList.commands.Add(new MoveCommandUI());
                break;
            case CommandType.RotateCommandUI:
                commandList.commands.Add(new RotateCommandUI());
                break;
            case CommandType.ColorCommandUI:
                commandList.commands.Add(new ColorCommandUI());
                break;
        }

        // Оновлюємо ScriptableObject після додавання команди
        EditorUtility.SetDirty(commandList);
    }
}
