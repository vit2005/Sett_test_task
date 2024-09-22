using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(CommandUI), true)]
public class CommandUIDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        // �������� ���� "name" ��� ��������� ���� � ����� ���������
        SerializedProperty nameProperty = property.FindPropertyRelative("name");
        string commandName = nameProperty != null ? nameProperty.stringValue : "Command";

        // �������� ��������� ��������� ��� ������� �������� ������
        EditorGUI.PropertyField(position, property, new GUIContent(commandName), true);
    }

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        // ������������ ������ ��� ����������� ��� ���� �������
        return EditorGUI.GetPropertyHeight(property, label, true);
    }
}
