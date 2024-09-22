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
        // �������� �������� ����� SerializedObject
        serializedObject.Update();

        SerializedProperty commandsProperty = serializedObject.FindProperty("commands");

        // �������� ������ ������
        EditorGUILayout.PropertyField(commandsProperty, new GUIContent("Commands"), true);

        // Dropdown ��� ������ ���� �������
        selectedCommandType = (CommandType)EditorGUILayout.EnumPopup("Command Type", selectedCommandType);

        // ������ "Add", ��� ������ �������
        if (GUILayout.Button("Add"))
        {
            AddCommand(selectedCommandType);
        }

        // ����������� ���� � SerializedObject
        serializedObject.ApplyModifiedProperties();
    }

    private void AddCommand(CommandType type)
    {
        InstructionData commandList = (InstructionData)target;

        // ������ ��'��� ���������� ���� �� ������ ������
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

        // ��������� ScriptableObject ���� ��������� �������
        EditorUtility.SetDirty(commandList);
    }
}
