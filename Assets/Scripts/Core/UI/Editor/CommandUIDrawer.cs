using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(CommandUI), true)]
public class CommandUIDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        // Отримуємо поле "name" для виведення його в якості заголовка
        SerializedProperty nameProperty = property.FindPropertyRelative("name");
        string commandName = nameProperty != null ? nameProperty.stringValue : "Command";

        // Виводимо кастомний заголовок для кожного елемента списку
        EditorGUI.PropertyField(position, property, new GUIContent(commandName), true);
    }

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        // Встановлюємо висоту для відображення всіх полів команди
        return EditorGUI.GetPropertyHeight(property, label, true);
    }
}
